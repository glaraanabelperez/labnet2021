import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HttpClientModule} from '@angular/common/http';
import { ServiceMorty } from './services/service_morty.service';
import { AppComponentMorty } from './app.componenteMorty';


const routes: Routes = [
   {path: 'apiMorty', component: AppComponentMorty},
];


@NgModule({
  declarations: [
    AppComponentMorty,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    RouterModule.forRoot(routes),
    CommonModule,
  ],


  providers: [ HttpClientModule,ServiceMorty],

  bootstrap: []
  
})
export class AppMortyModule { }
