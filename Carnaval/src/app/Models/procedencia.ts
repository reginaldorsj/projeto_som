
export class Procedencia {
	private _id_procedencia: number;
	private _descricao: string;
	private _ativo: boolean;

	public get IdProcedencia(): number {
		return this._id_procedencia;
	}

	public set IdProcedencia(idProcedencia: number) {
		this._id_procedencia = idProcedencia;
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
