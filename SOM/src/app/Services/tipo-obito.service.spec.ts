import { TestBed } from '@angular/core/testing';

import { TipoObitoService } from './tipo-obito.service';

describe('TipoObitoService', () => {
  let service: TipoObitoService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(TipoObitoService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
