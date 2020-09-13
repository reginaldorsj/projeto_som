import { Component, OnInit } from '@angular/core';
import { SelectItem } from 'primeng/api';

import { DialogService } from 'primeng/dynamicdialog';
import { PlantaoService } from '../../Services/plantao.service';
import { CommonService } from '../../Services/common.service';

import { PlantaoDetalheComponent } from '../../Components/plantao-detalhe/plantao-detalhe.component';
import { ListagemPlantaoComponent } from '../../Components/listagem-plantao/listagem-plantao.component';

@Component({
  selector: 'app-plantao',
  templateUrl: './plantao.component.html',
  styleUrls: ['./plantao.component.css'],
  providers: [DialogService]
})
export class PlantaoComponent implements OnInit {

  types: SelectItem[];
  selectedType: string = "Unidade";

  quadro: any[];

  constructor(private commonService: CommonService, private plantaoService: PlantaoService, public dialogService: DialogService) {
    this.types = [
      { label: 'Por Unidade', value: 'Unidade' },
      { label: 'Por Especialidade', value: 'Especialidade' },
      { label: 'Plantões Agora', value: 'Especialidade Agora' }
    ];

    this.totalizacao();

    let i = setInterval(() => {
      this.totalizacao();
    }, 1000 * 180);
  }

  ngOnInit(): void {
  }

  totalizacao(): void {
    this.plantaoService.getPlantaoPor(this.selectedType).subscribe(totalizacao => {
      this.quadro = this.commonService.setQuadro(totalizacao, false);
    });
  }

  show(selectedType: string, detalhe: string, id: number): void {
    if (selectedType == "Especialidade") {
      this.plantaoService.getPlantaoEspecialidadeUnidade(id).subscribe(totalizacao => {
        var quadroInterno = this.commonService.setQuadro(totalizacao);
        var ref = this.dialogService.open(PlantaoDetalheComponent, {
          data: {
            "quadro": quadroInterno,
            "Descricao": "Unidade"
          },
          header: selectedType + ': ' + detalhe.toUpperCase(),
          width: '70%'
        });
      });
    } else if (selectedType == "Unidade") {
      this.plantaoService.getListagemPlantao(id).subscribe(plantoes => {
        var ref = this.dialogService.open(ListagemPlantaoComponent, {
          data: {
            "plantoes": plantoes,
            "Descricao": "Especialidade"
          },
          header: selectedType + ': ' + detalhe.toUpperCase(),
          width: '70%'
        });
      });
    } else if (selectedType == "Especialidade Agora") {
      this.plantaoService.getPlantaoEspecialidadeUnidadeAgora(id).subscribe(totalizacao => {
        var quadroInterno = this.commonService.setQuadro(totalizacao);
        var ref = this.dialogService.open(PlantaoDetalheComponent, {
          data: {
            "quadro": quadroInterno,
            "Descricao": "Unidade"
          },
          header: selectedType + ': ' + detalhe.toUpperCase(),
          width: '70%'
        });
      });
    }
  }
}
