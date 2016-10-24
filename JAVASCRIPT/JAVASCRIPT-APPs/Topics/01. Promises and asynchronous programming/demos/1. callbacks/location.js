(function () {
    const showMap = (function () {
        let root = document.getElementById('root');

        const createImgMap = (function () {
            return {
                parsePosition(position) {
                    return {
                        lat: position.coords.latitude,
                        lon: position.coords.longitude
                    };
                },
                createStaticImageMap(coords) {
                    let img = document.createElement('img'),
                        src = `http://maps.googleapis.com/maps/api/staticmap?center=${coords.lat},${coords.lon}&zoom=15&size=500x500&sensor=false`;

                    img.setAttribute('src', src);
                    img.setAttribute('id','map');

                    root.appendChild(img);
                }
            };
        })();

        const mapPromise = new Promise(function (resolve, reject) {
            if (navigator.geolocation) {
                navigator.geolocation.getCurrentPosition(resolve);
            } else {
                reject();
                /*let img = document.getElementById('map');
                root.removeChild(img);
                root.innerHTML = 'Invalid parameters';*/
            }
        });

        mapPromise
            .then(createImgMap.parsePosition)
            .then(createImgMap.createStaticImageMap);

        return mapPromise;
    });

    showMap();
}());
