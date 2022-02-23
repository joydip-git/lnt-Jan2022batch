var people = [
    new Person(1, 'joydip', 1000),
    new Person(2, 'Anil', 2000),
    new Person(3, 'sunil', 3000)
];
function loadData() {
    var tablebody = document.getElementById('tblBody');
    var _loop_1 = function (index) {
        var p = people[index];
        var newRow = document.createElement('tr');
        var idTd = document.createElement('td');
        idTd.innerText = p.Id.toString();
        idTd.addEventListener('click', function () {
            document.getElementById('spanName').innerText = p.Name;
        });
        var nameTd = document.createElement('td');
        nameTd.innerText = p.Name;
        newRow.appendChild(idTd);
        newRow.appendChild(nameTd);
        tablebody.appendChild(newRow);
    };
    //let is for locally scoped variable
    for (var index = 0; index < people.length; index++) {
        _loop_1(index);
    }
}
