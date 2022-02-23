//function declaration
function add(a, b) {
    return (a + b);
}
//function expression (inline function)
var subtract = function (a, b) {
    return a - b;
};
//arrow function with function expression with function body { }
var multiply = function (a, b) {
    return a * b;
};
//arrow function with function expression in single line
var divide = function (a, b) { return a / b; };
function calculate(fnRef, x, y) {
    var res = fnRef(x, y);
    console.log(res);
}
calculate(add, 10, 2);
calculate(subtract, 10, 2);
calculate(multiply, 10, 2);
calculate(divide, 10, 2);
//var testFn = (a: number, b: number, c: number) => a + b + c
//calculate(testFn, 10, 2)
