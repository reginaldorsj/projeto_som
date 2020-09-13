import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { FormsModule } from '@angular/forms';

import { TableModule } from 'primeng/table';
import { SelectButtonModule } from 'primeng/selectbutton';
import { ChartModule } from 'primeng/chart';
import { DynamicDialogModule } from 'primeng/dynamicdialog';
import { CardModule } from 'primeng/card';
import { ButtonModule } from 'primeng/button';

import { ObitoModule } from './Views/obito/obito.module';

import { AppComponent } from './app.component';
import { ContentComponent } from './template/content/content.component';
import { OcorrenciaComponent } from './Views/ocorrencia/ocorrencia.component';
import { PlantaoComponent } from './Views/plantao/plantao.component';
import { ResumoComponent } from './Views/resumo/resumo.component';
import { QuadroDetalheComponent } from './Components/quadro-detalhe/quadro-detalhe.component';
import { PlantaoDetalheComponent } from './Components/plantao-detalhe/plantao-detalhe.component';
import { ListagemPlantaoComponent } from './Components/listagem-plantao/listagem-plantao.component';
import { NotFoundComponent } from './Views/not-found/not-found.component';

@NgModule({
  declarations: [
    AppComponent,
    ContentComponent,
    OcorrenciaComponent,
    PlantaoComponent,
    ResumoComponent,
    QuadroDetalheComponent,
    PlantaoDetalheComponent,
    ListagemPlantaoComponent,
    NotFoundComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    AppRoutingModule,
    TableModule,
    SelectButtonModule,
    FormsModule,
    ChartModule,
    DynamicDialogModule,
    CardModule,
    ButtonModule,
    ObitoModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
