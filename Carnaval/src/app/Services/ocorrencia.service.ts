import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, EMPTY } from 'rxjs';
import { environment } from '../../environments/environment';
import { map, catchError } from 'rxjs/operators';

import { Totalizacao } from '../Models/totalizacao';


@Injectable({
  providedIn: 'root'
})
export class OcorrenciaService {

  constructor(private http: HttpClient) { }

  errorHandler(e: any): Observable<any> {
    const msgErro: String = "ERRO! \r\n" + e.message;
    alert(msgErro);
    console.log(e);
    return EMPTY;
  }

  getTotalOcorrencias(): Observable<number> {
    return this.http
      .get(`${environment.webapiUrl}totalocorrencia`)
      .pipe(
        map((item: number) => {
          return item;
        }), catchError((e) => this.errorHandler(e))
      );
  }

  getResumoSiglaUnidade(): Observable<Totalizacao[]> {
    return this.http
      .get(`${environment.webapiUrl}unidadesigla`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Totalizacao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }

  getTotalizacao(detalhe: string): Observable<Totalizacao[]> {
    return this.http
      .get(`${environment.webapiUrl}${detalhe}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Totalizacao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }
  getResumoDoencaUnidade(idUnidade: number): Observable<Totalizacao[]> {
    return this.http
      .get(`${environment.webapiUrl}doencaunidade/${idUnidade}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Totalizacao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }
  getResumoCausaOrigem(idOrigem: number): Observable<Totalizacao[]> {
    return this.http
      .get(`${environment.webapiUrl}causaorigem/${idOrigem}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Totalizacao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }
  getResumoOrigemCausa(idCausa: number): Observable<Totalizacao[]> {
    return this.http
      .get(`${environment.webapiUrl}origemcausa/${idCausa}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Totalizacao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }
  getResumoDoencaProcedimento(idProcedimento: number): Observable<Totalizacao[]> {
    return this.http
      .get(`${environment.webapiUrl}doencaprocedimento/${idProcedimento}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Totalizacao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }
  getResumoPostoSaude(): Observable<Totalizacao[]> {
    return this.http
      .get(`${environment.webapiUrl}postosaude`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Totalizacao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }
  getResumoDemandaExpontanea(): Observable<Totalizacao[]> {
    return this.http
      .get(`${environment.webapiUrl}demandaexpontanea`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => Object.assign(new Totalizacao(), item))
        ), catchError((e) => this.errorHandler(e))
      );
  }

}
