import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, EMPTY } from 'rxjs';
import { environment } from '../../environments/environment';
import { map, catchError } from 'rxjs/operators';

import { ModelService } from '../Models/model.service';

import { Carnaval } from '../Models/carnaval';
import { Dia } from '../Models/dia';
import { Totalizacao } from '../Models/totalizacao';

@Injectable({
  providedIn: 'root'
})
export class CommonService {

  constructor(private http: HttpClient, private modelService: ModelService) { }

  errorHandler(e: any): Observable<any> {
    const msgErro: String = "ERRO! \r\n" + e.message;
    alert(msgErro);
    console.log(e);
    return EMPTY;
  }

  getCarnaval(): Observable<Carnaval> {
    return this.http
      .get(`${environment.webapiUrl}carnaval`)
      .pipe(
        map((item: any) => Object.assign(new Carnaval(), item)
        ), catchError((e) => this.errorHandler(e))
      );
  }

  getDia(): Observable<Dia[]> {
    return this.http
      .get(`${environment.webapiUrl}dia`)
      .pipe(
        map((data: any[]) =>
          data.map((item: any) => {
            let x: Dia = new Dia();
            this.modelService.deepCopy(item, x);
            return x
          })
        ), catchError((e) => this.errorHandler(e))
      );
  }

  setQuadro(totalizacao: Totalizacao[], comData?: boolean): any[] {
    var qdr = [];
    if (totalizacao.length == 0)
      return qdr;

    var descricaoDetalhe = totalizacao[0].Detalhe;
    var i: number = 0;
    var somaLinha: number = 0;
    var linha = { "Detalhe": descricaoDetalhe, "Id": totalizacao[0].Id };
    var somaColuna = { "Detalhe": "Total" };
    var totalGeral: number = 0;

    while (i < totalizacao.length) {
      if (descricaoDetalhe == totalizacao[i].Detalhe) {
        if (!comData || (comData && comData == true)) {
          linha[totalizacao[i].Data.toString()] = totalizacao[i].Quantidade;
          if (somaColuna[totalizacao[i].Data.toString()] == undefined) {
            somaColuna[totalizacao[i].Data.toString()] = totalizacao[i].Quantidade;
          }
          else {
            somaColuna[totalizacao[i].Data.toString()] = Number.parseInt(somaColuna[totalizacao[i].Data.toString()]) + totalizacao[i].Quantidade;
          }
        }
        somaLinha += totalizacao[i].Quantidade;
        i++;
      } else {
        linha["Total"] = somaLinha;
        totalGeral += somaLinha;
        qdr.push(linha);

        descricaoDetalhe = totalizacao[i].Detalhe;
        somaLinha = 0;
        linha = { "Detalhe": descricaoDetalhe, "Id": totalizacao[i].Id };
      }
    }
    linha["Total"] = somaLinha;
    totalGeral += somaLinha;
    qdr.push(linha);

    somaColuna["Total"] = totalGeral;
    qdr.push(somaColuna);

    return qdr;
  }


}
