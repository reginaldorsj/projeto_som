import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EscalaMedicoComponent } from './escala-medico.component';

describe('EscalaMedicoComponent', () => {
  let component: EscalaMedicoComponent;
  let fixture: ComponentFixture<EscalaMedicoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EscalaMedicoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EscalaMedicoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
