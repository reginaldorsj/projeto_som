import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { AuthService } from '../../Shared/auth.service';
import { AppResponse } from '../../Shared/app-response';
import { LoggedinUser } from '../../Shared/loggedin-user';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  dataExtenso: string = new Date().toLocaleDateString("pt-BR");

  username: string;
  password: string;

  error: string;

  viewSpin: boolean;

  constructor(private authService: AuthService,
              private router: Router) {
  }

  ngOnInit(): void {
    this.viewSpin = false;
    this.authService.logout();
  }

  entrar(): void {
    this.error = null;
    this.viewSpin = true;
    this.authService.login(this.username, this.password)
      .subscribe((data: LoggedinUser) => {
        if (data.unidade == '') {
          this.error = "Dados inválidos. Tente outra vez.";
          this.viewSpin = false;
          return;
        }

        this.authService.manageSession(data);
        this.authService.loginStatus.emit(true);

        if (this.authService.redirectUrl && this.authService.redirectUrl.toLowerCase() != '/som/login') {
          this.router.navigate([this.authService.redirectUrl]);
        } else {
          this.router.navigate(['ocorrencia']);
        }
      }, (error: AppResponse) => {
        if (error.status === 400)
          this.error = "Dados inválidos. Tente outra vez.";
        else
          this.error = error.message;
        this.viewSpin = false;
      });
  }
}

