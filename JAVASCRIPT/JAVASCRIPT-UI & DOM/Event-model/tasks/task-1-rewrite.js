/* globals $ */


/*Create a function that takes an id or DOM element and:

    If an id is provided, select the element
    Finds all elements with class button or content within the provided element
        Change the content of all .button elements with "hide"
    When a .button is clicked:
        Find the topmost .content element, that is before another .button and:
            If the .content is visible:
                Hide the .content
                Change the content of the .button to "show"
            If the .content is hidden:
                Show the .content
                Change the content of the .button to "hide"
            If there isn't a .content element after the clicked .button and before other .button, do nothing
    Throws if:
        The provided DOM element is non-existant
        The id is either not a string or does not select any DOM element
 */

function solve() {
    return function (selector) {
        if (typeof selector !== 'string' && !(selector instanceof HTMLElement)) {
            throw Error();
        }

        var root = document.getElementById(selector);
        if (root === null) {
            throw new Error();
        }

        var elementsWithClassButton = root.querySelectorAll('.button');
        for (var i = 0; i < elementsWithClassButton.length; i++) {
            elementsWithClassButton[i].innerHTML = 'hide';
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

        // root.addEventListener('click', function (evt) {
        //     var target = evt.target;

        //     if (evt.target.className !== 'button') {
        //         return;
        //     }

        //     if (target.nextElementSibling.nextElementSibling.className === 'content') {
        //         var content = target.nextElementSibling.nextElementSibling;

        //         if (content.style.display === 'none') {
        //             content.style.display = '';
        //             targetButton.innerHTML = 'hide';
        //         }
        //         else {
        //             content.style.display = 'none';
        //             targetButton.innerHTML = 'show';
        //         }
        //     }
        // }, false);
    };
}

module.exports = solve;