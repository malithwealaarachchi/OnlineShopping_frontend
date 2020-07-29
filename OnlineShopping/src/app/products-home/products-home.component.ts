import { Component, OnInit } from '@angular/core';
import { ProductDetail } from '../product/product-detail';
import {ProductsHomeService} from './products-home.service';

@Component({
  selector: 'app-products-home',
  templateUrl: './products-home.component.html',
  styleUrls: ['./products-home.component.css']
})
export class ProductsHomeComponent implements OnInit {

  public products : ProductDetail[];
  constructor(private productsHomeService : ProductsHomeService) { }

  ngOnInit(): void {
    this.productsHomeService.getProducts().subscribe(products =>{
      this.products = products;
    });
  }

}
