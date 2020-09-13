
export class Unidade {
	private _id_unidade: number;
	private _nome: string;
	private _sigla: string;
	private _cor: string;
	private _ativo: boolean;

	public get IdUnidade(): number {
		return this._id_unidade;
	}

	public set IdUnidade(idUnidade: number) {
		this._id_unidade = idUnidade;
	}

	public get Nome(): string {
		return this._nome;
	}

	public set Nome(nome: string) {
		this._nome = nome;
	}

	public get Sigla(): string {
		return this._sigla;
	}

	public set Sigla(sigla: string) {
		this._sigla = sigla;
	}

	public get Cor(): string {
		return this._cor;
	}

	public set Cor(cor: string) {
		this._cor = cor;
	}

	public get Ativo(): boolean {
		return this._ativo;
	}

	public set Ativo(ativo: boolean) {
		this._ativo = ativo;
	}

}
