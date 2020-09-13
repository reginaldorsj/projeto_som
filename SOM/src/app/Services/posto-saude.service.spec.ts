import { TestBed } from '@angular/core/testing';

import { PostoSaudeService } from './posto-saude.service';

describe('PostoSaudeService', () => {
  let service: PostoSaudeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PostoSaudeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
