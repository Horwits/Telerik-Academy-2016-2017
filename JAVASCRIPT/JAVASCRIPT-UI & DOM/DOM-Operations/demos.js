let menuLis = document.getElementsByClassName('menu-items');
console.log(menuLis);

let lisLength = menuLis.length;
for (let i = 0; i < lisLength; i += 1) {
    menuLis[i].style.backgroundColor = 'red';
}

let main = document.getElementById('wrapper');
main.innerHTML += `<p>The id of main is ${main.id}</p>`;

// itterate over dom elements with recursion
function printElements(element) {
    console.log(element);

    let elLen = element.childNodes.length;
    for ( let i = 0; i < elLen; i+=1) {
        printElements(element.childNodes[i]);
    }
}

printElements(main);
console.log('\n\r');

let header = document.getElementsByTagName('header')[0];
console.log('HEADER.NEXTSIBLING.NEXTSIBLING (IT WILL COUNT THE WHITESPACES AS WELL)');
console.log(header.nextSibling.nextSibling);

console.log('HEADER.NEXTELEMENTSIBLING');
console.log(header.nextElementSibling);

console.log('\n');
console.log('DOM MANIPULATIONS -> ADD, REMOVE, ALTERED');

function addElement() {
    let newEl = document.createElement('p');
    newEl.innerHTML = 'New p element.';
    main.appendChild(newEl);
}

for ( let i = 0; i < 4; i+=1) {
    addElement();
}
