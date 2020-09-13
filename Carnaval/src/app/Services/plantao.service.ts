import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, EMPTY } from 'rxjs';
import { environment } from '../../environments/environment';
import { map, catchError } from 'rxjs/operators';

import { Totalizacao } from '../Models/totalizacao';
import { Plantao } from '../Models/plantao';

@Injectable({
  providedIn: 'root'
})
export class PlantaoService {

  constructor(private http: HttpClient) { }

  errorHandler(e: any): Observable<any> {
    const msgErro: String = "ERRO! \r\n" + e.message;
    alert(msgErro);
    console.log(e);
    return EMPTY;
  }

  getTotalPlantoes(): Observable<number> {
    return this.http
      .get(`${environment.webapiUrl}totalplantao`)
      .pipe(
        map((item: number) => {
          return item;
        }), catchError((e) => this.errorHandler(e))
      );
  }

  getPlantaoUnidadeSigla(): Observable<Totalizacao[]> {
    return this.http
      .get(`${environment.webapiUrl}plantaounidadeSigla`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Totalizacao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }
  getPlantaoPor(detalhe: string): Observable<Totalizacao[]> {
    detalhe = detalhe.replace(' ', '');

    return this.http
      .get(`${environment.webapiUrl}plantao${detalhe}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Totalizacao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }

  getPlantaoEspecialidadeUnidade(idUnidade: number): Observable<Totalizacao[]> {
    return this.http
      .get(`${environment.webapiUrl}plantaoespecialidadeunidade/${idUnidade}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Totalizacao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }

  getListagemPlantao(idUnidade: number): Observable<Plantao[]> {
    return this.http
      .get(`${environment.webapiUrl}listagemplantao/${idUnidade}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Plantao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }

  getPlantaoEspecialidadeUnidadeAgora(idUnidade: number): Observable<Totalizacao[]> {
    return this.http
      .get(`${environment.webapiUrl}plantaoespecialidadeunidadeagora/${idUnidade}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Totalizacao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }
}
