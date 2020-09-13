
export class Causa {
	private _id_causa: number;
	private _descricao: string;
	private _ativo: boolean;

	public get IdCausa(): number {
		return this._id_causa;
	}

	public set IdCausa(idCausa: number) {
		this._id_causa = idCausa;
	}

	public get Descricao(): string {
		return this._descricao;
	}

	public set Descricao(descricao: string) {
		this._descricao = descricao;
	}

	public get Ativo(): boolean {
		return this._ativo;
	}

	public set Ativo(ativo: boolean) {
		this._ativo = ativo;
	}
}
