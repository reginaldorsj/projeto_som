import { Component, OnInit } from '@angular/core';

import { OcorrenciaService } from '../../Services/ocorrencia.service';
import { PlantaoService } from '../../Services/plantao.service';

@Component({
  selector: 'app-resumo',
  templateUrl: './resumo.component.html',
  styleUrls: ['./resumo.component.css']
})
export class ResumoComponent implements OnInit {

  titulo: string;
  dataDoughnut: any;

  totalOcorrencias: number;
  totalPlantoes: number;

  constructor(private ocorrenciaService: OcorrenciaService, private plantaoService: PlantaoService) {
    this.titulo = "Total de Ocorrências por Unidade";
    this.totalizacao();

    let i = setInterval(() => {
      this.totalizacao();
    }, 1000 * 180);
  }

  ngOnInit(): void {
  }

  ocorrenciasPorUnidade() {
    this.titulo = "Total de Ocorrências por Unidade";

    this.ocorrenciaService.getResumoSiglaUnidade().subscribe(resumo => {
      var labels = [];
      var datas = [];
      var colors = [];
      resumo.forEach(x => {
        labels.push(x.Detalhe);
        datas.push(x.Quantidade);
        colors.push("#" + x.Cor);
      })

      this.dataDoughnut = {
        labels: labels,
        datasets: [
          {
            data: datas,
            backgroundColor: colors,
            hoverBackgroundColor: colors
          }]
      }
    });

  }

  plantoesPorUnidade() {
    this.titulo = "Total de Plantões por Unidade";

    this.plantaoService.getPlantaoUnidadeSigla().subscribe(resumo => {
      var labels = [];
      var datas = [];
      var colors = [];
      resumo.forEach(x => {
        labels.push(x.Detalhe);
        datas.push(x.Quantidade);
        colors.push("#" + x.Cor);
      })

      this.dataDoughnut = {
        labels: labels,
        datasets: [
          {
            data: datas,
            backgroundColor: colors,
            hoverBackgroundColor: colors
          }]
      }
    });
  }

  totalizacao(): void {
    this.ocorrenciaService.getTotalOcorrencias().subscribe(totalOcorrencias => {

      if (this.titulo.indexOf("Ocorrências") >= 0)
        this.ocorrenciasPorUnidade();
      else
        this.plantoesPorUnidade();

      this.totalOcorrencias = 0;
      let i = setInterval(() => {
        this.totalOcorrencias++;
        if (this.totalOcorrencias == totalOcorrencias)
          clearInterval(i);
      }, 25);
    });

    this.plantaoService.getTotalPlantoes().subscribe(totalPlantoes => {
      this.totalPlantoes = 0;
      let i = setInterval(() => {
        this.totalPlantoes++;
        if (this.totalPlantoes == totalPlantoes)
          clearInterval(i);
      }, 25);
    });
  }
}
