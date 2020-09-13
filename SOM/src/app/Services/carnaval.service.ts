import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, EMPTY } from 'rxjs';
import { environment } from '../../environments/environment';
import { map, catchError } from 'rxjs/operators';

import { ModelService } from '../Models/model.service';

import { Carnaval } from '../Models/carnaval';


@Injectable({
  providedIn: 'root'
})
export class CarnavalService {

  constructor(private http: HttpClient, private model: ModelService) { }

  errorHandler(e: any): Observable<any> {
    const msgErro: String = "ERRO! \r\n" + e.message;
    alert(msgErro);
    console.log(e);
    return EMPTY;
  }

  get(): Observable<Carnaval> {
    return this.http
      .get(`${environment.webapiUrl}Carnaval/ativo`)
      .pipe(
        map((item: any) => {
            let x: Carnaval = new Carnaval();
            this.model.deepCopy(item, x);
            return x
          }), catchError((e) => this.errorHandler(e))
      );
  }
}
