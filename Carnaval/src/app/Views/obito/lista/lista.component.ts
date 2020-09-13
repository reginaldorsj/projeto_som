import { Component, OnInit } from '@angular/core';

import { AtendimentoService } from '../../../Services/atendimento.service';
import { Atendimento } from '../../../Models/atendimento';

@Component({
  selector: 'app-lista',
  templateUrl: './lista.component.html',
  styleUrls: ['./lista.component.css']
})
export class ListaComponent implements OnInit {

  obitos: Atendimento[];

  constructor(private atendimentoService: AtendimentoService) { }

  ngOnInit(): void {
    this.listarObitos();

    let i = setInterval(() => {
      this.listarObitos();
    }, 1000 * 180);

  }

  listarObitos(): void {
    this.atendimentoService.listarObitos().subscribe(obitos => {
      this.obitos = obitos;
    });
  }
}
