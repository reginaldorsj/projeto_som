
export class Carnaval {
	private _id_carnaval: number;
	private _ano: number;
	private _ativo: boolean;
	private _data_hora_encerramento: Date;

	public get IdCarnaval(): number {
		return this._id_carnaval;
	}

	public set IdCarnaval(idCarnaval: number) {
		this._id_carnaval = idCarnaval;
	}

	public get Ano(): number {
		return this._ano;
	}

	public set Ano(ano: number) {
		this._ano = ano;
	}

	public get Ativo(): boolean {
		return this._ativo;
	}

	public set Ativo(ativo: boolean) {
		this._ativo = ativo;
	}

	public get DataHoraEncerramento(): Date {
		return new Date(this._data_hora_encerramento);
	}

	public set DataHoraEncerramento(dataHoraEncerramento: Date) {
		this._data_hora_encerramento = dataHoraEncerramento;
	}

}
