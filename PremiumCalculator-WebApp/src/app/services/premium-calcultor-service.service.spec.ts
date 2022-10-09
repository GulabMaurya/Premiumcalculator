import { TestBed } from '@angular/core/testing';

import { PremiumCalcultorServiceService } from './premium-calcultor-service.service';

describe('PremiumCalcultorServiceService', () => {
  let service: PremiumCalcultorServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(PremiumCalcultorServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
