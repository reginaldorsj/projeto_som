
export class PostoSaude {
	private _id_posto_saude: number;
	private _nome: string;
	private _ativo: boolean;

	public get IdPostoSaude(): number {
		return this._id_posto_saude;
	}

	public set IdPostoSaude(idPostoSaude: number) {
		this._id_posto_saude = idPostoSaude;
	}

	public get Nome(): string {
		return this._nome;
	}

	public set Nome(nome: string) {
		this._nome = nome;
	}

	public get Ativo(): boolean {
		return this._ativo;
	}

	public set Ativo(ativo: boolean) {
		this._ativo = ativo;
	}

}
