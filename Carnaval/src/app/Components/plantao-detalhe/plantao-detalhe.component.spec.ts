import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PlantaoDetalheComponent } from './plantao-detalhe.component';

describe('PlantaoDetalheComponent', () => {
  let component: PlantaoDetalheComponent;
  let fixture: ComponentFixture<PlantaoDetalheComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PlantaoDetalheComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PlantaoDetalheComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
