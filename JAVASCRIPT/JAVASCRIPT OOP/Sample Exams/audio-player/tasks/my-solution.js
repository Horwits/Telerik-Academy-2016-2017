function solve() {
    let _idNum = 0,
        _generateID = function () {
            _idNum += 1;
            return _idNum;
        };

    const _Validations = {
        validateInt: function (int) {
            if (typeof int !== 'number' && int <= 0) {
                throw "Invalid Number";
            }
        },
        validateString: function (str) {
            if (typeof str !== 'string' && (str.length < 3 && str.length > 25)) {
                throw "Invalid string."
            }
        },
        validateImdbRating: function (val) {
            if (typeof val !== 'number' && val < 1 && val > 5) {
                throw "Invalid Number";
            }
        }
    };

    class Player {
        constructor(name) {
            this.id = _generateID();
            this.name = name;
            this.playlists = [];
        }

        get name() {
            return this._name;
        }

        set name(value) {
            _Validations.validateString(value);
            this._name = value;
        }

        addPlaylist(playlistToAdd) {
            this.playlists.push(playlistToAdd);
            return this;
        }

        getPlaylistById(id) {
            return this.playlists.filter(x=>x.id === id)[0] || null;
        }

        removePlaylist(id) {
            let counter = 0, isFound = false;
            for (let obj of this.playlists) {
                if (obj.id === id) {
                    this.playlists.splice(counter,1);
                    isFound = true;
                    break;
                }
                counter+=1;
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

        listPlaylists(page, size) {
            // TODO: implement
        }

        contains(playable, playlist) {
            // TODO: implement
        }
    }
    // end of player

    class PlayList {
        constructor(name) {
            this.id = _generateID();
            this.name = name;
            this.playables = [];
        }

        get name() {
            return this._name;
        }

        set name(value) {
            _Validations.validateString(value);
            this._name = value;
        }

        addPlayable(playable) {
            this.playables.push(playable);
            return this;
        }

        getPlayableById(id) {
            return this.playables.filter(x=>x.id === id)[0] || null;
        }

        removePlayable(id) {
            let counter = 0, isFound = false;
            for (let obj of this.playables) {
                if (obj === id || obj.id === id) {
                    this.playables.splice(counter, 1);
                    isFound = true;
                    break;
                }
                counter += 1;
            }

            if (!isFound) {
                throw new Error('Remove playable by id.');
            }
        }

        /*removePlayable(playable) {
            return this.playables.filter(x => x == playable);
        }*/

        listPlayables(page, size) {
            if (page < 0) {
                throw Error();
            }
            if (size <= 0) {
                throw Error();
            }
            if (page * size > this.playables.length) {
                throw Error();
            }

            return this.playables
                .slice(0)
                .sort(function (a, b) {
                    if (a.name < b.name) {
                        return -1;
                    }
                    if (a.name > b.name) {
                        return 1;
                    }
                    return a.id - b.id;
                })
                .filter(function (item, index) {
                    return index >= (page * size) && index < ((page + 1) * size);
                });
        }
    }
    // end of playlist

    class Playable {
        constructor(title, author) {
            this.id = _generateID();
            this.title = title;
            this.author = author;
        }

        get title() {
            return this._title;
        }

        set title(title) {
            _Validations.validateString(title);
            this._title = title;
        }

        get author() {
            return this._author;
        }

        set author(author) {
            _Validations.validateString(author);
            this._author = author;
        }

        play() {
            return `[${this.id}]. [${this.title}] - [${this.author}]`;
        }
    }
    // end of playable

    class Audio extends Playable {
        constructor(title, author, length) {
            super(title, author);
            this.length = length;
        }

        get length() {
            return this._length;
        }

        set length(value) {
            _Validations.validateInt(value);
            this._length = value;
        }

        play() {
            return super.play() + `- [${this.length}]`;
        }
    }
    // end of Audio

    class Video extends Playable {
        constructor(title, author, imdbRating) {
            super(title, author);
            this.imdbRating = imdbRating;
        }

        get imdbRating() {
            return this._imdbRating;
        }

        set imdbRating(value) {
            _Validations.validateImdbRating(value);
            this._imdbRating = value;
        }

        play() {
            return super.play() + `- [${this.imdbRating}]`;
        }
    }
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
        getPlayer,
        getPlaylist,
        getAudio,
        getVideo
    }
}

let result = solve();

var i, name, playlist;
name = 'Hard Rock';
playlist = result.getPlaylist(name);

for (i = 0; i < 35; i += 1) {
    playlist.addPlayable({id: (i + 1), name: 'Rock' + (9 - (i % 10))});
}

console.log(playlist.listPlayables(2, 10).length);
console.log(playlist.listPlayables(3, 10).length);

//playlist.listPlayables(-1, 10)
//playlist.listPlayables(5, 10)
//playlist.listPlayables(1, -1)

module.exports = solve;