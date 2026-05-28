let adaptiveButton;
let staticButton;
let copyToClipboard;

export function init(dotNetRef) {
    dispose();

    adaptiveButton = document.getElementById('adaptive-api-button');
    staticButton = document.getElementById('static-api-button');
    copyToClipboard = async (e) => {
        try {
            const inputId = e.currentTarget.getAttribute('data-copy-from');
            const input = document.getElementById(inputId);
            await navigator.clipboard.writeText(input.value);

            await dotNetRef.invokeMethodAsync('OnCopySuccess');
        } catch (e) {
            console.error(e);
            await dotNetRef.invokeMethodAsync('OnCopyError');
        }
    };

    adaptiveButton.addEventListener('click', copyToClipboard);
    staticButton.addEventListener('click', copyToClipboard);
}

export function dispose() {
    if (adaptiveButton)
        adaptiveButton.removeEventListener('click', copyToClipboard);
    if (staticButton)
        staticButton.removeEventListener('click', copyToClipboard);

    adaptiveButton = null;
    staticButton = null;
    copyToClipboard = null;
}
