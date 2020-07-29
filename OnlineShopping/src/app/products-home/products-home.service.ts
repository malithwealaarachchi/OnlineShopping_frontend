import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import {ProductDetail} from '../product/product-detail';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ProductsHomeService {

  private url : string = 'https://localhost:44302/api/Products/GetProducts';
  constructor(private http: HttpClient) { }

  getProducts():Observable<ProductDetail[]>{
    var result =  this.http.get<ProductDetail[]>(this.url);
    return result;
  }
}
