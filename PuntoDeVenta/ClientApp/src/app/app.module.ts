import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { AppheaderComponent } from './appheader/appheader.component';
import { MenuComponent } from './menu/menu.component';
import { ContenidoComponent } from './contenido/contenido.component';
import { FooterComponent } from './footer/footer.component';
import { ClientesComponent } from './contenidos/ventas/clientes/clientes.component';
import { VentaComponent } from './contenidos/ventas/venta/venta.component';
import { EstadisticaventaComponent } from './contenidos/ventas/estadisticaventa/estadisticaventa.component';
import { ComprasComponent } from './contenidos/compras/compras/compras.component';
import { ComprasestadisticaComponent } from './contenidos/compras/comprasestadistica/comprasestadistica.component';
import { ProvedoresComponent } from './contenidos/compras/provedores/provedores.component';
import { ProductosComponent } from './contenidos/productos/productos/productos.component';
import { DashboardComponent } from './contenidos/dashboard/dashboard.component';
import { ProductosService } from './contenidos/productos/productos/productos.service';
import { ProductosFormComponent } from './contenidos/productos/productos-form/productos-form.component';
import { PaginatePipe } from './pipes/paginate.pipe';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { LoginComponent } from './contenidos/login/login/login.component';
import { AuthGuardService } from './services/auth-guard.service';
import { AccountService } from './account/account.service';
import { LoginRegisterComponent } from './contenidos/login/login-register/login-register.component';
import { LogInterceptorService } from './services/log-interceptor.service';
import { AuthInterceptorService } from './services/auth-interceptor.service';

@NgModule({
  declarations: [
    AppComponent,
    AppheaderComponent,
    MenuComponent,
    ContenidoComponent,
    FooterComponent,
    ClientesComponent,
    VentaComponent,
    EstadisticaventaComponent,
    ComprasComponent,
    ComprasestadisticaComponent,
    ProvedoresComponent,
    ProductosComponent,
    DashboardComponent,
    ProductosFormComponent,
    PaginatePipe,
    LoginComponent,
    LoginRegisterComponent
  ],
    imports: [
        BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
        HttpClientModule,
        FormsModule,
        ReactiveFormsModule,
        RouterModule.forRoot([
            { path: '', component: DashboardComponent, pathMatch: 'full', canActivate: [AuthGuardService]  },
            { path: 'clientes', component: ClientesComponent, canActivate: [AuthGuardService]  },
            { path: 'puntodeventa', component: VentaComponent, canActivate: [AuthGuardService]  },
            { path: 'estadisticaventa', component: EstadisticaventaComponent, canActivate: [AuthGuardService]  },
            { path: 'productos', component: ProductosComponent, canActivate: [AuthGuardService] },
            { path: 'compras', component: ComprasComponent, canActivate: [AuthGuardService]  },
            { path: 'comprasestadistica', component: ComprasestadisticaComponent, canActivate: [AuthGuardService]  },
            { path: 'provedores', component: ProvedoresComponent, canActivate: [AuthGuardService]  },
            { path: 'dashboard', component: DashboardComponent, canActivate: [AuthGuardService]  },
            { path: 'productos-agregar', component: ProductosFormComponent, canActivate: [AuthGuardService]  },
            { path: 'productos-editar/:id', component: ProductosFormComponent, canActivate: [AuthGuardService]  },
            { path: 'login', component: LoginComponent },
            { path: 'register', component: LoginRegisterComponent },
    ]),
    BrowserAnimationsModule
    ],
    providers: [ProductosService, AuthGuardService, AccountService,
        {
            provide: HTTP_INTERCEPTORS,
            useClass: LogInterceptorService,
            multi: true
        },
        {
            provide: HTTP_INTERCEPTORS,
            useClass: AuthInterceptorService,
            multi: true
        }
    ],
  bootstrap: [AppComponent]
})
export class AppModule { }
