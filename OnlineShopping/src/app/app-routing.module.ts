import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {TopNavigationComponent} from 'src/app/top-navigation/top-navigation.component';
import {SignComponent} from 'src/app/sign/sign.component';

const routes: Routes = [
  {path:'sign', component:SignComponent}
];


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
