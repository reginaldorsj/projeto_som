import { Atendimento } from './atendimento';
import { Doenca } from './doenca';

export class Ocorrencia {
  private _atendimento: Atendimento;

  public get Atendimento(): Atendimento {
    return this._atendimento;
  }

  public set Atendimento(value: Atendimento) {
    this._atendimento = value;
  }

  private _doencas: Doenca[];

  public get Doencas(): Doenca[] {
    return this._doencas;
  }

  public set Doencas(value: Doenca[]) {
    this._doencas = value;
  }


}
