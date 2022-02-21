function isEven(num) {
    return num % 2 === 0
}
function isOdd(num) {
    return num % 2 !== 0
}

//after that find out the even/odd numbers from the array and store those numbers in a new array
function filterArray(arr, fnRef) {
    var result = []
    for (var i = 0; i < arr.length; i++) {
        // == to check whether value is same
        // === to check whether data type of the value as well as the value itself are same or not
        // if (arr[i] % 2 === 0) {
        var isTrue = fnRef(arr[i])
        if (isTrue)
            result.push(arr[i])
    }
    return result;
}
//callback mechanism: passing a reference of a function (isEven/isOdd) to another function (filterArray). From that another function (filterAray) this passed function will be called (isEven/isOdd)

//create an array to store 10 values (0->9)
var numbers = [1, 4, 2, 3, 5, 7, 6, 0, 8, 9]
//var output = filterArray(numbers, isOdd);

//inline function
// var output = filterArray(
//     numbers,
//     function (num) {
//         return num > 5
//     }
// )

//arrow function
// var output = filterArray(
//     numbers,
//     (num) => { return num < 5 ? true : false }
// )

var output = filterArray(
    numbers,
    (num) => num < 5
)

//iterate through the new array and display the even numbers in the console
for (var index = 0; index < output.length; index++) {
    console.log(output[index])
}