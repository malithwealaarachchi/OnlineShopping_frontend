import { TestBed } from '@angular/core/testing';

import { ProductsHomeService } from './products-home.service';

describe('ProductsHomeService', () => {
  let service: ProductsHomeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ProductsHomeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
