
export class Origem {
	private _id_origem: number;
	private _descricao: string;
	private _ativo: boolean;

	public get IdOrigem(): number {
		return this._id_origem;
	}

	public set IdOrigem(idOrigem: number) {
		this._id_origem = idOrigem;
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
