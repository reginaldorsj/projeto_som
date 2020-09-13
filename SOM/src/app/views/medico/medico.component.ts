import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { ConfirmationService, MessageService } from 'primeng/api';
import { UfService } from '../../Services/uf.service';
import { MedicoService } from '../../Services/medico.service';

import { Uf } from '../../Models/uf';
import { Medico } from '../../Models/medico';
import { EscalaMedico } from '../../Models/escala-medico';
import { EscalaMedicoService } from '../../Services/escala-medico.service';

@Component({
  selector: 'app-medico',
  templateUrl: './medico.component.html',
  styleUrls: ['./medico.component.css']
})
export class MedicoComponent implements OnInit {
  view = 'incluir';

  ufOptions = [];

  medico: Medico;
  nomeLocalizar: string;
  selectedMedico: Medico;

  medicos = [];

  escalas: EscalaMedico[];

  constructor(private router: Router, private confirmationService: ConfirmationService, private messageService: MessageService,
    private ufService: UfService, private medicoService: MedicoService, private escalaMedicoService: EscalaMedicoService) {

    this.ufService.listar().subscribe(ufs => {
      ufs.forEach((uf) => {
        this.ufOptions.push({ "label": uf.Sigla, "value": uf })
      })
    });

    this.incluir();
  }

  ngOnInit(): void {
  }

  limparTudo() {
    this.medico = new Medico();

  }

  incluir() {
    this.view = 'incluir';
    this.medico = new Medico();
  }

  localizar() {
    this.view = 'localizar';
    this.nomeLocalizar = undefined;
    this.medicos = [];
    this.selectedMedico = undefined;
  }

  voltar() {
    this.router.navigate(['ocorrencia']);
  }

  gravar() {
    if (this.medico.IdMedico == undefined) {
      this.medicoService.inserir(this.medico).subscribe(medico => {
        this.medico = medico;
        this.escalaMedicoService.listarPorMedico(this.medico).subscribe(escalas => {
          this.escalas = escalas;
          this.limparTudo();
          this.messageService.add({ key: 'tc', severity: 'success', summary: 'Parabéns', detail: 'Inclusão realizada com sucesso.' });
        });
      });
    } else {
      this.medicoService.alterar(this.medico).subscribe(medico => {
        this.medico = medico;
        this.escalaMedicoService.listarPorMedico(this.medico).subscribe(escalas => {
          this.escalas = escalas;
          this.limparTudo();
          this.messageService.add({ key: 'tc', severity: 'success', summary: 'Parabéns', detail: 'Alteração realizada com sucesso.' });
        });
      });
    }
  }

  excluir() {
    this.confirmationService.confirm({
      message: 'Confirma a exclusão desse registro?',
      accept: () => {
        this.medicoService.excluir(this.selectedMedico).subscribe(() => {
          this.localizar();
          this.messageService.add({ key: 'tc', severity: 'success', summary: 'Parabéns', detail: 'Exclusão realizada com sucesso.' });
        });
      }
    });
  }

  selectMedicoWithButton(medico: Medico) {
    this.incluir();
    this.medico = medico;
    this.escalaMedicoService.listarPorMedico(medico).subscribe(escalas => {
      this.escalas = escalas;
    });
  }

  pesquisarPorNome() {
    this.selectedMedico = undefined;
    this.medicos = [];
    this.medicoService.listarPorNome(this.nomeLocalizar).subscribe(medicos => {
      if (medicos.length == 0) {
        this.messageService.add({ key: 'tc', severity: 'warn', summary: 'Desculpe', detail: 'Nenhum médico encontrado.' });
      }
      else {
        this.medicos = medicos;
      }
    });
  }
}
