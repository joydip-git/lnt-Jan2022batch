import { Component } from "@angular/core";
import { FormControl, NgModel } from "@angular/forms";

@Component({
    selector: 'app-login-form',
    templateUrl: './login-form.component.html',
    styleUrls: ['./login-form.component.css']
})
export class LoginFormComponent {
    // submitData(unamectrl: NgModel, pwdctrl: NgModel) {
    //     // console.log(unamectrl)
    //     // console.log(pwdctrl)
    //     console.log(unamectrl.control.value)
    //     console.log(pwdctrl.control.value)
    // }
    submitData(uname: string, pwd: string) {
        console.log(uname, pwd)
    }
}