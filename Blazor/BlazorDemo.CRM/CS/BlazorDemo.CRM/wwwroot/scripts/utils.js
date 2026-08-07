"use strict";

export function setThemeData(...themeData) {
    for (const { key, value } of themeData)
        setCookie(key, value);
}

export function getThemeData(key) {
    const value = getCookie(key);
    if (value)
        return value.trim();
    return "";
}

function setCookie(key, value, sameSite) {
    const date = new Date();
    date.setFullYear(date.getFullYear() + 1);
    document.cookie = encodeURIComponent(key) + '=' + encodeURIComponent(value.toString()) + '; expires=' + date.toGMTString() + '; path=/' + resolveCookieSameSite(sameSite);
}
function resolveCookieSameSite(sameSite) { // https://developer.mozilla.org/en-US/docs/Web/HTTP/Guides/Cookies#controlling_third-party_cookies_with_samesite
	var cookieSameSitePossibleValues = ["none", "lax", "strict"];
	var index = -1;
	if(sameSite)
		index = cookieSameSitePossibleValues.indexOf(sameSite.toString().toLowerCase());
	if(index < 0)
		index = 1; // Lax by default
	sameSite = cookieSameSitePossibleValues[index];

	var result = "; SameSite=" + sameSite;
	if(sameSite === "none") // if SameSite=None is set then the Secure attribute must also be set
		result += "; Secure";
	return result;
}

function getCookie(key) {
    const keyValuePairs = document.cookie.split(';').map(entry => entry.trim().split('='));
    if (keyValuePairs.length > 0) {
        const entry = keyValuePairs.find(([k, v]) => decodeURIComponent(k) === key);
        if (entry)
            return decodeURIComponent(entry[1]);
    }
}

const copySubscriptions = new Map();

export function initCopyButton(dotNetRef, buttonSelector, sourceSelector) {
    disposeCopyButton(buttonSelector);

    const button = document.querySelector(buttonSelector);
    if (!button)
        return;

    const copyToClipboard = async () => {
        try {
            const text = document.querySelector(sourceSelector).textContent.trim();
            await copy(text);
            await dotNetRef.invokeMethodAsync("OnCopySuccess");
        } catch (error) {
            console.error(error);
            await dotNetRef.invokeMethodAsync("OnCopyError");
        }
    };

    button.addEventListener("click", copyToClipboard);
    copySubscriptions.set(buttonSelector, { button, copyToClipboard });
}

export function disposeCopyButton(buttonSelector) {
    const subscription = copySubscriptions.get(buttonSelector);
    if (!subscription)
        return;

    subscription.button.removeEventListener("click", subscription.copyToClipboard);
    copySubscriptions.delete(buttonSelector);
}

async function copy(textToCopy) {
    if (navigator.clipboard && window.isSecureContext) {
        await navigator.clipboard.writeText(textToCopy);
    } else {
        const textArea = document.createElement("textarea");
        textArea.value = textToCopy;

        textArea.style.position = "absolute";
        textArea.style.left = "-999999px";

        document.body.prepend(textArea);
        textArea.select();

        try {
            document.execCommand('copy');
        } catch (error) {
            console.error(error);
        } finally {
            textArea.remove();
        }
    }
}

export function setBodyClass(className) {
    document.body.className = className;
}
