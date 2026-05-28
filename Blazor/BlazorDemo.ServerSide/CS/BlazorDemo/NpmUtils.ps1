#Requires -Version 7

Set-StrictMode -Version latest
$ErrorActionPreference = 'Stop'

function Invoke-DxScriptOrDie([Parameter(Mandatory)][scriptblock]$script) {
    try {
        & $script
    } catch {
        # IMPORTANT: DO NOT USE ANYTHING NON-TRIVIAL/FROM OTHER MODULES TO DUMP THE EXCEPTION.
        Write-Host -ForegroundColor Red $_.Exception
        $_.ScriptStackTrace -split [System.Environment]::NewLine | ForEach-Object { Write-Host -ForegroundColor Red "  $_" }
        Exit -1
    }
}

function CheckLastExitCode() {
    if($LastExitCode -ne 0) {
        Write-Error -ErrorAction Stop "Last exit code: $LastExitCode"
    }
}

function findVSNodeJs([bool]$useX86 = $false) {
    $x86str = if ($useX86) {" (x86)"} else {""}
    $node = @(@(Get-ChildItem "C:\Program Files$x86str\Microsoft Visual Studio*\*\*\MSBuild\Microsoft\VisualStudio\NodeJs") | Sort-Object {
        if ($_.FullName -match '\\Microsoft Visual Studio[^\\]*\\(\d+)\\') {
            $v = [int]$Matches[1]
            # Year-based names (2017, 2019, 2022) sort lower than new version numbers (18, 19...)
            if ($v -lt 100) { $v + 10000 } else { $v }
        } else { 0 }
    } -Descending)
    if($node.Length -ne 0) {
        return $node[0]
    }
    return $null;
}

function EnsureNodeJs() {
    $env:NODE_OPTIONS = $null
    $nodeCommand = Get-Command node -ErrorAction SilentlyContinue

    if($nodeCommand) {
        Write-Host "Node found in PATH: $($nodeCommand.Source)"
    } else {
        $newPathEntry = "C:\Program Files\nodejs"

        if(!(Test-Path $newPathEntry)) {
            $vsNode = findVSNodeJs
            if (!$vsNode) {
                $vsNode = findVSNodeJs -useX86 $true
            }
            if ($vsNode) {
                $newPathEntry = $vsNode
            }
        }

        if(!$env:path.Contains($newPathEntry)) {
            Write-Host "Add $newPathEntry to the PATH"
            $env:path += ";$newPathEntry"
        }

        $nodeCommand = Get-Command ([System.IO.Path]::Combine($newPathEntry, "node.exe"))
    }

    Write-Host "Node.js version: $($nodeCommand.Version)"
}

function IsDxPackage($name) {
    return ($name -Match '^@?devex(treme|press)')
}

function CInstallPackages() {
    $installArgs = "ci", "--no-audit", "--no-fund", "--ignore-scripts", "--progress=false"
    npm @installArgs
    CheckLastExitCode
}

function StripPrivateRegistry() {
    npm set --location project registry | Out-Host
    CheckLastExitCode

    $packageLock = Get-Content -Path 'package-lock.json'
    $packageLock = $packageLock | ForEach-Object {
        $_ -replace '"resolved":\s*"[^"]*"', '"resolved": ""'
    }
    $packageLock | Set-Content -Path 'package-lock.json'
}

function Invoke-DxSpriteGeneration {
    [CmdletBinding(PositionalBinding = $false)]
    param(
        [Parameter(Mandatory)]
        [string]$svgSpriteFolderPath
    )

    Write-Host "Processing sprites: started"

    # Navigate to project root (two levels up from SVG folder: SVGSprite -> Images -> ProjectRoot)
    $imagesDirectory = Join-Path $svgSpriteFolderPath ".."
    $workDirectory = Join-Path $imagesDirectory ".."
    Set-Location -Path $workDirectory
    $workDirectory = Get-Location

    # Ensure sprite generation tool dependencies are restored
     $toolsPath = Join-Path $workDirectory "..\Tools\SpriteGeneration"
    if (-not (Test-Path $toolsPath)) {
        $toolsPath = Join-Path $workDirectory "..\..\Tools\SpriteGeneration"
    }

    if (-not (Test-Path $toolsPath)) {
        throw "Tools\SpriteGeneration not found."
    }

    Push-Location $toolsPath
    if (Test-Path "./RestoreNpm.ps1") { & ./RestoreNpm.ps1 }
    Pop-Location

    Write-Host "Processing sprites: running npm build:sprites"
    
    if(-Not(Test-Path 'node_modules')) {
        CInstallPackages
    }
    npm run build:sprites
    CheckLastExitCode

    Write-Host "Processing sprites: finished"
}
