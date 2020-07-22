import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';

import { SingerModule } from './components/singer/singer.module';
import { LocationModule } from './components/location/location.module';
import { ConcertModule } from './components/concert/concert.module';
import {BrowserAnimationsModule} from "@angular/platform-browser/animations";
import { HomeComponent } from './components/home/home.component'
import { CentricSidenavModule, CentricHeaderModule } from '@centric/ng-styleguide';
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
    CentricHeaderModule
    
  ],
  providers: [HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
