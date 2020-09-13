import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PlantaoComponent } from './plantao.component';

describe('PlantaoComponent', () => {
  let component: PlantaoComponent;
  let fixture: ComponentFixture<PlantaoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PlantaoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PlantaoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
