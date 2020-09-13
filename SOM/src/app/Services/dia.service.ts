import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, EMPTY } from 'rxjs';
import { environment } from '../../environments/environment';
import { map, catchError } from 'rxjs/operators';

import { MessageService } from 'primeng/api/';
import { ModelService } from '../Models/model.service';
import { CarnavalService } from './carnaval.service';

import { Dia } from '../Models/dia';


@Injectable({
  providedIn: 'root'
})
export class DiaService {

  constructor(private http: HttpClient, private model: ModelService, private carnavalService: CarnavalService,
    private messageService: MessageService) { }

  errorHandler(e: any): Observable<any> {
    const msgErro: string = e.message;
    this.messageService.add({ key: 'tc', severity: 'error', summary: 'Erro interno!', detail: msgErro });
    //alert(msgErro);
    console.log(e);
    return EMPTY;
  }

  listar(): Observable<Dia[]> {
    return this.http
      .get(`${environment.webapiUrl}dia/listar`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => {
            let x: Dia = new Dia();
            this.model.deepCopy(item, x);
            return x
          })
        ), catchError((e) => this.errorHandler(e))
      );
  }
}
