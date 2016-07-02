function solve(params) {
    var allWheels = +params[0];
    var truckWheels = 10;
    var carWheels = 4;
    var trikeWheels = 3;

    var allCombinations = 0;
    var currentCombinations = 0;
    for (var i = 0; i <= (allWheels / carWheels) + 1; i += 1) {
        for (var j = 0; j <= (allWheels / truckWheels) + 1; j += 1) {
            for (var k = 0; k <= (allWheels / trikeWheels) + 1; k += 1) {
                currentCombinations = (i * carWheels) + (j * truckWheels) + (k * trikeWheels);
                if (currentCombinations === allWheels) {
                    allCombinations += 1;
                }
            }
        }
    }
    // var countCars = 0,
    //     countTrikes = 0,
    //     countTrucks = 0,
    //     sum = 0;
    // while (allWheels >= sum) {
    //     sum += truckWheels;
    //     countTrucks += 1;
    //     while (allWheels >= sum) {
    //         sum += carWheels;
    //         countCars += 1;
    //         while (allWheels >= sum) {
    //             sum += trikeWheels;
    //             countTrikes += 1;
    //         }
    //     }
    // }

    //allCombinations = countCars + countTrikes + countTrucks;
    console.log(allCombinations);
}


solve([40]);

solve([10]);

// + 3 + 3 /  + 3 + 4  + 3 + 10