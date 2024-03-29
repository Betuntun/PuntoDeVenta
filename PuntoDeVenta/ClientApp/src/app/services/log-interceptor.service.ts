import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpResponse } from '@angular/common/http';
import { finalize, tap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class LogInterceptorService implements  HttpInterceptor {


    intercept(req: import("@angular/common/http").HttpRequest<any>, next: import("@angular/common/http").HttpHandler): import("rxjs").Observable<import("@angular/common/http").HttpEvent<any>> {
        const started = Date.now();
        let ok: string;

        // extend server response observable with logging
        return next.handle(req)
            .pipe(
                tap(
                    // Succeeds when there is a response; ignore other events
                    event => ok = event instanceof HttpResponse ? event.body : '',
                    // Operation failed; error is an HttpErrorResponse
                    error => ok = 'failed'
                ),
                // Log when response observable either completes or errors
                finalize(() => {

                    // const elapsed = Date.now() - started;

                    //const msg = `${req.method} "${req.urlWithParams}"

                    // ${ok} in ${elapsed} ms.`;

                    console.log(ok);

                })

            );


    }

  constructor() { }
}
