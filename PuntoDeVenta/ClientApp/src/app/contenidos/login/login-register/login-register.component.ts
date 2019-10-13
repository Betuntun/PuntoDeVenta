import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { AccountService } from '../../../account/account.service';
import { Router } from '@angular/router';
import { IUserInfo } from '../../../account/user-info';

@Component({
    selector: 'app-login-register',
    templateUrl: './login-register.component.html',
    styleUrls: ['./login-register.component.css']
})
export class LoginRegisterComponent implements OnInit {

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
    registrarse() {
        let userInfo: IUserInfo = Object.assign({}, this.formGroup.value);
        this.accountService.create(userInfo).subscribe(token => this.recibirToken(token),
            error => this.manejarError(error));
    }

    recibirToken(token) {
        localStorage.setItem('token', token.token);
        localStorage.setItem('tokenExpiration', token.expiration);
        this.router.navigate([""]);
    }
    manejarError(error) {
        if (error && error.error) {
            alert(error.error[""]);
        }

    }
}
