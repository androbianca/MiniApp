import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { CentricSidenavModule, CentricHeaderModule, CentricButtonModule } from '@centric/ng-styleguide';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SingerModule } from './components/singer/singer.module';
import { LocationModule } from './components/location/location.module';
import { ConcertModule } from './components/concert/concert.module';
import { HomeComponent } from './components/home/home.component'
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
  ],
  imports: [BrowserAnimationsModule,
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule,
    ConcertModule,
    LocationModule,
    SingerModule,
    CentricSidenavModule,
    CentricHeaderModule,
    CentricButtonModule
    
  ],
  providers: [HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
