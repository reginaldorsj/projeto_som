import { TestBed } from '@angular/core/testing';

import { ProcedenciaService } from './procedencia.service';

describe('ProcedenciaService', () => {
  let service: ProcedenciaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProcedenciaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
