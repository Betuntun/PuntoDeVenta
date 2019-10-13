import { Component, OnInit } from '@angular/core';
import { IProducto } from './producto';
import { ProductosService } from './productos.service';


@Component({
    selector: 'app-productos',
    templateUrl: './productos.component.html',
    styleUrls: ['./productos.component.css']
})
export class ProductosComponent implements OnInit {
    productos: IProducto[];
    
    constructor(private productosService: ProductosService) { }

    ngOnInit() {
        //el listado de productos asiganalo a productos para mostrarlo en el html
        this.productosService.getProductos().subscribe(productos => this.productos = productos, error => console.error(error));
       // let a = this.productos.length.valueOf;
    }

    //handlePage(e: PageEvent) {
    //    this.page_size = e.pageSize;
    //    this.page_number = e.pageIndex + 1;
   // }

    page_size: number = 10;
    page_number: number = 1;
    pageSizeOptions = [5, 10, 20, 50];
}
