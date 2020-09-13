
export class Procedimento {
	private _id_procedimento: number;
	private _descricao: string;
	private _ativo: boolean;

	public get IdProcedimento(): number {
		return this._id_procedimento;
	}

	public set IdProcedimento(idProcedimento: number) {
		this._id_procedimento = idProcedimento;
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
