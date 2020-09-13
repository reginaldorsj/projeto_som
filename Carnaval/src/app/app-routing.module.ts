import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from './Views/obito/Shared/auth-guard';


import { PlantaoComponent } from './Views/plantao/plantao.component';
import { LoginComponent } from './Views/obito/login/login.component';
import { ListaComponent } from './Views/obito/lista/lista.component';
import { ResumoComponent } from './Views/resumo/resumo.component';
import { OcorrenciaComponent } from './Views/ocorrencia/ocorrencia.component';
import { NotFoundComponent } from './Views/not-found/not-found.component';


const routes: Routes = [
  {
    path: '',
    redirectTo: 'resumo',
    pathMatch: 'full'
  },
  {
    path: "resumo",
    component: ResumoComponent
  },
  {
    path: "ocorrencia",
    component: OcorrenciaComponent
  },
  {
    path: "plantao",
    component: PlantaoComponent
  },
  {
    path: "obito",
    children: [
      {
        path: '',
        redirectTo: 'login',
        pathMatch: 'full'
      },
      {
        path: "login",
        component: LoginComponent
      },
      {
        path: "lista",
        component: ListaComponent,
        canActivate: [AuthGuard]
      }
    ]
  },
  {
    path: "**",
    component: NotFoundComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
