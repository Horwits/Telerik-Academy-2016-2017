'use strict';
function solve(args) {
    let selectors = {
        name: '',
        props: []
    };
    let isInSelector = false;
    for (let i = 0; i < args.length; i += 1) {
        let currLine = args[i].trim();
        if (currLine.indexOf('{') > 0) {
            selectors.name = currLine.split(/\s+/g)[0];
        } else if (currLine.indexOf('}') < 0) {
            var keyValue = currLine.trim().split(':');
            selectors.props.push({ key: keyValue[0], value: keyValue[1] });
        }
    }
    console.log(selectors);
}


var test = [
    '    muppet {',
    '        property : prop;',
    '        prop: dsadas;',
    '    }',

    '    muppet {',
    '        property : element;',
    '    }',
];

solve(test);