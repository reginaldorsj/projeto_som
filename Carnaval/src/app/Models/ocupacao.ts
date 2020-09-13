
export class Ocupacao {
	private _id_ocupacao: number;
	private _codigo: string;
	private _nome: string;

	public get IdOcupacao(): number {
		return this._id_ocupacao;
	}

	public set IdOcupacao(idOcupacao: number) {
		this._id_ocupacao = idOcupacao;
	}

	public get Codigo(): string {
		return this._codigo;
	}

	public set Codigo(codigo: string) {
		this._codigo = codigo;
	}

	public get Nome(): string {
		return this._nome;
	}

	public set Nome(nome: string) {
		this._nome = nome;
	}

}
