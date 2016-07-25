let currentP = document.getElementById('par');

console.log(currentP instanceof HTMLParagraphElement);

// returns a collection
currentP = document.getElementsByTagName('p')[0];

// HTMLParagraphElement is an 'tamplate' object. Every P tag is instalce of it.
console.log(currentP instanceof HTMLParagraphElement);

currentP.innerHTML += '<p>Added new inner element with currentP.innerHTML+=. Not a good practice.</p>';

currentA = document.getElementsByTagName('a')[0];

console.log(currentA.href);

console.log('innerHTML'.toUpperCase());
let wrapper = document.getElementById('wrapper');
console.log(wrapper.children[0].innerHTML);

console.log('TEXT-CONTENT' + '.trim()');
console.log(wrapper.children[0].textContent);

console.log('ALL DIVS ARRAY OUTERHTML');
let divArray = document.getElementsByTagName('div');
for (let i = 0; i < divArray.length; i += 1) {
    console.log(divArray[i].outerHTML.trim());
}

console.log('GET ELEMENTS BY NAME');
let formElements = document.getElementsByName('first-and-last-name');
console.log(formElements[0]);

console.log('QUERY SELECTOR');
let querySel = document.querySelector('#par');
console.log(querySel);

console.log(document.querySelector('div > div'));

console.log('QUERY SELECTOR ALL');
let allDivs = document.querySelectorAll('div > div');
console.log(allDivs);

// predefine document collections like document.forms -> returns all forms at this document

// NODE LISTS
console.log('NODE LISTS');
//how to call functions for arrays on node lists
[].forEach.call(allDivs, el => console.log(el));

console.log('GET ELEMENTS ... RETURNS LIVE NODE LIST -> EVERY CHANGE WILL BE KNOWN');
console.log('QUERY SELECTORALL ... RETURNS STATIC NODE LIST -> RETURNS A STATIC LIST WITCH HAS NO INFO ABOUT ANY CHANGE MADE.');