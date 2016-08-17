"use strict";

let array = [
    { name: 'Pesho'},
    { name: 'Gosho'},
    { name: 'Ivan'}
];

let testObj = {
    name: 'Avraam'
};

const hbTemplate = document.getElementById('container-template').innerHTML;

let template = Handlebars.compile(hbTemplate);

for (var i = 0; i < array.length; i++) {
    var obj = array[i];
    document.getElementById('container').innerHTML += template(obj); // in template() we pass the object, in the handlebars.compile the string
}

let headings = {
    title: 'Title 1',
    title2: 'Title 1'
};
const ifElseTemplate = document.getElementById('ifelse-template-test').innerHTML;
template = Handlebars.compile(ifElseTemplate);

template(headings);


const iterateCollectionTemplate = document.getElementById('iterateCollection-template-test').innerHTML;
template = Handlebars.compile(iterateCollectionTemplate);

let names = [
    'Dragan', 'Petkan', 'Jivko'
];

document.getElementById('root').innerHTML += template({names : names});

const objCollectionTemplate = document.getElementById('obj-template-test').innerHTML;
template = Handlebars.compile(objCollectionTemplate);

document.getElementById('root').innerHTML += template({array});

//@index

//#each

//@key