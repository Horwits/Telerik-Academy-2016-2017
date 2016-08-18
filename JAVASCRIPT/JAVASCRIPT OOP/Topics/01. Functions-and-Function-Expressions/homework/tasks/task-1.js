/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum() {
	var args = arguments[0];

	if (arguments[0].length === 0) {
		return null;
	}

	if (args === undefined) {
		throw new Error();
	}

	var sum = 0;
	for (var i = 0; i < args.length; i++) {
		var el = +args[i];

		if (isNaN(el)) {
			throw new Error();
		}

		sum += el;
	}

	return sum;
}

module.exports = sum;