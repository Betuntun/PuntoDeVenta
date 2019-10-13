import { Component, OnInit } from '@angular/core';
import { AccountService } from '../account/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-footer',
  templateUrl: './footer.component.html',
  styleUrls: ['./footer.component.css']
})
export class FooterComponent implements OnInit {

    constructor(private accountService: AccountService, private router: Router) { }

    ngOnInit() {
    }

    logout() {
        this.accountService.logout();
        this.router.navigate(['/']);
    }

    estaLogueado() {
        return this.accountService.estaLogueado();
    }

}
