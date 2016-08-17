// mouse events
// click, hover, mouseup, mousedown, mouseover, mouseout

// keyboard events
//keydown, keyup, keypress

// ui events
// load, abort, select, resize, change

// focus events
// blur, focus, focusin, focusout

// touch events
// touchstart, touchend, touchcancel, touchleave, touchmove

// 3 ways of adding events to DOM

// inline
function inlineOnclickTest() {
    var p = document.createElement('p');
    p.innerText = 'It was clicked';

    document.body.appendChild(p);
}

// with properties of the current element
var div = document.createElement('div');
div.style.backgroundColor = 'cyan';
var text = 'test';
div.innerHTML += text;
div.onmouseover = function () {
    div.style.backgroundColor = 'yellow';
    div.innerText = 'Changed';
};

document.body.appendChild(div);

// the best way of doing It
// domElement.addEventListener(eventTypeAsString, eventHandler, isCaptureEvent);
var copiedDiv = div.cloneNode(true);
copiedDiv.addEventListener('click', function () {
    copiedDiv.style.color = 'white';
    copiedDiv.style.fontWeight = 'bold';
    copiedDiv.style.fontFamily = 'sans-serif';
    copiedDiv.innerHTML += '<p>WithAddEventListener</p>';
}, false);

document.body.appendChild(copiedDiv);

// every addEventListener gives you an event object
// every event object has its own properties

var anotherP = document.createElement('p');
copiedDiv.appendChild(anotherP);

copiedDiv.addEventListener('mouseover', mouseOver, true);

// older internet explorer browsers 10 -> down doesn't have ev . It is called window.event
function mouseOver(ev) {
    if (!!!ev) {
        ev = window.event;
    }

    //console.log(ev.target);
    ev.target.innerText = 'Target onmouseover innerText';
}

// all events are fired from the target till the parent or from parent to children
//bubbling and capturing

//false -> bubbling

// true -> capturing

// THE MAIN PURPOUSE OF bubbling AND capturing IS IF WE WANT TO ADD ONE EVENT TO MANY ELEMENTS

// custom events

var button = document.getElementById('button');
console.log(button);

var counter = 0;

var trippleClickEvent = new CustomEvent('tripleClick');
button.addEventListener('click', function () {
    counter += 1;
    if (counter === 3) {
        button.dispatchEvent(trippleClickEvent);
        counter = 0;
    }
}, false);

button.addEventListener('tripleClick', function () {
    var anP = document.createElement('p');
    anP.innerText = 'You\'ve clicked 3 times.';
    document.body.appendChild(anP);
}, false);
