import { Component } from '@angular/core';
import { Person } from 'src/models/person';
import { places, people } from "../repository/records";

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  locations = places
  peopleRecords = people
  // showLocation(loc: string, name: string) {
  //   window.alert(`${name} is from ${loc}`)
  // }
  showLocation(id: number) {
    // for (let i = 0; i < this.peopleRecords.length; i++) {
    //   if (this.peopleRecords[i].id === id) {
    //     window.alert(`${this.peopleRecords[i].name} is from ${this.peopleRecords[i].location}`)
    //     break;
    //   }
    // }
    const foundPerson = this.peopleRecords.find(function (p: Person) {
      return p.id === id
    })
    if (foundPerson)
      window.alert(`${foundPerson.name} is from ${foundPerson.location}
  }
}
