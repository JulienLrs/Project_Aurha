import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PageNotFoundComponent } from '../components/page-not-found/page-not-found.component';


const routes: Routes = [
  { path: '', redirectTo: 'artwork', pathMatch: 'full' }, // chemin Index
  { path: '**', component: PageNotFoundComponent }, // 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
