/**
 * Created by Horwi on 15.8.2016 г..
 */
// selectors $(selector) css
// always returns array

var $ul = $('#my-list');
console.log($ul);
var $firstLi = $($ul.children()[0]);
console.log($firstLi.next());
console.log($firstLi.parent());
console.log($firstLi.siblings());

//obj.parents(selector)

// attr
console.log($ul.attr('id'));

// creating element

var $newDiv = $('<div>');
$newDiv.addClass('new-div');
var $root = $('#root');

// adding append, appendTO, preppend, preppendTO

$root.append($newDiv); // append and prepend -> first select the element to append to and then add the elements

//$('<li><p>Uga-buga</p></li>').prependTo($ul); // prepend is adding at first position

// insertAfter

$('<li><p>insert after</p></li>').prependTo($($ul.children()[3]));

//removing elements

$($newDiv).remove();

// objects

//css, html, text

//events
/*
$ul.children().on('click',onLiClick);

function onLiClick() {
    $(this).css('background-color','red');
}*/

// this means current clicked element

$('.click').on('click',onButtonClick);

function onButtonClick() {
    var $this = $(this);
    console.log($this);
    var $node = $this.next();

   /* if ($node.length === 0) {*/

    /*}*/

    while ($node.length) {
        $node.toggleClass('hide');
        $node = $node.next();
    }
}

console.log($ul.parent());
console.log($ul.parents('body'));