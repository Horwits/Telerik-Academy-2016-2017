var alldivs = document.querySelectorAll('div');
var ul = alldivs[0].getElementsByTagName('ul')[0];
var allLiInUL = ul.getElementsByTagName('li');
var p = document.createElement('p');

// for (var i = 0; i < allLiInUL.length; i += 1) {
//     p.innerText += ' ' + allLiInUL[i].innerText;
//     p.style.backgroundColor = 'yellow';
// }

appendAllChilds(p, ul);

alldivs[0].appendChild(p);

function appendAllChilds(rootElement, element) {
    if (element instanceof HTMLElement) {
        rootElement.innerHTML += element;
    }

    for (var index = 0; index < element.childNodes.length; index++) {
        var toPrint = element.childNodes[index];
        appendAllChilds(rootElement, toPrint);
    }
}

var newP = document.createElement('p');
newP.className += "newP";
newP.innerHTML = "<strong>ds</strong>asa";

newP.style.fontSize = "20px";
newP.style.color = "cyan";


alldivs[0].appendChild(newP);

var newLi = document.createElement('li');
newLi.innerHTML = 'NEW LI';

ul.insertBefore(newLi, ul.firstChild);
//ul.appendChild(newLi);

// check removeChild
// ul.removeChild(ul.firstChild);

//cloneNode

// documentFragment
var anchor = document.createElement('a');

var fragment = new DocumentFragment();
var anLi = document.createElement('li');
anLi.style.color = 'red';
anLi.style.listStyle = 'none';
//anLi.appendChild('span');
for (var i = 0; i < 20; i++) {
    var cloneLi = anLi.cloneNode(true);
    cloneLi.innerHTML = i;
    fragment.appendChild(cloneLi);
}

ul.appendChild(fragment);