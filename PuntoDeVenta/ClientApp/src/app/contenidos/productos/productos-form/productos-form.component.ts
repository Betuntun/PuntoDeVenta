import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { IProducto } from '../productos/producto';
import { ProductosService } from '../productos/productos.service';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
    selector: 'app-productos-form',
    templateUrl: './productos-form.component.html',
    styleUrls: ['./productos-form.component.css']
})
export class ProductosFormComponent implements OnInit {

    constructor(private fb: FormBuilder, private productosService: ProductosService, private router: Router, private activateRoute: ActivatedRoute) { }
    //variable de formulario
    formGroup: FormGroup;
    modoEdicion: boolean = false;
    productoId: number;
    imagen: File = null;

    ngOnInit() {
        this.formGroup = this.fb.group({
            nombre: '',
            precio: '',
            ingredientes: '',
            rutaImagen: [null],
            categoriaID: 1,
            ApplicationUserID : 'Vaquero'
        });
        this.activateRoute.params.subscribe(params => {
            if (params["id"] == undefined) {
                return;
            }
            this.modoEdicion = true;
            this.productoId = params['id'];
            this.productosService.getProducto(this.productoId.toString()).subscribe(producto => this.cargarFormulario(producto), error => console.error(error));
        });
    }
    cargarFormulario(producto: IProducto) {
        this.productoId = producto.id;
        this.formGroup.patchValue({
            nombre: producto.nombre,
            precio: producto.precio,
            ingredientes: producto.ingredientes,
            rutaImagen: producto.rutaImagen
        });
    }
    save() {
        let producto: IProducto = Object.assign({}, this.formGroup.value);
        console.table(producto);

        if (this.modoEdicion) {
            //editar registro
            producto.id = this.productoId;
            console.log(this.productoId)
            console.table(producto);
            
            producto.rutaImagen = "upload/default.png";

            if (this.imagen != null) {
               
                this.productosService.subirImagen(this.imagen).subscribe(imagen => this.onSaveSuccess(), error => console.error(error));
                producto.rutaImagen = "upload/" + this.imagen.name;
            }

            this.productosService.updateProducto(producto).subscribe(producto => this.onSaveSuccess(), error => console.error(error));
        } else {
            //agregar registro
            producto.rutaImagen = "default.png";
            
            if (this.imagen != null) {
                this.productosService.subirImagen(this.imagen).subscribe(imagen => this.onSaveSuccess(), error => console.error(error));
                producto.rutaImagen = this.imagen.name;
            }
            

          
            this.productosService.createProducto(producto).subscribe(producto => this.onSaveSuccess(), error => console.error(error));
        }

        
    }

    onSaveSuccess() {
        this.router.navigate(["/productos"]);
    }

    onFileSelected(event) {
        console.log(event);
        this.imagen = <File>event.target.files[0];
    }
}
