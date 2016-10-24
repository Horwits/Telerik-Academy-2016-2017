/**
 * Created by Horwi on 26.9.2016 г..
 */
// create the map
(function getMapCoords() {
    navigator.geolocation.getCurrentPosition(createImgMap, error);
})();
// add an img tag and src
function createImgMap(pos) {
    let $map = $('<img />'),
        coordinates = pos.coords;

    if (!coordinates) {
        coordinates = {
            longitude: '20.9943011',
            latitude: '42.6376122'
        };
    }

    $map.attr('src', `http://maps.googleapis.com/maps/api/staticmap?center=${coordinates.latitude},${coordinates.longitude}&zoom=15&size=500x500&sensor=false`);
    $('body').prepend($map);
}

// print decent error in p tag
function error() {
    const message = 'Access denied or invalid coordinates',
        $errorMessageParagraph = $(`<p>${message}</p>`);

    $('body').prepend($errorMessageParagraph);
}