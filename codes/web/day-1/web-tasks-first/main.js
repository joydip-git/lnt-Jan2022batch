var numbers = [1, 4, 2, 3, 5, 7, 6, 0, 8, 9]

/*
function isEven(num) {
    return num % 2 === 0
}
var evenNumbers = numbers.filter(isEven)

function printValue(num) {
    console.log(num)
}
evenNumbers.forEach(printValue)
*/
// var evenNumbers = numbers.filter((num) => num % 2 === 0)
// evenNumbers.forEach((num) => console.log(num))

numbers
    .filter(num => num % 2 === 0)
    .forEach(num => console.log(num))
