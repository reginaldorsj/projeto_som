import { TestBed } from '@angular/core/testing';

import { CarnavalService } from './carnaval.service';

describe('CarnavalService', () => {
  let service: CarnavalService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CarnavalService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
