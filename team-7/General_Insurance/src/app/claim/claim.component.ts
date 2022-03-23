import { Component, OnInit } from '@angular/core';
import { FormGroup,Validators,FormBuilder} from '@angular/forms'

@Component({
  selector: 'app-claim',
  templateUrl: './claim.component.html',
  styleUrls: ['./claim.component.css']
})
export class ClaimComponent implements OnInit {

  private _claim: FormGroup = this._fb.group(
    {
    policynumber: ['',[Validators.required]],
   
    phnnumber: [ '',  [Validators.required]],
    Category:['',Validators.required]


    }
);
public get claim(): FormGroup {
    return this._claim;
}
public set claim(value: FormGroup) {
    this._claim = value;
}

  constructor(private _fb: FormBuilder) { }

  ngOnInit(): void {
  }

  submitData() {
    console.log(this.claim)
  }
  
}

