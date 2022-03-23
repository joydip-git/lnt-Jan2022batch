import { Component, OnInit } from '@angular/core';
import { FormGroup,Validators,FormBuilder} from '@angular/forms'

@Component({
  selector: 'app-renew',
  templateUrl: './renew.component.html',
  styleUrls: ['./renew.component.css']
})
export class RenewComponent implements OnInit {

  private _renew: FormGroup = this._fb.group(
    {
    policynumber: ['',[Validators.required]],
    username: [ '', [Validators.required, Validators.email]],  
      
    phnnumber: [ '',  [Validators.required]]
    
    }
);
public get renew(): FormGroup {
    return this._renew;
}
public set renew(value: FormGroup) {
    this._renew = value;
}

  constructor(private _fb: FormBuilder) { }

  ngOnInit(): void {
  }

  submitData() {
    console.log(this.renew)
  }
}
