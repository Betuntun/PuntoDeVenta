import { Component, OnInit } from '@angular/core';
import { AccountService } from '../account/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

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
