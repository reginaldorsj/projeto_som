import { Component, OnInit } from '@angular/core';
import { DynamicDialogRef } from 'primeng/dynamicdialog';
import { DynamicDialogConfig } from 'primeng/dynamicdialog';

import { Dia } from '../../Models/dia';

@Component({
  selector: 'app-quadro-detalhe',
  templateUrl: './quadro-detalhe.component.html',
  styleUrls: ['./quadro-detalhe.component.css']
})
export class QuadroDetalheComponent implements OnInit {
  descricao: string;
  tipo: String;

  dias: Dia[];
  quadro;

  constructor(public ref: DynamicDialogRef, public config: DynamicDialogConfig) {
    this.dias = this.config.data.dias;
    this.descricao = this.config.data.Descricao;
    this.quadro = this.config.data.quadro;
  }

  ngOnInit(): void {
  }
}
