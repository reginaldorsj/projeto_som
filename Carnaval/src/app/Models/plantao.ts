export class Plantao {

  private _especialidade: string;
  private _medico: string;
  private _cremeb: string;
  private _uf: string;
  private _dataHoraInicio: Date;
  private _dataHoraFim: Date;

  public get Especialidade(): string {
    return this._especialidade;
  }
  public set Especialidade(value: string) {
    this._especialidade = value;
  }
  public get Medico(): string {
    return this._medico;
  }
  public set Medico(value: string) {
    this._medico = value;
  }
  public get Cremeb(): string {
    return this._cremeb;
  }
  public set Cremeb(value: string) {
    this._cremeb = value;
  }
  public get Uf(): string {
    return this._uf;
  }
  public set Uf(value: string) {
    this._uf = value;
  }
  public get DataHoraInicio(): Date {
    return new Date(this._dataHoraInicio);
  }
  public set DataHoraInicio(value: Date) {
    this._dataHoraInicio = value;
  }
  public get DataHoraFim(): Date {
    return new Date(this._dataHoraFim);
  }
  public set DataHoraFim(value: Date) {
    this._dataHoraFim = value;
  }


}
