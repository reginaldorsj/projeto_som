import { Component, OnInit } from '@angular/core';
import { DynamicDialogRef } from 'primeng/dynamicdialog';
import { DynamicDialogConfig } from 'primeng/dynamicdialog';

import { Plantao } from '../../Models/plantao';

@Component({
  selector: 'app-listagem-plantao',
  templateUrl: './listagem-plantao.component.html',
  styleUrls: ['./listagem-plantao.component.css']
})
export class ListagemPlantaoComponent implements OnInit {

  descricao: string;

  plantoes: Plantao[];

  rowGroupMetadata: any;

  constructor(public ref: DynamicDialogRef, public config: DynamicDialogConfig) {
    this.descricao = this.config.data.Descricao;
    this.plantoes = this.config.data.plantoes;

    this.updateRowGroupMetaData();
  }

  ngOnInit() {
  }

  updateRowGroupMetaData() {
    this.rowGroupMetadata = {};
    if (this.plantoes) {
      for (let i = 0; i < this.plantoes.length; i++) {
        let rowData = this.plantoes[i];
        let brand = rowData.Especialidade;
        if (i == 0) {
          this.rowGroupMetadata[brand] = { index: 0, size: 1 };
        }
        else {
          let previousRowData = this.plantoes[i - 1];
          let previousRowGroup = previousRowData.Especialidade;
          if (brand === previousRowGroup)
            this.rowGroupMetadata[brand].size++;
          else
            this.rowGroupMetadata[brand] = { index: i, size: 1 };
        }
      }
    }
  }
}
