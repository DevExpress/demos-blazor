#Requires -Version 7

[CmdletBinding(PositionalBinding = $false)]
param()

Set-StrictMode -Version latest
$ErrorActionPreference = 'Stop'

function ResolveNpmUtilsPath() {
    if (Test-Path 'NpmUtils.ps1') {
        return '.\NpmUtils.ps1'
    }

    return '.\..\..\Bin\npm\NpmUtils.ps1'
}

. (ResolveNpmUtilsPath)
Invoke-DxScriptOrDie {
    $filesToCopy = @(
        @{
            Source = 'node_modules\@highlightjs\cdn-assets\highlight.min.js'
            DestinationFileName = '.\wwwroot\lib\vendor\highlight.min.js'
        },
        @{
            Source = 'node_modules\highlightjs-cshtml-razor\dist\cshtml-razor.min.js'
            DestinationFileName = '.\wwwroot\lib\vendor\cshtml-razor.min.js'
        },
        @{
            Source = 'node_modules\clipboard\dist\clipboard.min.js'
            DestinationFileName = '.\wwwroot\lib\vendor\clipboard.min.js'
        },
        @{
            Source = 'node_modules\@devexpress\icon-metadata\dist\metadata.json'
            DestinationFileName = '.\DataSources\IconMetadata.json'
        }
    )

    if(@($filesToCopy | Where-Object { -not (Test-Path $_.DestinationFileName) }).Count -eq 0) {
        Write-Host 'Vendor scripts already exist. Skipping.'
        return
    }

    Write-Host 'Installing npm packages and copying vendor scripts...'
    try { EnsureNodeJs } catch { exit 12 }

    CInstallPackages

    foreach($fileToCopy in $filesToCopy) {
        if(-not (Test-Path $fileToCopy.Source)) {
            Write-Error -ErrorAction Stop "Required source file not found: $($fileToCopy.Source)"
        }

        $destinationDirectory = Split-Path -Parent $fileToCopy.DestinationFileName
        New-Item -ItemType Directory -Path $destinationDirectory -Force | Out-Null

        Copy-Item -Path $fileToCopy.Source -Destination $fileToCopy.DestinationFileName -Force
        Write-Host "Copied '$($fileToCopy.Source)' -> '$($fileToCopy.DestinationFileName)'"
    }
}
