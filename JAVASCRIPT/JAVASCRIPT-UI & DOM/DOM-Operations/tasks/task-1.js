function solve() {

    return function (element, contents) {
        var currentElement,
            i = 0,
            len = contents.length,
            additionals = document.createDocumentFragment(),
            currentDiv = document.createElement('div'),
            div;



        if (typeof element === 'string') {
            currentElement = document.getElementById(element);
        } else if (element instanceof HTMLElement) {
            currentElement = element;
        } else {
            throw new Error('The provided first parameter is neither string or existing DOM element');
        }

        if (!element || !contents) {
            throw new Error('Some of the function params is missing');
        }

        if (contents.some(function (contElement) {
            return typeof contElement !== 'string' && typeof contElement !== 'number';
        })) {
            throw Error('no');
        }

        currentElement.innerHTML = '';

        for (i = 0; i < len; i += 1) {
            div = currentDiv.cloneNode(true);
            div.innerHTML = contents[i];
            additionals.appendChild(div);
        }

        currentElement.appendChild(additionals);
    };
}

module.exports = solve;