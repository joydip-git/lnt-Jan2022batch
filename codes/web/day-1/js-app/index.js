//float
var a = 10.34;
console.log(typeof a);

//int
var b = 10
console.log(typeof b)

//boolean
var val = true
console.log(typeof val)

//string
var str = 'joydip'
console.log(typeof str)

//array
var arr = [1, 2, 3, 4];
var numbers = new Array(1, 2, 3, 4);

console.log(typeof arr)
console.log(typeof numbers)

//function
function add(a, b) {
    return (a + b)
}
var result = add(10, 20)
console.log(result)
console.log(typeof add)


var x = 1
var y = 2
if (x > y)
    console.log('x is greater')
else
    console.log('y is greater')

while (y > 0) {
    console.log(y)
    y--;
}

y = 3
do {
    console.log(y)
    y--
} while (y > 0)

switch (x) {
    case 1:
        console.log(x)
        break;

    case 2:
        console.log(x)
        break;

    default:
        break;
}

for (var i = 0; i < 2; i++) {
    //string template
    console.log(`value of i= ${i}`)
    //console.writeline($"value of i={i}")
}

var res = a > b ? a : b
console.log(res)

