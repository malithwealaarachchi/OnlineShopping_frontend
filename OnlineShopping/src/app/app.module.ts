import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsHomeComponent } from './products-home/products-home.component';
import { TopNavigationComponent } from './top-navigation/top-navigation.component';
import { SignComponent } from './sign/sign.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductsHomeComponent,
    TopNavigationComponent,
    SignComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
