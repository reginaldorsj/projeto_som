import { Component, OnInit } from '@angular/core';
import { SelectItem } from 'primeng/api';

import { QuadroDetalheComponent } from '../../Components/quadro-detalhe/quadro-detalhe.component';

import { DialogService } from 'primeng/dynamicdialog';
import { OcorrenciaService } from '../../Services/ocorrencia.service';

import { Dia } from '../../Models/dia';
import { CommonService } from '../../Services/common.service';


@Component({
  selector: 'app-ocorrencia',
  templateUrl: './ocorrencia.component.html',
  styleUrls: ['./ocorrencia.component.css'],
  providers: [DialogService]
})
export class OcorrenciaComponent implements OnInit {

  types: SelectItem[];
  selectedType: string = "Unidade";

  dias: Dia[];
  quadro: any[];


  constructor(private ocorrenciaService: OcorrenciaService, private commonService: CommonService, public dialogService: DialogService) {
    this.types = [
      { label: 'Por Unidade', value: 'Unidade' },
      { label: 'Por Origem', value: 'Origem' },
      { label: 'Por Causa', value: 'Causa' },
      { label: 'Por Procedimento', value: 'Procedimento' },
      { label: 'Por Procedência', value: 'Procedencia' }
    ];

    this.commonService.getDia().subscribe(dias => {
      this.dias = dias;
    })

    this.totalizacao();

    let i = setInterval(() => {
      this.totalizacao();
    }, 1000 * 180);

  }

  ngOnInit(): void {
  }

  totalizacao(): void {
    this.ocorrenciaService.getTotalizacao(this.selectedType).subscribe(totalizacao => {
      this.quadro = this.commonService.setQuadro(totalizacao);
    });
  }

  showDialog(selectedType: string, titulo: string, detalhe: string, quadroInterno: any[]) {
    var ref = this.dialogService.open(QuadroDetalheComponent, {
      data: {
        "dias": this.dias,
        "quadro": quadroInterno,
        "Descricao": titulo
      },
      header: selectedType + ': ' + detalhe.toUpperCase(),
      width: '70%'
    });
  }

  show(selectedType: string, detalhe: string, id: number) {
    let promisse = new Promise((resolve, reject) => {
      this.commonService.getDia().subscribe(dias => {
        this.dias = dias;
        resolve();
      })
    });

    promisse.then(() => {

      switch (selectedType) {
        case "Unidade":
          this.ocorrenciaService.getResumoDoencaUnidade(id).subscribe(totalizacao => {
            var quadroInterno = this.commonService.setQuadro(totalizacao);
            this.showDialog(selectedType, "Doença", detalhe, quadroInterno)
          });
          break;
        case "Origem":
          this.ocorrenciaService.getResumoCausaOrigem(id).subscribe(totalizacao => {
            var quadroInterno = this.commonService.setQuadro(totalizacao);
            this.showDialog(selectedType, "Causa", detalhe, quadroInterno)
          });
          break;
        case "Causa":
          this.ocorrenciaService.getResumoOrigemCausa(id).subscribe(totalizacao => {
            var quadroInterno = this.commonService.setQuadro(totalizacao);
            this.showDialog(selectedType, "Origem", detalhe, quadroInterno)
          });
          break;
        case "Procedimento":
          this.ocorrenciaService.getResumoDoencaProcedimento(id).subscribe(totalizacao => {
            var quadroInterno = this.commonService.setQuadro(totalizacao);
            this.showDialog(selectedType, "Doença", detalhe, quadroInterno)
          });
          break;
        case "Procedencia":
          if (detalhe == "Transferência") {
            this.ocorrenciaService.getResumoPostoSaude().subscribe(totalizacao => {
              var quadroInterno = this.commonService.setQuadro(totalizacao);
              this.showDialog(selectedType, "Posto de Saúde (Origem)", detalhe, quadroInterno)
            });
          } else if (detalhe == "Demanda Expontânea") {
            this.ocorrenciaService.getResumoDemandaExpontanea().subscribe(totalizacao => {
              var quadroInterno = this.commonService.setQuadro(totalizacao);
              this.showDialog(selectedType, "Unidade", detalhe, quadroInterno)
            });
          }
          break;
      };
    });
  }
}
