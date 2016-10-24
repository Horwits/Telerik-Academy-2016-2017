/*function pause(delay) {
 setTimeout(function () {
 console.log(`paused for ${delay} ms.`);
 }, delay);
 }

 /!*console.log('start');
 pause(200);
 console.log('middle');
 pause(2000);
 console.log('end');*!/

 (function () {
 function dropBomb() {
 console.log('booom');
 }

 return dropBomb() + 'inner callback';
 }());

 // pyramid of doom
 (function () {
 function pause(delay, callback) {
 setTimeout(function () {
 console.log(`paused for ${delay} ms.`);
 callback();
 }, delay);
 }

 console.log('start');
 pause(2000,function () {
 console.log('middle');
 pause(2000, function () {
 console.log('end');
 });
 });
 }());*/

(function () {
    let currentLocation = navigator.geolocation.getCurrentPosition(function success(location) {
        /* let loc = {
         long: location.coords.longitude,
         lat: location.coords.latitude
         };

         return loc;*/

        let img = document.createElement("img");
        let src = `http://maps.googleapis.com/maps/api/staticmap?center=${location.coords.latitude},${location.coords.longitude}&zoom=13&size=500x500&sensor=false`;
        //let map = new google.maps.Map(document.getElementById('map'), mapOptions);

        img.setAttribute('src', src);
        let map = document.getElementById('map');
        map.appendChild(img);
    });


}());
