
export class Doenca {
	private _id_doenca: number;
	private _descricao: string;
	private _ativo: boolean;

	public get IdDoenca(): number {
		return this._id_doenca;
	}

	public set IdDoenca(idDoenca: number) {
		this._id_doenca = idDoenca;
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
