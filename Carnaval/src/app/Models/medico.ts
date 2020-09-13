import {Uf} from './uf';

export class Medico {
	private _id_medico: number;
	private _cremeb: string;
	private _id_uf: Uf;
	private _nome: string;

	public get IdMedico(): number {
		return this._id_medico;
	}

	public set IdMedico(idMedico: number) {
		this._id_medico = idMedico;
	}

	public get Cremeb(): string {
		return this._cremeb;
	}

	public set Cremeb(cremeb: string) {
		this._cremeb = cremeb;
	}

	public get Uf(): Uf {
		return this._id_uf;
	}

	public set Uf(uf) {
		this._id_uf = uf;
	}

	public get Nome(): string {
		return this._nome;
	}

	public set Nome(nome: string) {
		this._nome = nome;
	}

}
