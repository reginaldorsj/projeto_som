import {Municipio} from './municipio';
import {Raca} from './raca';
import {Sexo} from './sexo';

export class Paciente {
	private _id_paciente: number;
	private _nome: string;
	private _endereco: string;
	private _bairro: string;
	private _id_municipio: Municipio;
	private _id_raca: Raca;
	private _id_sexo: Sexo;
	private _idade: number;
	private _telefone: string;

	public get IdPaciente(): number {
		return this._id_paciente;
	}

	public set IdPaciente(idPaciente: number) {
		this._id_paciente = idPaciente;
	}

	public get Nome(): string {
		return this._nome;
	}

	public set Nome(nome: string) {
		this._nome = nome;
	}

	public get Endereco(): string {
		return this._endereco;
	}

	public set Endereco(endereco: string) {
		this._endereco = endereco;
	}

	public get Bairro(): string {
		return this._bairro;
	}

	public set Bairro(bairro: string) {
		this._bairro = bairro;
	}

	public get Municipio(): Municipio {
		return this._id_municipio;
	}

	public set Municipio(municipio) {
		this._id_municipio = municipio;
	}

	public get Raca(): Raca {
		return this._id_raca;
	}

	public set Raca(raca) {
		this._id_raca = raca;
	}

	public get Sexo(): Sexo {
		return this._id_sexo;
	}

	public set Sexo(sexo) {
		this._id_sexo = sexo;
	}

	public get Idade(): number {
		return this._idade;
	}

	public set Idade(idade: number) {
		this._idade = idade;
	}

	public get Telefone(): string {
		return this._telefone;
	}

	public set Telefone(telefone: string) {
		this._telefone = telefone;
	}

}
