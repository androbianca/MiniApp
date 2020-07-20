import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LocationComponent } from './components/location/location.component';
import { SingerComponent } from './components/singer/singer.component';
import { ConcertComponent } from './components/concert/concert.component';
import { HomeComponent } from './components/home/home.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'singer', component: SingerComponent },
  { path: 'location', component: LocationComponent },
  { path: 'concert', component: ConcertComponent },

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
