import { Component } from '@angular/core';

import { CommonService } from './Services/common.service';

import { Carnaval } from './Models/carnaval';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Carnaval';
  nowYear: number = new Date().getFullYear();

  carnaval: Carnaval;


  constructor(private commonService: CommonService, private router: Router) {
    this.commonService.getCarnaval().subscribe(carnaval => this.carnaval = carnaval);
  }
}
