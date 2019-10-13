import { Component, OnInit } from '@angular/core';
import { AccountService } from '../account/account.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-contenido',
  templateUrl: './contenido.component.html',
  styleUrls: ['./contenido.component.css']
})
export class ContenidoComponent implements OnInit {

    constructor(private accountService: AccountService, private router: Router) { }

    ngOnInit() {
    }



    estaLogueado() {
        return this.accountService.estaLogueado();
    }
}
