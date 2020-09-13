import {Dia} from './dia';
import {Unidade} from './unidade';
import {Procedencia} from './procedencia';
import {PostoSaude} from './posto-saude';
import {Origem} from './origem';
import {Paciente} from './paciente';
import {Medico} from './medico';
import {Causa} from './causa';
import {Procedimento} from './procedimento';
import {TipoObito} from './tipo-obito';

export class Atendimento {
	private _id_atendimento: number;
	private _id_dia: Dia;
	private _id_unidade: Unidade;
	private _id_procedencia: Procedencia;
	private _id_posto_saude: PostoSaude;
	private _id_origem: Origem;
	private _hora: string;
	private _prontuario: string;
	private _id_paciente: Paciente;
	private _id_medico: Medico;
	private _id_causa: Causa;
	private _id_procedimento: Procedimento;
	private _id_tipo_obito: TipoObito;
	private _especificar_causa_obito: string;

	public get IdAtendimento(): number {
		return this._id_atendimento;
	}

	public set IdAtendimento(idAtendimento: number) {
		this._id_atendimento = idAtendimento;
	}

	public get Dia(): Dia {
		return this._id_dia;
	}

	public set Dia(dia) {
		this._id_dia = dia;
	}

	public get Unidade(): Unidade {
		return this._id_unidade;
	}

	public set Unidade(unidade) {
		this._id_unidade = unidade;
	}

	public get Procedencia(): Procedencia {
		return this._id_procedencia;
	}

	public set Procedencia(procedencia) {
		this._id_procedencia = procedencia;
	}

	public get PostoSaude(): PostoSaude {
		return this._id_posto_saude;
	}

	public set PostoSaude(postoSaude) {
		this._id_posto_saude = postoSaude;
	}

	public get Origem(): Origem {
		return this._id_origem;
	}

	public set Origem(origem) {
		this._id_origem = origem;
	}

	public get Hora(): string {
		return this._hora;
	}

	public set Hora(hora: string) {
		this._hora = hora;
	}

	public get Prontuario(): string {
		return this._prontuario;
	}

	public set Prontuario(prontuario: string) {
		this._prontuario = prontuario;
	}

	public get Paciente(): Paciente {
		return this._id_paciente;
	}

	public set Paciente(paciente) {
		this._id_paciente = paciente;
	}

	public get Medico(): Medico {
		return this._id_medico;
	}

	public set Medico(medico) {
		this._id_medico = medico;
	}

	public get Causa(): Causa {
		return this._id_causa;
	}

	public set Causa(causa) {
		this._id_causa = causa;
	}

	public get Procedimento(): Procedimento {
		return this._id_procedimento;
	}

	public set Procedimento(procedimento) {
		this._id_procedimento = procedimento;
	}

	public get TipoObito(): TipoObito {
		return this._id_tipo_obito;
	}

	public set TipoObito(tipoObito) {
		this._id_tipo_obito = tipoObito;
	}

	public get EspecificarCausaObito(): string {
		return this._especificar_causa_obito;
	}

	public set EspecificarCausaObito(especificarCausaObito: string) {
		this._especificar_causa_obito = especificarCausaObito;
	}

}
