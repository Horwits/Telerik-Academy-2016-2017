/**
 * Created by Horwi on 18.8.2016 г..
 */
"use strict";

var closureTest = (function () {
    function printX (x) {
        //var x = x;
        console.log(x);
    }

    function printY(y) {
        //var y = y;
      console.log(y);
    }

    return {
        printX: printX,
        printY: printY
    }
})();

closureTest.printX('Test');
closureTest.printY('TestY');