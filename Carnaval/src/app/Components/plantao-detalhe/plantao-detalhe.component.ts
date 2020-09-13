import { Component, OnInit } from '@angular/core';
import { DynamicDialogRef } from 'primeng/dynamicdialog';
import { DynamicDialogConfig } from 'primeng/dynamicdialog';

@Component({
  selector: 'app-plantao-detalhe',
  templateUrl: './plantao-detalhe.component.html',
  styleUrls: ['./plantao-detalhe.component.css']
})
export class PlantaoDetalheComponent implements OnInit {
  descricao: string;
  tipo: String;

  quadro;

  constructor(public ref: DynamicDialogRef, public config: DynamicDialogConfig) {
    this.descricao = this.config.data.Descricao;
    this.quadro = this.config.data.quadro;
  }

  ngOnInit(): void {
  }
}
