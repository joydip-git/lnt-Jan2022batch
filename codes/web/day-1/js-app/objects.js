//1. object (object-literal syntax)
var anilObj = {
    //value properties
    name: 'Anil',
    id: 1,
    salary: 1000,
    //functional property
    print: function () {
        return `name:${this.name}, id:${this.id}, salary:${this.salary}`
    }
}
console.log(anilObj.print())
console.log(typeof anilObj)

var sunilObj = {
    //value properties
    name: 'Sunil',
    id: 2,
    salary: 2000,
    //functional property
    print: function () {
        return `name:${this.name}, id:${this.id}, salary:${this.salary}`
    }
}
console.log(sunilObj.print())

//2. object (constructor function)
function person(pname, pid, psalary) {
    this.id = pid
    this.name = pname
    this.salary = psalary

    this.print = function () {
        return `name:${this.name}, id:${this.id}, salary:${this.salary}`
    }
}

var joydipObj = new person('joydip', 3, 3000)
var priyaObj = new person('Priya', 4, 4000)

console.log(joydipObj.print())
console.log(priyaObj.print())

//3. object (using class, constructor keywords syntax)
class Person {
    constructor(pid, pname, psalary) {
        this.id = pid
        this.name = pname
        this.salary = psalary
    }
    print() {
        return `name:${this.name}, id:${this.id}, salary:${this.salary}`
    }
}

var vinodPerson = new Person(5, 'Vinod', 5000)

//accessing the properties of the object using dot operator (.)
console.log(vinodPerson.name)

//in JS object is like a collection of properties and their values
//you can access the property from an object, like you access a value from an array using indexer ([])
console.log(vinodPerson["salary"])

//accessing functional property
console.log(vinodPerson.print())

//in JS object is like a collection of properties and their values
// you can access all properties and their values from JS object using for..in loop
//in JS an object is like an array of properties

for (var propName in vinodPerson) {
    var propValue = vinodPerson[propName]
    console.log(`${propName}:${propValue}`)
}