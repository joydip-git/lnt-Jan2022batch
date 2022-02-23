function loadData() {
    const tablebody = document.getElementById('tblBody')
    //let is for locally scoped variable
    for (let index = 0; index < people.length; index++) {
        const p = people[index];

        const newRow = document.createElement('tr')

        const idTd = document.createElement('td')
        idTd.innerText = p.Id.toString()
        idTd.addEventListener('click', () => {
            document.getElementById('spanName').innerText = p.Name
        })

        const nameTd = document.createElement('td')
        nameTd.innerText = p.Name

        newRow.appendChild(idTd)
        newRow.appendChild(nameTd)

        tablebody.appendChild(newRow)
    }
}
