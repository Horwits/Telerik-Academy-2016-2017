function solve() {
    const getId = (function () {
        let id = 0;

        return function () {
            id += 1;
            return id;
        }
    }());

    class Item {
        constructor(name, description) {
            this.id = getId();
            this.description = description;
            this.name = name;
        }

        get description() {
            return this._description;
        }

        set description(x) {
            if (typeof x !== 'string') {
                throw new Error('Invalid name type.')
            }

            /*if (x.length <= 0) {
             throw new Error('Invalid description length.');
             }*/

            if (x === '') {
                throw 'Description should not be empty';
            }

            this._description = x;
        }

        get name() {
            return this._name;
        }

        set name(x) {

            if (typeof x !== 'string') {
                throw new Error('Invalid name type.')
            }

            if (x === '') {
                throw new Error('Invalid name value.')
            }

            if (x.length < 2 || x.length > 40) {
                throw new Error('Invalid name length.');
            }

            this._name = x;
        }
    }

    class Book extends Item {
        constructor(name, isbn, genre, description) {
            super(name, description);
            this.isbn = isbn;
            this.genre = genre;
        }

        get isbn() {
            return this._isbn;
        }

        set isbn(x) {
            if (typeof x !== 'string') {
                throw new Error('Invalid isbn type.')
            }

            let isNumber = /^\d+$/.test(x);

            if (!isNumber) {
                throw new Error('Invalid isbn format.');
            }

            if (x.length !== 10 && x.length !== 13) {
                throw new Error('Invalid isbn length.');
            }

            this._isbn = x;
        }

        get genre() {
            return this._genre;
        }

        set genre(x) {
            if (x === '') {
                throw new Error('Invalid genre value.')
            }

            if (x.length < 2 || x.length > 20) {
                throw new Error('Invalid genre length.');
            }

            this._genre = x;
        }
    }

    class Media extends Item {
        constructor(name, rating, duration, description) {
            super(name, description);
            this.rating = rating;
            this.duration = duration;
        }

        get duration() {
            return this._duration;
        }

        set duration(x) {
            if (typeof x !== 'number' && x <= 0) {
                throw new Error('Invalid duration.');
            }

            if (!x) {
                throw new Error('Invalid duration value.');
            }

            this._duration = x;
        }

        get rating() {
            return this._rating;
        }

        set rating(x) {
            if (typeof x !== 'number') {
                throw new Error('Invalid rating type.');
            }

            if (x < 1 || x > 5) {
                throw new Error('Invalid rating value.');
            }

            if (!x) {
                throw new Error('Invalid rating value.');
            }

            this._rating = x;
        }
    }

    class Catalog {
        constructor(name) {
            this.id = getId();
            this.name = name;
            this.items = [];
        }

        get name() {
            return this._name;
        }

        set name(x) {

            if (typeof x !== 'string') {
                throw new Error('Invalid name type.')
            }

            if (x === '') {
                throw new Error('Invalid name value.')
            }

            if (x.length < 2 || x.length > 40) {
                throw new Error('Invalid name length.');
            }

            this._name = x;
        }

        /*add(items){
         if(!Array.isArray(items)) {
         throw "";
         }

         if (items.length === 0) {
         throw new Error('No items are passed.')
         }

         let anyIsItem = items.filter(x=> x instanceof 'Item');
         if (!anyIsItem) {
         throw new Error('Invalid items type.')
         }

         for(let i of items){
         this.items.push(i);
         }

         return this;
         }*/

        add(...items) {
            if (Array.isArray(items[0])) {
                items = items[0];
            }

            /*if (items.filter(x=> x.constructor.name !== 'Item')) {
             throw new Error('Invalid items type.')
             }*/

            /* if (items.length < 0) {
             throw 'No items are added';
             }*/


            this.items.push(...items);

            return this;
        }

        find(id) {
            if (typeof id !== 'number') {
                throw  new Error('Id is not a number.');
            }

            /*if (!id) {
             throw  new Error('Id is not provided.');
             }*/

            for (let item of this.items) {
                if (item.id === x) {
                    return item;
                }
            }

            return null;
        }

        search(pattern) {
            if (!pattern) {
                throw new Error('Invalid pattern value.');
            }

            for (let item of this.items) {
                if (item.name.indexOf(pattern) !== -1 || item.description.indexOf(pattern) !== -1) {
                    return item;
                }
            }

            return [];
        }
    }

    class BookCatalog extends Catalog {
        constructor(name) {
            super(name);
        }

        add(...books) {
            if (Array.isArray(books[0])) {
                books = books[0];
            }

            if (books.filter(x => x instanceof Book)) {
             throw new Error('Invalid books type.')
             }

            super.add(...books);
            return this;
        }

        getGenres(){
            this.items = this.items.map(x=>x.genre.toLowerCase());
            return this.items;
        }
    }

    class MediaCatalog extends Catalog {
        constructor(name) {
            super(name);
        }

        add(...media) {
            if (Array.isArray(media[0])) {
                media = media[0];
            }

            if (media.filter(x=> x.constructor.name !== 'Media')) {
                throw new Error('Invalid media type.')
            }

            super.add(...media);
            return this;
        }

        getTop(count){

        }

        getSortedByDuration(){

        }
    }


    function getBook(name, isbn, genre, description) {
        // return a book instance
        return new Book(name, isbn, genre, description);
    }

    function getMedia(name, rating, duration, description) {
        // return a media instance
        return new Media(name, rating, duration, description);
    }

    function getBookCatalog(name) {
        // return a book catalog instance
        return new BookCatalog(name);
    }

    function getMediaCatalog(name) {
        // return a media catalog instance
        return new MediaCatalog(name);
    }

    return {
        getBook, getMedia, getBookCatalog, getMediaCatalog
    }
}

module.exports = solve;
