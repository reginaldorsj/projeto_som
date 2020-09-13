import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, EMPTY } from 'rxjs';
import { environment } from '../../environments/environment';
import { map, catchError } from 'rxjs/operators';

import { ModelService } from '../Models/model.service';

import { Municipio } from '../Models/municipio';
import { Uf } from '../Models/uf';


@Injectable({
  providedIn: 'root'
})
export class MunicipioService {

  constructor(private http: HttpClient, private model: ModelService) { }

  errorHandler(e: any): Observable<any> {
    const msgErro: String = "ERRO! \r\n" + e.message;
    alert(msgErro);
    console.log(e);
    return EMPTY;
  }

  listarPorNome(uf: Uf, nomeMunicipio: String): Observable<Municipio[]> {
    let ufJson = JSON.stringify(uf);
    return this.http
      .post(`${environment.webapiUrl}municipio/listar/${nomeMunicipio}`, JSON.parse(ufJson))
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => {
            let x: Municipio = new Municipio();
            this.model.deepCopy(item, x);
            return x
          })
        ), catchError((e) => this.errorHandler(e))
      );
  }

  selecionarPorId(id: number): Observable<Municipio> {
    return this.http
      .get(`${environment.webapiUrl}municipio/selecionarporid/${id}`)
      .pipe(
        map((data: any) => {
          let x: Municipio = new Municipio();
          this.model.deepCopy(data, x);
          return x
        }), catchError((e) => this.errorHandler(e))
      );
  }
}
