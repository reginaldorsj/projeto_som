import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';

import { ConfirmationService, MessageService } from 'primeng/api';

import { DiaService } from '../../Services/dia.service';
import { SexoService } from '../../Services/sexo.service';
import { UfService } from '../../Services/uf.service';
import { MunicipioService } from '../../Services/municipio.service';
import { RacaService } from '../../Services/raca.service';
import { ProcedenciaService } from '../../Services/procedencia.service';
import { OrigemService } from '../../Services/origem.service';
import { CausaService } from '../../Services/causa.service';
import { DoencaService } from '../../Services/doenca.service';
import { PostoSaudeService } from '../../Services/posto-saude.service';
import { ProcedimentoService } from '../../Services/procedimento.service';
import { TipoObitoService } from '../../Services/tipo-obito.service';
import { MedicoService } from '../../Services/medico.service';
import { AtendimentoService } from '../../Services/atendimento.service';
import { DiagnosticoService } from '../../Services/diagnostico.service';

import { Atendimento } from '../../Models/atendimento';
import { Paciente } from '../../Models/paciente';
import { Municipio } from '../../Models/municipio';
import { Origem } from '../../Models/origem';
import { Causa } from '../../Models/causa';
import { Doenca } from '../../Models/doenca';
import { Procedimento } from '../../Models/procedimento';
import { TipoObito } from '../../Models/tipo-obito';
import { Medico } from '../../Models/medico';

@Component({
  selector: 'app-ocorrencia',
  templateUrl: './ocorrencia.component.html',
  styleUrls: ['./ocorrencia.component.css']
})
export class OcorrenciaComponent implements OnInit {

  view = 'incluir';
  viewSpin = false;

  diaOptions = [];
  sexoOptions = [];
  ufOptions = [];
  racaOptions = [];
  procedenciaOptions = [];
  postoSaudeOptions = [];
  origens: Origem[];
  causas: Causa[];
  procedimentos: Procedimento[];
  tipoObitoOptions = [];

  doencas: Doenca[];
  selectedDoencas: Doenca[];

  atendimento: Atendimento;

  nomeLocalizar: string;
  atendimentos = [];
  selectedAtendimento: Atendimento;

  constructor(private router: Router, private confirmationService: ConfirmationService, private messageService: MessageService,
    private ufService: UfService, private municipioService: MunicipioService, private racaService: RacaService,
    private procedenciaService: ProcedenciaService, private postoSaudeService: PostoSaudeService,
    private origemService: OrigemService, private causaService: CausaService, private doencaService: DoencaService,
    private procedimentoService: ProcedimentoService, private tipoObitoService: TipoObitoService,
    private medicoService: MedicoService, private atendimentoService: AtendimentoService,
    private diagnosticoService: DiagnosticoService, private diaService: DiaService, private sexoService: SexoService) {
  }

  ngOnInit(): void {
    this.diaService.listar().subscribe(dias => {
      dias.forEach((dia) => {
        this.diaOptions.push({ "label": dia.Data.toLocaleDateString("pt-BR"), "value": dia })
      })
    });

    this.postoSaudeService.listar().subscribe(postossaude => {
      postossaude.forEach((postosaude) => {
        this.postoSaudeOptions.push({ "label": postosaude.Nome, "value": postosaude })
      })
    });

    this.procedenciaService.listar().subscribe(procedencias => {
      procedencias.forEach((procedencia) => {
        this.procedenciaOptions.push({ "label": procedencia.Descricao, "value": procedencia })
      })
    });

    this.racaService.listar().subscribe(racas => {
      racas.forEach((raca) => {
        this.racaOptions.push({ "label": raca.Descricao, "value": raca })
      })
    });

    this.sexoService.listar().subscribe(sexos => {
      sexos.forEach((sexo) => {
        this.sexoOptions.push({ "label": sexo.Descricao, "value": sexo })
      })
    });

    this.ufService.listar().subscribe(ufs => {
      ufs.forEach((uf) => {
        this.ufOptions.push({ "label": uf.Sigla, "value": uf })
      })
    });

    this.origemService.listar().subscribe(origens => {
      this.origens = origens;
    });

    this.causaService.listar().subscribe(causas => {
      this.causas = causas;
    });

    this.doencaService.listar().subscribe(doencas => {
      this.doencas = doencas;
    });

    this.procedimentoService.listar().subscribe(procedimentos => {
      this.procedimentos = procedimentos;
    });

    this.tipoObitoService.listar().subscribe(tiposObito => {
      tiposObito.forEach((tipoObtio) => {
        this.tipoObitoOptions.push({ "label": tipoObtio.Descricao, "value": tipoObtio })
      })
    });

    this.limparTudo();
  }

  sair(): void {
    this.confirmationService.confirm({
      message: 'Deseja sair do sistema?',
      accept: () => {
        this.router.navigate(['login']);
      }
    });
  }

  incluir(): void {
    this.view = 'incluir';
    this.limparTudo();
  }

  localizar(): void {
    this.view = 'localizar';

    this.nomeLocalizar = undefined;
    this.atendimentos = [];
    this.selectedAtendimento = undefined;
  }

  recebeMunicipio(municipio: Municipio) {
    this.atendimento.Paciente.Municipio = municipio;
  }

  recebeMedico(medico: Medico) {
    this.atendimento.Medico = medico;
  }

  limpaCausaObito(tipoObito: TipoObito) {
    if (tipoObito == null)
      this.atendimento.EspecificarCausaObito = null;
  }
  limparPostoSaude(): void {
    if (this.atendimento.Procedencia == null || this.atendimento.Procedencia.IdProcedencia != 2)
      this.atendimento.PostoSaude = undefined;
  }

  limparTudo(): void {
    this.atendimento = new Atendimento();
    this.atendimento.Paciente = new Paciente();

    this.selectedDoencas = [];
  }

  gotoTop() {
    //window.scroll(0, 0);
    let scrollToTop = window.setInterval(() => {
      let pos = window.pageYOffset;
      if (pos > 0) {
        window.scrollTo(0, pos - 50); // how far to scroll on each step
      } else {
        window.clearInterval(scrollToTop);
      }
    }, 16);
  }

  novo(): void {
    this.confirmationService.confirm({
      message: 'Deseja limpar tudo e reiniciar a digitação?',
      accept: () => {
        this.limparTudo();
        this.gotoTop();
      }
    });
  }
  enviarDados() {
    this.viewSpin = true;
    if (this.atendimento.IdAtendimento == undefined) {
      this.atendimentoService.inserir(this.atendimento, this.selectedDoencas).subscribe(atendimento => {
        this.atendimento = atendimento;
        this.limparTudo();
        this.gotoTop();
        this.viewSpin = false;
        this.messageService.add({ key: 'tc', severity: 'success', summary: 'Parabéns', detail: 'Inclusão realizada com sucesso.' });        
      });
    } else {
      this.atendimentoService.alterar(this.atendimento, this.selectedDoencas).subscribe(atendimento => {
        this.atendimento = atendimento;
        this.limparTudo();
        this.gotoTop();
        this.viewSpin = false;
        this.messageService.add({ key: 'tc', severity: 'success', summary: 'Parabéns', detail: 'Alteração realizada com sucesso.' });
      });
    }
  }

  excluir() {
    this.confirmationService.confirm({
      message: 'Confirma a exclusão da ocorrência marcada?',
      accept: () => {
        this.atendimentoService.excluir(this.selectedAtendimento).subscribe(() => {
          this.localizar();
          this.gotoTop();
          this.messageService.add({ key: 'tc', severity: 'success', summary: 'Parabéns', detail: 'Exclusão realizada com sucesso.' });
        });
      }
    });
  }

  pesquisarPorNome() {
    this.selectedAtendimento = undefined;
    this.atendimentos = [];
    this.atendimentoService.listarPorNome(this.nomeLocalizar).subscribe(atendimentos => {
      if (atendimentos.length == 0) {
        this.messageService.add({ key: 'tc', severity: 'warn', summary: 'Desculpe', detail: 'Nenhuma ocorrência encontrada.' });
      }
      else {
        this.atendimentos = atendimentos;
      }
    });
  }

  selectAtendimentoWithButton(atendimento: Atendimento) {
    this.incluir();
    this.gotoTop();

    this.atendimento = atendimento;
    this.atendimento.Causa = this.causas.find(x => x.IdCausa == atendimento.Causa.IdCausa);
    this.atendimento.Origem = this.origens.find(x => x.IdOrigem == atendimento.Origem.IdOrigem);
    this.atendimento.Procedimento = this.procedimentos.find(x => x.IdProcedimento == atendimento.Procedimento.IdProcedimento);

    this.diagnosticoService.listarDoencas(atendimento).subscribe(doencasAtendimento => {
      let doencasTmp: Doenca[] = [];
      doencasAtendimento.forEach(y => {
        doencasTmp.push(this.doencas.find(x => x.IdDoenca === y.IdDoenca));
      });
      this.selectedDoencas = doencasTmp;
    });
  }
}
