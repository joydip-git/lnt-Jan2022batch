//function declaration
function add(a: number, b: number): number {
    return (a + b)
}

//function expression (inline function)
var subtract = function (a: number, b: number): number {
    return a - b
}

//arrow function with function expression with function body { }
var multiply = (a: number, b: number): number => {
    return a * b
}

//arrow function with function expression in single line
var divide = (a: number, b: number): number => a / b

//defining a function type 
//(arg1:data-type, arg2: data-type,...,argN:data-type) => return type
//created my own data type for the function
type calculateFnType = (m: number, n: number) => number

function calculate(fnRef: calculateFnType, x: number, y: number): void {
    var res = fnRef(x, y)
    console.log(res)
}

calculate(add, 10, 2)
calculate(subtract, 10, 2)
calculate(multiply, 10, 2)
calculate(divide, 10, 2)

//var testFn = (a: number, b: number, c: number) => a + b + c
//calculate(testFn, 10, 2)