function solve(args) {
  var a = +args[0];
  var b = +args[1];
  var c = +args[2];

  if (a >= b) {
    if (a >= c) {
      console.log(a);
    }
    else {
      console.log(c);
    }
  }
  else {
    if (b >= c) {
      console.log(b);
    }
    else {
      console.log(c);
    }
  }
}

console.log(solve([45, 41, 41]));
console.log(solve([45, 41, 41]));
console.log(solve([45, 41, 41]));
console.log(solve([45, 41, 41]));
console.log(solve([45, 41, 41]));
console.log(solve([-1.1, -0.5, -0.1]));
console.log(solve([1, 1, 1]));
console.log(solve([45, 41, 41]));