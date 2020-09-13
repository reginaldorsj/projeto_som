import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';

import { ConfirmationService, MessageService } from 'primeng/api';
import { OcupacaoService } from '../../Services/ocupacao.service';
import { DiaService } from '../../Services/dia.service';
import { EscalaMedicoService } from '../../Services/escala-medico.service';

import { Medico } from '../../Models/medico';
import { EscalaMedico } from '../../Models/escala-medico';
import { Dia } from '../../Models/dia';
import { Timestamp } from 'rxjs/internal/operators/timestamp';

@Component({
  selector: 'app-escala-medico',
  templateUrl: './escala-medico.component.html',
  styleUrls: ['./escala-medico.component.css']
})
export class EscalaMedicoComponent implements OnInit {

  view = 'listar';
  @Input() medico: Medico;
  @Input() escalas: EscalaMedico[];

  br: any;
  diaOptions = [];
  ocupacaoOptions = [];

  dataInicio: Dia;
  horaInicio: string;
  dataTermino: Dia;
  horaTermino: string;


  escalaMedico: EscalaMedico;
  selectedEscalas: EscalaMedico[];

  constructor(private router: Router, private confirmationService: ConfirmationService, private messageService: MessageService,
    private ocupacaoService: OcupacaoService, private diaService: DiaService, private escalaMedicoService: EscalaMedicoService) {

    this.ocupacaoService.listar().subscribe(ocupacoes => {
      ocupacoes.forEach(ocupacao => {
        this.ocupacaoOptions.push({ "label": ocupacao.Nome, "value": ocupacao });
      })
    });

    this.diaService.listar().subscribe(dias => {
      dias.forEach((dia) => {
        this.diaOptions.push({ "label": dia.Data.toLocaleDateString("pt-BR"), "value": dia })
      })
    });

    this.limparTudo();
  }

  limparTudo() {
    this.escalaMedico = new EscalaMedico();
    this.dataInicio = undefined;
    this.horaInicio = undefined;
    this.dataTermino = undefined;
    this.horaTermino = undefined;
    this.selectedEscalas = undefined;
  }

  ngOnInit(): void {
    this.br = {
      firstDayOfWeek: 0,
      dayNames: ["Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado"],
      dayNamesShort: ["Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab"],
      dayNamesMin: ["Do", "Se", "Te", "Qua", "Qui", "Se", "Sa"],
      monthNames: ["Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro"],
      monthNamesShort: ["Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"],
      today: 'Hoje',
      clear: 'Limpar',
      dateFormat: 'mm/dd/yy',
      weekHeader: 'SM'
    };

  }

  incluir() {
    this.view = "editar";
    this.limparTudo();
  }

  gravar() {
    this.escalaMedico.DataHoraInicio = new Date(this.dataInicio.Data.getFullYear(), this.dataInicio.Data.getMonth(), this.dataInicio.Data.getDate(),
      Number.parseInt(this.horaInicio.substring(0, 2)), Number.parseInt(this.horaInicio.substring(3, 5)), 0);
    this.escalaMedico.DataHoraFim = new Date(this.dataTermino.Data.getFullYear(), this.dataTermino.Data.getMonth(), this.dataTermino.Data.getDate(),
      Number.parseInt(this.horaTermino.substring(0, 2)), Number.parseInt(this.horaTermino.substring(3, 5)), 0);
    this.escalaMedico.Medico = this.medico;

    if (this.escalaMedico.IdEscalaMedico == undefined) {
      this.escalaMedicoService.inserir(this.escalaMedico).subscribe(escalaMedico => {
        this.escalaMedico = escalaMedico;
        this.escalaMedicoService.listarPorMedico(this.medico).subscribe(escalas => {
          this.escalas = escalas;
          this.limparTudo();
          this.messageService.add({ key: 'tc', severity: 'success', summary: 'Parabéns', detail: 'Inclusão realizada com sucesso.' });
        });
      });
    } else {
      this.escalaMedicoService.alterar(this.escalaMedico).subscribe(escalaMedico => {
        this.escalaMedico = escalaMedico;
        this.escalaMedicoService.listarPorMedico(this.medico).subscribe(escalas => {
          this.escalas = escalas;
          this.limparTudo();
          this.messageService.add({ key: 'tc', severity: 'success', summary: 'Parabéns', detail: 'Alteração realizada com sucesso.' });
        });
      });
    }
  }

  desistir() {
    this.view = "listar";
    this.limparTudo();
  }

  excluir() {
    this.confirmationService.confirm({
      message: 'Confirma a exclusão da(s) escala(s) marcada(s)?',
      accept: () => {
        this.escalaMedicoService.excluir(this.selectedEscalas).subscribe(() => {
          this.escalaMedicoService.listarPorMedico(this.medico).subscribe(escalas => {
            this.escalas = escalas;
            this.selectedEscalas = undefined;
            this.messageService.add({ key: 'tc', severity: 'success', summary: 'Parabéns', detail: 'Exclusão realizada com sucesso.' });
          });
        });
      }
    });
  }

  selectEscalaWithButton(escala: EscalaMedico) {
    this.incluir();
    this.escalaMedico = escala;

    this.dataInicio = this.diaOptions.find(d => d.label == escala.DataHoraInicio.toLocaleDateString('pt-BR')).value;
    this.dataTermino = this.diaOptions.find(d => d.label == escala.DataHoraFim.toLocaleDateString('pt-BR')).value;

    this.horaInicio = escala.DataHoraInicio.toLocaleTimeString("pt-BR").substring(0, 5);
    this.horaTermino = escala.DataHoraFim.toLocaleTimeString("pt-BR").substring(0, 5);
  }
}
