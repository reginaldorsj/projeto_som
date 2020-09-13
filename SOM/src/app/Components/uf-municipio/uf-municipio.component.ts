import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';

import { MunicipioService } from '../../Services/municipio.service';
import { UfService } from '../../Services/uf.service';

import { Municipio } from '../../Models/municipio';
import { Uf } from '../../Models/uf';
import { JsonpClientBackend } from '@angular/common/http';

@Component({
  selector: 'app-uf-municipio',
  templateUrl: './uf-municipio.component.html',
  styleUrls: ['./uf-municipio.component.css']
})
export class UfMunicipioComponent implements OnInit {

  @Input() ufOptions: [];
  @Input() selectedUf: Uf;
  @Input() municipio: Municipio;

  @Output() municipioSelected = new EventEmitter();

  resultsMunicipios: Municipio[];

  constructor(private municipioService: MunicipioService, private ufService: UfService) {

  }

  ngOnInit(): void {
  }

  limpaMunicipioSeUfNull(uf: Uf) {
    if (uf == null) {
      this.municipio = null;
    }
  }

  loadMunicipioPorNome(event) {
    this.municipioService.listarPorNome(this.selectedUf, event.query.toUpperCase()).subscribe(municipios => {
      this.resultsMunicipios = municipios;
    });
  }

  enviarMunicipio() {
    this.municipioSelected.emit(this.municipio)
  }
}
