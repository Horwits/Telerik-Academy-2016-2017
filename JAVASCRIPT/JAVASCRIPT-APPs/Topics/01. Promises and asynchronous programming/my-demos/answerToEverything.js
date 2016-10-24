/*(function () {
    let myPromise = new Promise((resolve, reject) => {
        navigator.geolocation.getCurrentPosition((pos)=> {
            resolve(pos);

            //reject(()=> {throw new Error("Invalid pos")});
        })
    });

    function getPos(data) {
        position = {
            lat: data.coords.latitude,
            long: data.coords.longitude
        };

        return position;
    };

    function createMap(data) {
        let $img = $('<img />')
            .attr('src', `http://maps.googleapis.com/maps/api/staticmap?center=${data.lat},${data.long}&zoom=15&size=500x500&sensor=false`)
            .prependTo($('body'));

        return $img;
    };

    function fade(img) {
        setTimeout(()=> {
            img.fadeOut(20000);
        }, 2000);
        setTimeout(()=> {
            img.fadeIn(20000);
        }, 2000);
    };

    myPromise
        .then(getPos)
        .then(createMap)
        .then(fade)

})();*/

(function () {
var ajaxPromise = new Promise((resolve, reject)=>{
    var param;
    resolve(param);
});

var a = false;
    ajaxPromise
        .then((a) => console.log(!a));

})();