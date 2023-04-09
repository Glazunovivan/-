import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MainComponent } from './components/main/main.component';
import { StoreComponent } from './components/store/store.component';

const routes: Routes = [
  {path: '', component: MainComponent},
  {path: 'main', component: MainComponent},
  {path: 'store', component: StoreComponent},
  {path: 'store/:id', component: MainComponent},
  {path: 'products', component: MainComponent},
  {path: 'products/:id', component: MainComponent},
  {path: "**", redirectTo: "", component: MainComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
