import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { IProducto } from './producto';
import { error } from '@angular/compiler/src/util';

@Injectable({
    providedIn: 'root'
})
export class ProductosService {

   
    private apiURL = this.baseUrl + "api/Productoes";
    private apiURLL = this.baseUrl + "api/upload";
    constructor(private http: HttpClient, @Inject('BASE_URL') private baseUrl: string) { }

   
    getProductos(): Observable<IProducto[]> {
        return this.http.get<IProducto[]>(this.apiURL);
    }
    
    getProducto(productoId: string): Observable<IProducto> {
        //devolver un solo producto
        return this.http.get<IProducto>(this.apiURL + '/' + productoId);
    }

    createProducto(producto: IProducto): Observable<IProducto> {


        //A la base
        return this.http.post<IProducto>(this.apiURL, producto);
       
    }

    subirImagen(imagen: File) {
        const fb = new FormData();

        fb.append('image', imagen, imagen.name);
        return this.http.post(this.apiURLL, fb);
    }

    updateProducto(producto: IProducto): Observable<IProducto> {
        return this.http.put<IProducto>(this.apiURL + '/' + producto.id.toString(), producto);
    }
}
