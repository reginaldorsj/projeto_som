import {Uf} from './uf';

export class Municipio {
	private _id_municipio: number;
	private _id_uf: Uf;
	private _descricao: string;
	private _codigo_ibge: string;

	public get IdMunicipio(): number {
		return this._id_municipio;
	}

	public set IdMunicipio(idMunicipio: number) {
		this._id_municipio = idMunicipio;
	}

	public get Uf(): Uf {
		return this._id_uf;
	}

	public set Uf(uf) {
		this._id_uf = uf;
	}

	public get Descricao(): string {
		return this._descricao;
	}

	public set Descricao(descricao: string) {
		this._descricao = descricao;
	}

	public get CodigoIbge(): string {
		return this._codigo_ibge;
	}

	public set CodigoIbge(codigoIbge: string) {
		this._codigo_ibge = codigoIbge;
	}

}
