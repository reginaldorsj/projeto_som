import {Carnaval} from './carnaval';

export class Dia {
	private _id_dia: number;
	private _id_carnaval: Carnaval;
	private _data: Date;

	public get IdDia(): number {
		return this._id_dia;
	}

	public set IdDia(idDia: number) {
		this._id_dia = idDia;
	}

	public get Carnaval(): Carnaval {
		return this._id_carnaval;
	}

	public set Carnaval(carnaval) {
		this._id_carnaval = carnaval;
	}

	public get Data(): Date {
		return new Date(this._data);
	}

	public set Data(data: Date) {
		this._data = data;
	}

}
