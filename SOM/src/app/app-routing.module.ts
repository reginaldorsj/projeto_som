import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

import { AuthGuard } from './Shared/auth-guard';

import { LoginComponent } from './Views/login/login.component';
import { OcorrenciaComponent } from './Views/ocorrencia/ocorrencia.component';
import { MedicoComponent } from './Views/medico/medico.component';
import { NotFoundComponent } from './Views/not-found/not-found.component';

const routes: Routes = [
  {
    path: "",
    redirectTo: "/login",
    pathMatch: "full"
  },
  {
    path: "login",
    component: LoginComponent
  },
  {
    path: "ocorrencia",
    component: OcorrenciaComponent,
    canActivate: [AuthGuard]
  },
  {
    path: "medico",
    component: MedicoComponent,
    canActivate: [AuthGuard]
  },
  {
    path: "page-not-found",
    component: NotFoundComponent
  }, 
  {
    path: "**",
    redirectTo: "/page-not-found",
    pathMatch: "full"
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
    scrollPositionRestoration: 'top'
  })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
