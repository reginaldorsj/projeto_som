import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, EMPTY } from 'rxjs';
import { environment } from '../../environments/environment';
import { map, catchError } from 'rxjs/operators';

import { ModelService } from '../Models/model.service';
import { MessageService } from 'primeng/api';

import { Medico } from '../Models/medico';


@Injectable({
  providedIn: 'root'
})
export class MedicoService {

  constructor(private http: HttpClient, private model: ModelService, private messageService: MessageService) { }

  errorHandler(e: any): Observable<any> {
    const msgErro: string = e.message;
    this.messageService.add({ key: 'tc', severity: 'error', summary: 'Cuidado!', detail: msgErro });
    //alert(msgErro);
    console.log(e);
    return EMPTY;
  }

  selecionarPor(cremeb: string, siglaUf: string): Observable<Medico> {
    return this.http
      .get(`${environment.webapiUrl}medico/${cremeb}/${siglaUf}`)
      .pipe(
        map((medico: any) => {
          let x: Medico = new Medico();
          this.model.deepCopy(medico, x);
          return x
        }
        ), catchError((e) => this.errorHandler(e))
      );
  }
  inserir(medico: Medico): Observable<Medico> {
    let body: string = JSON.stringify(medico);
    return this.http
      .post(`${environment.webapiUrl}medico/inserir/`, body)
      .pipe(
        map((data: any) => {
          let x: Medico = new Medico();
          this.model.deepCopy(data, x);
          return x;
        }), catchError((e) => this.errorHandler(e))
      );
  }
  alterar(medico: Medico): Observable<Medico> {
    let body: string = JSON.stringify(medico);
    return this.http
      .put(`${environment.webapiUrl}medico/alterar/`, body)
      .pipe(
        map((data: any) => {
          let x: Medico = new Medico();
          this.model.deepCopy(data, x);
          return x;
        }), catchError((e) => this.errorHandler(e))
      );
  }

  excluir(medico: Medico): Observable<any> {
    var id = medico.IdMedico;
    return this.http
      .delete(`${environment.webapiUrl}medico/excluir/${id}`).pipe(catchError((e) => this.errorHandler(e)));

    //let body: string = JSON.stringify(medicos);
    //return this.http
    //  .request('delete', `${environment.webapiUrl}medico/excluirlista/`, { "body": body });
  }
  listarPorNome(nome: string): Observable<Medico[]> {
    return this.http
      .get(`${environment.webapiUrl}medico/listarpornome?nome=${nome}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => {
            let x: Medico = new Medico();
            this.model.deepCopy(item, x);
            return x
          })
        ), catchError((e) => this.errorHandler(e))
      );
  }
}
