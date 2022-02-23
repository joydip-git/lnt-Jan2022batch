var Person = /** @class */ (function () {
    function Person(id, name, salary) {
        this.id = id;
        this.name = name;
        this.salary = salary;
    }
    Object.defineProperty(Person.prototype, "Id", {
        get: function () {
            return this.id;
        },
        set: function (val) {
            this.id = val;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Person.prototype, "Name", {
        get: function () {
            return this.name;
        },
        set: function (val) {
            this.name = val;
        },
        enumerable: false,
        configurable: true
    });
    Object.defineProperty(Person.prototype, "Salary", {
        get: function () {
            return this.salary;
        },
        set: function (val) {
            this.salary = val;
        },
        enumerable: false,
        configurable: true
    });
    return Person;
}());
