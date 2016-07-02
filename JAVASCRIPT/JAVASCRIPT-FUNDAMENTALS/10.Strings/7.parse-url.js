function solve(params) {
    'use strict';
    var indexOfProtocol = params[0].indexOf('://'),
        protocol = params[0].substr(0, indexOfProtocol),
        indexOfServer = params[0].indexOf('/', indexOfProtocol + 3),
        server = params[0].substr(indexOfProtocol + 3, indexOfServer - (indexOfProtocol + 3)),
        resource = params[0].substr(indexOfServer);

    console.log('protocol: ' + protocol);
    console.log('server: ' + server);
    console.log('resource: ' + resource);
}

var test = ['http://telerikacademy.com/Courses/Courses/Details/239'];

solve(test);