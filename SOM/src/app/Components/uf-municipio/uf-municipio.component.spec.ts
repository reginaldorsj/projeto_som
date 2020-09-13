import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UfMunicipioComponent } from './uf-municipio.component';

describe('UfMunicipioComponent', () => {
  let component: UfMunicipioComponent;
  let fixture: ComponentFixture<UfMunicipioComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UfMunicipioComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UfMunicipioComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
