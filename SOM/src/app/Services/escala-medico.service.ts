import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, EMPTY } from 'rxjs';
import { map, catchError } from 'rxjs/operators';
import { environment } from '../../environments/environment';

import { CarnavalService } from './carnaval.service';
import { ModelService } from '../Models/model.service';
import { MessageService } from 'primeng/api';

import { EscalaMedico } from '../Models/escala-medico';
import { Medico } from '../Models/medico';

@Injectable({
  providedIn: 'root'
})
export class EscalaMedicoService {

  constructor(private http: HttpClient, private model: ModelService, private messageService: MessageService,
    private carnavalService: CarnavalService) { }

  errorHandler(e: any): Observable<any> {
    const msgErro: string = e.message;
    this.messageService.add({ key: 'tc', severity: 'error', summary: 'Cuidado!', detail: msgErro });
    //alert(msgErro);
    console.log(e);
    return EMPTY;
  }

  listarPorMedico(medico: Medico): Observable<EscalaMedico[]> {
    return this.http
      .request('get', `${environment.webapiUrl}escalamedico/listar/${medico.IdMedico}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => {
            let x: EscalaMedico = new EscalaMedico();
            this.model.deepCopy(item, x);
            return x
          })
        ), catchError((e) => this.errorHandler(e))
      );
  }

  convertTimeZone(date: Date): Date {
    return new Date(date.getTime() - (date.getTimezoneOffset() * 60000));
  }

  inserir(escalaMedico: EscalaMedico): Observable<EscalaMedico> {

    escalaMedico.DataHoraInicio = this.convertTimeZone(escalaMedico.DataHoraInicio);
    escalaMedico.DataHoraFim = this.convertTimeZone(escalaMedico.DataHoraFim);

    let body: string = JSON.stringify(escalaMedico);
    return this.http
      .post(`${environment.webapiUrl}escalamedico/inserir/`, body)
      .pipe(
        map((data: any) => {
          let x: EscalaMedico = new EscalaMedico();
          this.model.deepCopy(data, x);

          x.Ocupacao = escalaMedico.Ocupacao;

          return x;
        }), catchError((e) => this.errorHandler(e))
      );
  }

 

  alterar(escalaMedico: EscalaMedico): Observable<EscalaMedico> {

    escalaMedico.DataHoraInicio = this.convertTimeZone(escalaMedico.DataHoraInicio);
    escalaMedico.DataHoraFim = this.convertTimeZone(escalaMedico.DataHoraFim);

    let body: string = JSON.stringify(escalaMedico);
    return this.http
      .post(`${environment.webapiUrl}escalamedico/inserir/`, body)
      .pipe(
        map((data: any) => {
          let x: EscalaMedico = new EscalaMedico();
          this.model.deepCopy(data, x);

          x.Ocupacao = escalaMedico.Ocupacao;

          return x;
        }), catchError((e) => this.errorHandler(e))
      );
  }
  excluir(escalas: EscalaMedico[]): Observable<any> {
    let body: string = JSON.stringify(escalas);
    return this.http
      .request('delete', `${environment.webapiUrl}escalamedico/excluirlista/`, { "body": body });
  }
}
