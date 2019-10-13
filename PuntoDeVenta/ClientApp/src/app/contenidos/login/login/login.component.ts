import { Component, OnInit } from '@angular/core';
import { IUserInfo } from '../../../account/user-info';
import { FormGroup, FormBuilder } from '@angular/forms';
import { AccountService } from '../../../account/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

    constructor(private fb: FormBuilder,
        private accountService: AccountService,
        private router: Router) { }

    formGroup: FormGroup;

    ngOnInit() {
        this.formGroup = this.fb.group({
            email: '',
            password: '',
        });
    }

    loguearse() {
        let userInfo: IUserInfo = Object.assign({}, this.formGroup.value);
        this.accountService.login(userInfo).subscribe(token => this.recibirToken(token),
            error => this.manejarError(error));
       
    }
    recibirToken(token) {
        localStorage.setItem('token', token.token);
        localStorage.setItem('tokenExpiration', token.expiration);
        //this.router.navigate(["/dashboard"]);
        window.location.href = "/";
    }

    manejarError(error) {
        if (error && error.error) {
            alert(error.error[""]);
        }
    }
}
