import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ListagemPlantaoComponent } from './listagem-plantao.component';

describe('ListagemPlantaoComponent', () => {
  let component: ListagemPlantaoComponent;
  let fixture: ComponentFixture<ListagemPlantaoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ListagemPlantaoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ListagemPlantaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
