import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, EMPTY } from 'rxjs';
import { environment } from '../../environments/environment';
import { map, catchError } from 'rxjs/operators';

import { ModelService } from '../Models/model.service';

import { Diagnostico } from '../Models/diagnostico';
import { Atendimento } from '../Models/atendimento';
import { Doenca } from '../Models/doenca';


@Injectable({
  providedIn: 'root'
})
export class DiagnosticoService {

  constructor(private http: HttpClient, private model: ModelService) { }

  errorHandler(e: any): Observable<any> {
    const msgErro: String = "ERRO! \r\n" + e.message;
    alert(msgErro);
    console.log(e);
    return EMPTY;
  }

  listarDoencas(atendimento: Atendimento): Observable<Doenca[]> {
    var id = atendimento.IdAtendimento;
    return this.http
      .get(`${environment.webapiUrl}diagnostico/listardoencas?idatendimento=${id}`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => {
            let x: Doenca = new Doenca();
            this.model.deepCopy(item, x);
            return x
          })
        ), catchError((e) => this.errorHandler(e))
      );
  }
}
