import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable, EMPTY } from 'rxjs';
import { environment } from '../../environments/environment';
import { map, catchError } from 'rxjs/operators';

import { ModelService } from '../Models/model.service';
import { MessageService } from 'primeng/api';

import { Atendimento } from '../Models/atendimento';
import { Doenca } from '../Models/doenca';
import { Ocorrencia } from '../Models/ocorrencia';


@Injectable({
  providedIn: 'root'
})
export class AtendimentoService {

  constructor(private http: HttpClient, private model: ModelService, private messageService: MessageService) { }

  errorHandler(e: any): Observable<any> {
    const msgErro: string = e.message;
    this.messageService.add({ key: 'tc', severity: 'error', summary: 'Erro interno!', detail: msgErro });
    //alert(msgErro);
    console.log(e);
    return EMPTY;
  }

  inserir(atendimento: Atendimento, doencas: Doenca[]): Observable<Atendimento> {
    let ocorrencia: Ocorrencia = new Ocorrencia();
    ocorrencia.Atendimento = atendimento;
    ocorrencia.Doencas = doencas

    let body: string = JSON.stringify(ocorrencia);
    return this.http
      .post(`${environment.webapiUrl}atendimento/inserir/`, body)
      .pipe(
        map((data: any) => {
          let x: Atendimento = new Atendimento();
          this.model.deepCopy(data, x);

          x.Causa = atendimento.Causa;
          x.Procedimento = atendimento.Procedimento;
          x.Origem = atendimento.Origem;

          return x;
        }), catchError((e) => this.errorHandler(e))
      );
  }
  alterar(atendimento: Atendimento, doencas: Doenca[]): Observable<Atendimento> {
    let ocorrencia: Ocorrencia = new Ocorrencia();
    ocorrencia.Atendimento = atendimento;
    ocorrencia.Doencas = doencas

    let body: string = JSON.stringify(ocorrencia);
    return this.http
      .put(`${environment.webapiUrl}atendimento/alterar/`, body)
      .pipe(
        map((data: any) => {
          let x: Atendimento = new Atendimento();
          this.model.deepCopy(data, x);

          x.Causa = atendimento.Causa;
          x.Procedimento = atendimento.Procedimento;
          x.Origem = atendimento.Origem;

          return x;
        }), catchError((e) => this.errorHandler(e))
      );
  }

  excluir(atendimento: Atendimento): Observable<any> {
    var id = atendimento.IdAtendimento;
    return this.http
      .delete(`${environment.webapiUrl}atendimento/excluir/${id}`).pipe(catchError((e) => this.errorHandler(e)));

    //let body: string = JSON.stringify(atendimentos);
    //return this.http
    //  .request('delete', `${environment.webapiUrl}atendimento/excluirlista/`, { "body": body });
  }

  listarPorNome(nome: string): Observable<Atendimento[]> {
    return this.http
      .get(`${environment.webapiUrl}atendimento/listarpornome?nome=${nome}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => {
            let x: Atendimento = new Atendimento();
            this.model.deepCopy(item, x);
            return x
          })
        ), catchError((e) => this.errorHandler(e))
      );
  }
}
