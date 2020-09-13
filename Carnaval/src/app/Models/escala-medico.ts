import {Unidade} from './unidade';
import {Ocupacao} from './ocupacao';
import {Medico} from './medico';

export class EscalaMedico {
	private _id_escala_medico: number;
	private _id_unidade: Unidade;
	private _id_ocupacao: Ocupacao;
	private _id_medico: Medico;
	private _data_hora_inicio: Date;
	private _data_hora_fim: Date;

	public get IdEscalaMedico(): number {
		return this._id_escala_medico;
	}

	public set IdEscalaMedico(idEscalaMedico: number) {
		this._id_escala_medico = idEscalaMedico;
	}

	public get Unidade(): Unidade {
		return this._id_unidade;
	}

	public set Unidade(unidade) {
		this._id_unidade = unidade;
	}

	public get Ocupacao(): Ocupacao {
		return this._id_ocupacao;
	}

	public set Ocupacao(ocupacao) {
		this._id_ocupacao = ocupacao;
	}

	public get Medico(): Medico {
		return this._id_medico;
	}

	public set Medico(medico) {
		this._id_medico = medico;
	}

	public get DataHoraInicio(): Date {
		return new Date(this._data_hora_inicio);
	}

	public set DataHoraInicio(dataHoraInicio: Date) {
		this._data_hora_inicio = dataHoraInicio;
	}

	public get DataHoraFim(): Date {
		return new Date(this._data_hora_fim);
	}

	public set DataHoraFim(dataHoraFim: Date) {
		this._data_hora_fim = dataHoraFim;
	}

}
