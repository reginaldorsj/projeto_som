import {Atendimento} from './atendimento';
import {Doenca} from './doenca';

export class Diagnostico {
	private _id_diagnostico: number;
	private _id_atendimento: Atendimento;
	private _id_doenca: Doenca;

	public get IdDiagnostico(): number {
		return this._id_diagnostico;
	}

	public set IdDiagnostico(idDiagnostico: number) {
		this._id_diagnostico = idDiagnostico;
	}

	public get Atendimento(): Atendimento {
		return this._id_atendimento;
	}

	public set Atendimento(atendimento) {
		this._id_atendimento = atendimento;
	}

	public get Doenca(): Doenca {
		return this._id_doenca;
	}

	public set Doenca(doenca) {
		this._id_doenca = doenca;
	}

}
