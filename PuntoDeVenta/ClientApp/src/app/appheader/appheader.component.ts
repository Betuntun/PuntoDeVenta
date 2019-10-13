import { Component, OnInit } from '@angular/core';
import { AccountService } from '../account/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-appheader',
  templateUrl: './appheader.component.html',
  styleUrls: ['./appheader.component.css']
})
export class AppheaderComponent implements OnInit {

  constructor(private accountService: AccountService, private router: Router) { }

  ngOnInit() {
  }

    logout() {
        this.accountService.logout();
        this.router.navigate(['/login']);
    }

    estaLogueado() {
        return this.accountService.estaLogueado();
    }
}
