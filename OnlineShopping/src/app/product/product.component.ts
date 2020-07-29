import { Component, OnInit, Input } from '@angular/core';
import { ProductDetail } from './product-detail';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  @Input() public product: ProductDetail;
  constructor() { }

  ngOnInit(): void {
  }

}
