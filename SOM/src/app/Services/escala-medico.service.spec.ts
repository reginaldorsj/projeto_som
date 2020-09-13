import { TestBed } from '@angular/core/testing';

import { EscalaMedicoService } from './escala-medico.service';

describe('EscalaMedicoService', () => {
  let service: EscalaMedicoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EscalaMedicoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
