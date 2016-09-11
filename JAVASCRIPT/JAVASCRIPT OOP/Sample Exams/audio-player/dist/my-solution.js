'use strict';

var _get = function get(object, property, receiver) { if (object === null) object = Function.prototype; var desc = Object.getOwnPropertyDescriptor(object, property); if (desc === undefined) { var parent = Object.getPrototypeOf(object); if (parent === null) { return undefined; } else { return get(parent, property, receiver); } } else if ("value" in desc) { return desc.value; } else { var getter = desc.get; if (getter === undefined) { return undefined; } return getter.call(receiver); } };

var _createClass = function () { function defineProperties(target, props) { for (var i = 0; i < props.length; i++) { var descriptor = props[i]; descriptor.enumerable = descriptor.enumerable || false; descriptor.configurable = true; if ("value" in descriptor) descriptor.writable = true; Object.defineProperty(target, descriptor.key, descriptor); } } return function (Constructor, protoProps, staticProps) { if (protoProps) defineProperties(Constructor.prototype, protoProps); if (staticProps) defineProperties(Constructor, staticProps); return Constructor; }; }();

function _possibleConstructorReturn(self, call) { if (!self) { throw new ReferenceError("this hasn't been initialised - super() hasn't been called"); } return call && (typeof call === "object" || typeof call === "function") ? call : self; }

function _inherits(subClass, superClass) { if (typeof superClass !== "function" && superClass !== null) { throw new TypeError("Super expression must either be null or a function, not " + typeof superClass); } subClass.prototype = Object.create(superClass && superClass.prototype, { constructor: { value: subClass, enumerable: false, writable: true, configurable: true } }); if (superClass) Object.setPrototypeOf ? Object.setPrototypeOf(subClass, superClass) : subClass.__proto__ = superClass; }

function _classCallCheck(instance, Constructor) { if (!(instance instanceof Constructor)) { throw new TypeError("Cannot call a class as a function"); } }

function solve() {
    var _idNum = 0,
        _generateID = function _generateID() {
        _idNum += 1;
        return _idNum;
    };

    var _Validations = {
        validateInt: function validateInt(int) {
            if (typeof int !== 'number' && int <= 0) {
                throw "Invalid Number";
            }
        },
        validateString: function validateString(str) {
            if (typeof str !== 'string' && str.length < 3 && str.length > 25) {
                throw "Invalid string.";
            }
        },
        validateImdbRating: function validateImdbRating(val) {
            if (typeof val !== 'number' && val < 1 && val > 5) {
                throw "Invalid Number";
            }
        }
    };

    var Player = function () {
        function Player(name) {
            _classCallCheck(this, Player);

            this.id = _generateID();
            this.name = name;
            this.playlists = [];
        }

        _createClass(Player, [{
            key: 'addPlaylist',
            value: function addPlaylist(playlistToAdd) {
                this.playlists.push(playlistToAdd);
                return this;
            }
        }, {
            key: 'getPlaylistById',
            value: function getPlaylistById(id) {
                return this.playlists.filter(function (x) {
                    return x.id === id;
                })[0] || null;
            }
        }, {
            key: 'removePlaylist',
            value: function removePlaylist(id) {
                var counter = 0,
                    isFound = false;
                var _iteratorNormalCompletion = true;
                var _didIteratorError = false;
                var _iteratorError = undefined;

                try {
                    for (var _iterator = this.playlists[Symbol.iterator](), _step; !(_iteratorNormalCompletion = (_step = _iterator.next()).done); _iteratorNormalCompletion = true) {
                        var obj = _step.value;

                        if (obj.id === id) {
                            this.playlists.splice(counter, 1);
                            isFound = true;
                            break;
                        }
                        counter += 1;
                    }
                } catch (err) {
                    _didIteratorError = true;
                    _iteratorError = err;
                } finally {
                    try {
                        if (!_iteratorNormalCompletion && _iterator.return) {
                            _iterator.return();
                        }
                    } finally {
                        if (_didIteratorError) {
                            throw _iteratorError;
                        }
                    }
                }

                if (!isFound) {
                    throw new Error('Remove playlist by id.');
                }
                return this;
            }

            /*removePlaylist(playlist) {
             /!*let isFound = false;
             for (let index in this.playlists) {
             if (this.playlists[index] === playlist) {
             isFound = true;
             this.playlists.splice(index, 1);
             break;
             }
             }*!/
               let index = this.playlists.indexOf(playlist);
               let isFound = index > 0;
             if (!isFound) {
             throw new Error("Playlist");
             }
               this.playlists.splice(index, 1);
             return this;
             }*/

        }, {
            key: 'listPlaylists',
            value: function listPlaylists(page, size) {
                // TODO: implement
            }
        }, {
            key: 'contains',
            value: function contains(playable, playlist) {
                // TODO: implement
            }
        }, {
            key: 'name',
            get: function get() {
                return this._name;
            },
            set: function set(value) {
                _Validations.validateString(value);
                this._name = value;
            }
        }]);

        return Player;
    }();
    // end of player

    var PlayList = function () {
        function PlayList(name) {
            _classCallCheck(this, PlayList);

            this.id = _generateID();
            this.name = name;
            this.playables = [];
        }

        _createClass(PlayList, [{
            key: 'addPlayable',
            value: function addPlayable(playable) {
                this.playables.push(playable);
                return this;
            }
        }, {
            key: 'getPlayableById',
            value: function getPlayableById(id) {
                return this.playables.filter(function (x) {
                    return x.id === id;
                })[0] || null;
            }
        }, {
            key: 'removePlayable',
            value: function removePlayable(id) {
                var counter = 0,
                    isFound = false;
                var _iteratorNormalCompletion2 = true;
                var _didIteratorError2 = false;
                var _iteratorError2 = undefined;

                try {
                    for (var _iterator2 = this.playables[Symbol.iterator](), _step2; !(_iteratorNormalCompletion2 = (_step2 = _iterator2.next()).done); _iteratorNormalCompletion2 = true) {
                        var obj = _step2.value;

                        if (obj === id || obj.id === id) {
                            this.playables.splice(counter, 1);
                            isFound = true;
                            break;
                        }
                        counter += 1;
                    }
                } catch (err) {
                    _didIteratorError2 = true;
                    _iteratorError2 = err;
                } finally {
                    try {
                        if (!_iteratorNormalCompletion2 && _iterator2.return) {
                            _iterator2.return();
                        }
                    } finally {
                        if (_didIteratorError2) {
                            throw _iteratorError2;
                        }
                    }
                }

                if (!isFound) {
                    throw new Error('Remove playable by id.');
                }
            }

            /*removePlayable(playable) {
                return this.playables.filter(x => x == playable);
            }*/

        }, {
            key: 'listPlayables',
            value: function listPlayables(page, size) {
                if (page < 0) {
                    throw Error();
                }
                if (size <= 0) {
                    throw Error();
                }
                if (page * size > this.playables.length) {
                    throw Error();
                }

                return this.playables.slice(0).sort(function (a, b) {
                    if (a.name < b.name) {
                        return -1;
                    }
                    if (a.name > b.name) {
                        return 1;
                    }
                    return a.id - b.id;
                }).filter(function (item, index) {
                    return index >= page * size && index < (page + 1) * size;
                });
            }
        }, {
            key: 'name',
            get: function get() {
                return this._name;
            },
            set: function set(value) {
                _Validations.validateString(value);
                this._name = value;
            }
        }]);

        return PlayList;
    }();
    // end of playlist

    var Playable = function () {
        function Playable(title, author) {
            _classCallCheck(this, Playable);

            this.id = _generateID();
            this.title = title;
            this.author = author;
        }

        _createClass(Playable, [{
            key: 'play',
            value: function play() {
                return '[' + this.id + ']. [' + this.title + '] - [' + this.author + ']';
            }
        }, {
            key: 'title',
            get: function get() {
                return this._title;
            },
            set: function set(title) {
                _Validations.validateString(title);
                this._title = title;
            }
        }, {
            key: 'author',
            get: function get() {
                return this._author;
            },
            set: function set(author) {
                _Validations.validateString(author);
                this._author = author;
            }
        }]);

        return Playable;
    }();
    // end of playable

    var Audio = function (_Playable) {
        _inherits(Audio, _Playable);

        function Audio(title, author, length) {
            _classCallCheck(this, Audio);

            var _this = _possibleConstructorReturn(this, (Audio.__proto__ || Object.getPrototypeOf(Audio)).call(this, title, author));

            _this.length = length;
            return _this;
        }

        _createClass(Audio, [{
            key: 'play',
            value: function play() {
                return _get(Audio.prototype.__proto__ || Object.getPrototypeOf(Audio.prototype), 'play', this).call(this) + ('- [' + this.length + ']');
            }
        }, {
            key: 'length',
            get: function get() {
                return this._length;
            },
            set: function set(value) {
                _Validations.validateInt(value);
                this._length = value;
            }
        }]);

        return Audio;
    }(Playable);
    // end of Audio

    var Video = function (_Playable2) {
        _inherits(Video, _Playable2);

        function Video(title, author, imdbRating) {
            _classCallCheck(this, Video);

            var _this2 = _possibleConstructorReturn(this, (Video.__proto__ || Object.getPrototypeOf(Video)).call(this, title, author));

            _this2.imdbRating = imdbRating;
            return _this2;
        }

        _createClass(Video, [{
            key: 'play',
            value: function play() {
                return _get(Video.prototype.__proto__ || Object.getPrototypeOf(Video.prototype), 'play', this).call(this) + ('- [' + this.imdbRating + ']');
            }
        }, {
            key: 'imdbRating',
            get: function get() {
                return this._imdbRating;
            },
            set: function set(value) {
                _Validations.validateImdbRating(value);
                this._imdbRating = value;
            }
        }]);

        return Video;
    }(Playable);
    //end of Video

    // revealing pattern


    function getPlayer(name) {
        return new Player(name);
    }

    function getPlaylist(name) {
        //returns a new playlist instance with the provided name
        return new PlayList(name);
    }

    function getAudio(title, author, length) {
        //returns a new audio instance with the provided title, author and length
        return new Audio(title, author, length);
    }

    function getVideo(title, author, imdbRating) {
        //returns a new video instance with the provided title, author and imdbRating
        return new Video(title, author, imdbRating);
    }

    return {
        getPlayer: getPlayer,
        getPlaylist: getPlaylist,
        getAudio: getAudio,
        getVideo: getVideo
    };
}

var result = solve();

var i, name, playlist;
name = 'Hard Rock';
playlist = result.getPlaylist(name);

for (i = 0; i < 35; i += 1) {
    playlist.addPlayable({ id: i + 1, name: 'Rock' + (9 - i % 10) });
}

console.log(playlist.listPlayables(2, 10).length);
console.log(playlist.listPlayables(3, 10).length);

//playlist.listPlayables(-1, 10)
//playlist.listPlayables(5, 10)
//playlist.listPlayables(1, -1)

module.exports = solve;