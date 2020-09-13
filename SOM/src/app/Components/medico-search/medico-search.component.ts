import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

import { MedicoService } from '../../Services/medico.service';

import { Medico } from '../../Models/medico';
import { Uf } from '../../Models/uf';


@Component({
  selector: 'app-medico-search',
  templateUrl: './medico-search.component.html',
  styleUrls: ['./medico-search.component.css']
})
export class MedicoSearchComponent implements OnInit {

  @Input() ufOptions: [];
  @Input() cremeb: string;
  @Input() uf: Uf;
  @Input() nomeMedico: string;

  @Output() medico = new EventEmitter();

  constructor(private medicoService: MedicoService) {

  }

  ngOnInit(): void {
  }

  pesquisarMedico(cremeb: string, uf: Uf) {
    if (uf == null || cremeb == "") {
      alert("Informe o cremeb e a UF para pesquisar.");
      return;
    }
    let siglaUf: string = uf.Sigla;
    this.medicoService.selecionarPor(cremeb, siglaUf).subscribe(medico => {
      if (JSON.stringify(medico) != "{}") {
        this.nomeMedico = medico.Nome;

        this.medico.emit(medico);
      }
      else {
        this.nomeMedico = null;

        this.medico.emit();

        alert("Nenhum profissional encontrado com esses dados.");
      }
    });
  }

  limpar() {

    this.nomeMedico = null;
    this.cremeb = null;
    this.uf = null;

    this.medico.emit();
  }
}
