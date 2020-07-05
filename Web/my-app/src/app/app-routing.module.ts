import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LocationComponent } from './components/location/location.component';
import { SingerComponent } from './components/singer/singer.component';
import { ConcertComponent } from './components/concert/concert.component';

const routes: Routes = [
  { path: '', component: ConcertComponent },
  { path: 'singer', component: SingerComponent },
  { path: 'location', component: LocationComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
