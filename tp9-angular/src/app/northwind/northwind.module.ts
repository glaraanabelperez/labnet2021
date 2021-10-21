import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ServiceNorthwind } from './customers/services/northwind.service';
import { HttpClientModule} from '@angular/common/http';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AppComponentShippers } from './shippers/shippers.component';
import { AppComponentCustomers } from './customers/components/customers.component'
import { AppComponentCustomersForms } from './customers/components/customers-form/formCustomer.component'
import { AppComponentNorthwind } from './northwind.component';
import { ServiceInfoCustomers } from './customers/services/customers-info.service';

export const childrenRoute:Routes=[
    {path: 'customers', component: AppComponentCustomers},
    {path: 'shippers', component: AppComponentShippers},
]

const routes: Routes = [
  {path: 'northwind', component: AppComponentNorthwind, children: childrenRoute},
];


@NgModule({
  declarations: [
    AppComponentCustomers,
    AppComponentCustomersForms,
    AppComponentShippers,
    AppComponentNorthwind
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule.forRoot(routes),
    CommonModule,
  ],
  // schemas: [ 
  //   CUSTOM_ELEMENTS_SCHEMA, 
  // ],
  providers: [ HttpClientModule,ServiceNorthwind, ServiceInfoCustomers],

  bootstrap: []
  
})
export class AppNorthwindModule { }
