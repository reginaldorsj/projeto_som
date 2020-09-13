import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule, LOCALE_ID } from '@angular/core';
import { registerLocaleData } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import localePt from '@angular/common/locales/pt';

import { MessageService } from 'primeng/api';
import { ToastModule } from 'primeng/toast';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import { ProgressBarModule } from 'primeng/progressbar';
import { TableModule } from 'primeng/table';

import { ListaComponent } from './lista/lista.component';
import { LoginComponent } from './login/login.component';
import { AuthGuard } from './Shared/auth-guard';
import { AuthService } from './Shared/auth.service';
import { TokenizedInterceptor } from './Shared/tokenized-interceptor';

registerLocaleData(localePt);

@NgModule({
  declarations: [
    ListaComponent,
    LoginComponent
  ],
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    HttpClientModule,
    InputTextModule,
    FormsModule,
    ButtonModule,
    ProgressBarModule,
    ToastModule,
    TableModule
  ],
  exports: [
    ListaComponent,
    LoginComponent
  ],
  providers: [
    MessageService,
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
  ]
})
export class ObitoModule { }
