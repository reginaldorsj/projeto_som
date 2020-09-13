import { Component, OnInit } from '@angular/core';
import { AuthService } from '../Shared/auth.service';
import { LoggedinUser } from '../Shared/loggedin-user';
import { Router } from '@angular/router';
import { AppResponse } from '../Shared/app-response';

import { MessageService } from 'primeng/api';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  username: string;
  password: string;
  error: string;
  viewProgress: boolean;

  constructor(private authService: AuthService, private router: Router, private messageService: MessageService) { }

  ngOnInit(): void {
    this.viewProgress = false;
    this.authService.logout();
 }

  entrar(): void {
    this.error = null;
    this.viewProgress = true;
    this.authService.login(this.username, this.password)
      .subscribe((data: LoggedinUser) => {
        if (data.unidade != '') {
          this.messageService.add({ key: 'tc', severity: 'error', summary: 'Erro', detail: 'Dados inválidos. Tente outra vez.' });
          this.viewProgress = false;
          return;
        }

        this.authService.manageSession(data);
        this.authService.loginStatus.emit(true);

        if (this.authService.redirectUrl && this.authService.redirectUrl.toLowerCase() != '/carnaval/obito/login') {
          this.router.navigate([this.authService.redirectUrl]);
        } else {
          this.router.navigate(['obito/lista']);
        }
      }, (error: AppResponse) => {
          if (error.status === 400) {
            this.messageService.add({ key: 'tc', severity: 'error', summary: 'Erro', detail: 'Dados inválidos. Tente outra vez.' });
          }
        else
          this.error = error.message;
        this.viewProgress = false;
      });
  }
}
