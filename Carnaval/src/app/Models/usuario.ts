import {Unidade} from './unidade';

export class Usuario {
	private _id_usuario: number;
	private _id_unidade: Unidade;
	private _login: string;
	private _senha: string;
	private _ver_obitos: boolean;

	public get IdUsuario(): number {
		return this._id_usuario;
	}

	public set IdUsuario(idUsuario: number) {
		this._id_usuario = idUsuario;
	}

	public get Unidade(): Unidade {
		return this._id_unidade;
	}

	public set Unidade(unidade) {
		this._id_unidade = unidade;
	}

	public get Login(): string {
		return this._login;
	}

	public set Login(login: string) {
		this._login = login;
	}

	public get Senha(): string {
		return this._senha;
	}

	public set Senha(senha: string) {
		this._senha = senha;
	}

	public get VerObitos(): boolean {
		return this._ver_obitos;
	}

	public set VerObitos(verObitos: boolean) {
		this._ver_obitos = verObitos;
	}

}
