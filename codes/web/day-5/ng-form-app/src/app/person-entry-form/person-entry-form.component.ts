import { Component } from "@angular/core";
import { FormGroup } from "@angular/forms";
import { Person } from "../models/person";

@Component({
    templateUrl: './person-entry-form.component.html',
    styleUrls: ['./person-entry-form.component.css']
})
export class PersonEntryFormComponent {
    personInfo: Person = {
        id: 0,
        name: '',
        salary: 0
    }
    // submitData(id: string, name: string, salary: string) {
    //     console.log(id, name, salary)
    // }
    // submitData(frm: FormGroup) {
    //     const personData: Person = {
    //         id: Number(frm.value.txtid),
    //         name: frm.value.txtname,
    //         salary: Number(frm.value.txtsalary)
    //     }
    //     console.log(frm.value)
    //     console.log(personData)
    // }
    submitData(frm: FormGroup) {
        console.log(frm)
        console.log(this.personInfo)
    }

}