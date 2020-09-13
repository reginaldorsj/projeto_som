
export class TipoObito {
	private _id_tipo_obito: number;
	private _descricao: string;
	private _ativo: boolean;

	public get IdTipoObito(): number {
		return this._id_tipo_obito;
	}

	public set IdTipoObito(idTipoObito: number) {
		this._id_tipo_obito = idTipoObito;
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
