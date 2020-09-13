export class Totalizacao {

  private _id: number;
  private _detalhe: string;
  private _quantidade: number;
  private _data: Date;
  private _cor: string

  public get Id(): number {
    return this._id;
  }
  public set Id(value: number) {
    this._id = value;
  }
  public get Cor(): string {
    return this._cor;
  }
  public set Cor(value: string) {
    this._cor = value;
  }
  public get Detalhe(): string {
    return this._detalhe;
  }
  public set Detalhe(value: string) {
    this._detalhe = value;
  }
  public get Data(): Date {
    return new Date(this._data);
  }
  public set Data(value: Date) {
    this._data = value;
  }
  public get Quantidade(): number {
    return this._quantidade;
  }
  public set Quantidade(value: number) {
    this._quantidade = value;
  }


}
