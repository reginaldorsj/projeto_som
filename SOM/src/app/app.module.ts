import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule, LOCALE_ID } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { registerLocaleData } from '@angular/common';
import localePt from '@angular/common/locales/pt';

import { InputTextModule } from 'primeng/inputtext';
import { InputMaskModule } from 'primeng/inputmask';
import { ButtonModule } from 'primeng/button';
import { DropdownModule } from 'primeng/dropdown';
import { InputNumberModule } from 'primeng/inputnumber';
import { CalendarModule } from 'primeng/calendar';
import { AutoCompleteModule } from 'primeng/autocomplete';
import { RadioButtonModule } from 'primeng/radiobutton';
import { CheckboxModule } from 'primeng/checkbox';
import { TableModule } from 'primeng/table';
import { ConfirmDialogModule } from 'primeng/confirmdialog';
import { ToastModule } from 'primeng/toast';
import { CardModule } from 'primeng/card';
import { AppRoutingModule } from './app-routing.module';

import { ConfirmationService, MessageService } from 'primeng/api';
import { AuthGuard } from './Shared/auth-guard';
import { AuthService } from './Shared/auth.service';
import { TokenizedInterceptor } from './Shared/tokenized-interceptor';

import { LoginComponent } from './Views/login/login.component';
import { OcorrenciaComponent } from './Views/ocorrencia/ocorrencia.component';

import { AppComponent } from './app.component';
import { HeaderComponent } from './template/header/header.component';
import { FooterComponent } from './template/footer/footer.component';
import { ContentComponent } from './template/content/content.component';
import { UfMunicipioComponent } from './Components/uf-municipio/uf-municipio.component';
import { MedicoSearchComponent } from './Components/medico-search/medico-search.component';
import { MedicoComponent } from './Views/medico/medico.component';
import { EscalaMedicoComponent } from './Components/escala-medico/escala-medico.component';
import { NotFoundComponent } from './Views/not-found/not-found.component';

registerLocaleData(localePt);

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    LoginComponent,
    ContentComponent,
    OcorrenciaComponent,
    UfMunicipioComponent,
    MedicoSearchComponent,
    MedicoComponent,
    EscalaMedicoComponent,
    NotFoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule,
    BrowserAnimationsModule,

    InputTextModule,
    InputMaskModule,
    ButtonModule,
    DropdownModule,
    InputNumberModule,
    CalendarModule,
    AutoCompleteModule,
    RadioButtonModule,
    CheckboxModule,
    TableModule,
    ConfirmDialogModule,
    ToastModule,
    CardModule
  ],
  providers: [
    AuthGuard,
    AuthService,
    {
      provide: LOCALE_ID,
      useValue: 'pt-BR'
    }, {
      provide: HTTP_INTERCEPTORS,
      useClass: TokenizedInterceptor,
      multi: true,
    },
    ConfirmationService,
    MessageService
  ],
  bootstrap: [AppComponent]
})
export class AppModule {
}
