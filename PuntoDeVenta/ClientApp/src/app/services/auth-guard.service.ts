import { Injectable } from '@angular/core';
import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, Router } from '@angular/router';
import { Observable } from 'rxjs';
import { AccountService } from '../account/account.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuardService implements CanActivate {

    canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot): boolean | UrlTree | Observable<boolean | UrlTree> | Promise<boolean | UrlTree> {
        if (this.accountService.estaLogueado()) {
            return true;
        } else {

            //si no esta logueado llevalo a esta ruta
            this.router.navigate(['/login']);
            return false;
        }
    }

    constructor(private accountService: AccountService, private router : Router) { }
}
