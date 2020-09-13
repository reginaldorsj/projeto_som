import { Injectable } from '@angular/core';

import { Atendimento } from './atendimento';
import { Carnaval } from './carnaval';
import { Causa } from './causa';
import { Dia } from './dia';
import { Diagnostico } from './diagnostico';
import { Doenca } from './doenca';
import { EscalaMedico } from './escala-medico';
import { Medico } from './medico';
import { Municipio } from './municipio';
import { Ocupacao } from './ocupacao';
import { Origem } from './origem';
import { Paciente } from './paciente';
import { PostoSaude } from './posto-saude';
import { Procedencia } from './procedencia';
import { Procedimento } from './procedimento';
import { Raca } from './raca';
import { Sexo } from './sexo';
import { TipoObito } from './tipo-obito';
import { Uf } from './uf';
import { Unidade } from './unidade';
import { Usuario } from './usuario';

@Injectable({
  providedIn: 'root'
})
export class ModelService {

  private classes = {
    Atendimento,
    Carnaval,
    Causa,
    Dia,
    Diagnostico,
    Doenca,
    EscalaMedico,
    Medico,
    Municipio,
    Ocupacao,
    Origem,
    Paciente,
    PostoSaude,
    Procedencia,
    Procedimento,
    Raca,
    Sexo,
    TipoObito,
    Uf,
    Unidade,
    Usuario
  };

  constructor() { }

  deepCopy(sourceObject, destinationObject) {
    for (const key in sourceObject) {
      if (typeof sourceObject[key] != 'object') {
        destinationObject[key] = sourceObject[key];
      } else if (sourceObject[key] != null && sourceObject[key] != undefined) {
        let keys: string[] = Object.keys(sourceObject[key]);
        destinationObject[key] = this.get(keys[0]);
        this.deepCopy(sourceObject[key], destinationObject[key]);
      }
    }
  }

  protected get(_id_classe: string): any {
    let classe: string = this.getClassName(_id_classe);
    return new this.classes[classe];
  }

  protected getClassName(idProperty: string): string {

    let ret: string = '';
    let i: number = 3;
    while (i < idProperty.length) {
      if (idProperty[i] == '_') {
        ret = ret + idProperty[i + 1].toUpperCase();
        i++;
      }
      else {
        ret = ret + idProperty[i];
      }
      i++;
    }
    return ret;
  }
}

