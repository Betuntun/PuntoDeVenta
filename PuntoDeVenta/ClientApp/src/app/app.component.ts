import { Component } from '@angular/core';
import { AccountService } from './account/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent {
    constructor(private accountService: AccountService, private router: Router) { }

    title = 'app';

  

    estaLogueado() {
        return this.accountService.estaLogueado();
    }
}
