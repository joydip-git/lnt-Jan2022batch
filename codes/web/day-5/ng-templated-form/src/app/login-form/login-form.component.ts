import { Component } from "@angular/core";
// import { FormControl, NgForm, NgModel } from "@angular/forms";
import { User } from "../models/user";

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
    // submitData(frm: NgForm) {
    //     /**
    //      * frm.form.value =>
    //      * {
    //      *  username:'',
    //      *  password:''
    //      * }
    //      */
    //     console.log(frm.form.value)
    // }
    // submitData(frmData: any) {
    //     console.log(frmData)
    // }

    userInfo: User = {
        username: '',
        password: ''
    }

    submitData(frm: any) {
        console.log(frm)
        console.log(this.userInfo)
    }
}