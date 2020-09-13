import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, EMPTY } from 'rxjs';
import { environment } from '../../environments/environment';
import { map, catchError } from 'rxjs/operators';

import { ModelService } from '../Models/model.service';

import { Procedencia } from '../Models/procedencia';


@Injectable({
  providedIn: 'root'
})
export class ProcedenciaService {

  constructor(private http: HttpClient, private model: ModelService) { }

  errorHandler(e: any): Observable<any> {
    const msgErro: String = "ERRO! \r\n" + e.message;
    alert(msgErro);
    console.log(e);
    return EMPTY;
  }

  listar(): Observable<Procedencia[]> {
    return this.http
      .get(`${environment.webapiUrl}procedencia/listar/`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => {
            let x: Procedencia = new Procedencia();
            this.model.deepCopy(item, x);
            return x
          })
        ), catchError((e) => this.errorHandler(e))
      );
  }
}
