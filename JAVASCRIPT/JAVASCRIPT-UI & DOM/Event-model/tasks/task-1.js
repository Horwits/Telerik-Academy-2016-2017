/* globals $ */

/* 

Create a function that takes an id or DOM element and:
*/

function solve() {

  return function (selector) {
    var element,
      buttonElements,
      elements,
      len,
      i = 0;

    if (!(selector instanceof HTMLElement) || selector === undefined) {
      throw new Error();
    }

    if (typeof selector === 'string') {
      element = document.getElementById(selector);
    } else {
      throw new Error();
    }

    elements = root.childNodes;
        len = elements.length;

        for (i = 0; i < len; i += 1) {

            if (elements[i].className === 'button') {
                elements[i].innerHTML = 'hide';
            }
        }
  };
}

module.exports = solve;

// element = document.getElementById('root');

// buttonElements = element.querySelectorAll('.button');

// for (var i = 0; i < buttonElements.length; i += 1) {
//   buttonElements[i].innerHTML = 'hide';
// }


/*function solve() {
    return function (selector) {

        var root,
            elements,
            targetButton,
            content,
            next,
            len, i;

        if (typeof selector !== 'string' && !(selector instanceof HTMLElement)) {
            throw Error();
        }
        root = document.getElementById(selector);

        if (root === null) {
            throw Error();
        }
        elements = root.childNodes;
        len = elements.length;

        for (i = 0; i < len; i += 1) {

            if (elements[i].className === 'button') {
                elements[i].innerHTML = 'hide';
            }
        }

        root.addEventListener('click', function (ev) {

            targetButton = ev.target;
            next = targetButton.nextElementSibling;

            // If something different from a button is clicked
            if (targetButton.className !== 'button') {
                return;
            }

            if (next.className === 'content') {
                content = next;

                // Cycle until next content is with class button
                while (next) {
                    if (next.className === 'button') {

                        if (content.style.display === 'none') {
                            content.style.display = '';
                            targetButton.innerHTML = 'hide';
                        }
                        else {
                            content.style.display = 'none';
                            targetButton.innerHTML = 'show';
                        }
                        break;
                    }
                    next = next.nextElementSibling;
                }
            }

        }, false);
    };
}

module.exports = solve; */