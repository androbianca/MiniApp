import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { BrowserAnimationsModule } from "@angular/platform-browser/animations";
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { ReactiveFormsModule } from '@angular/forms';
import { CentricSidenavModule, CentricHeaderModule, CentricButtonModule, CentricLoginModule, CentricMatCheckboxComponent, CentricMatCheckboxModule, CentricFormModule, CentricMatInputComponent, CentricMatInputModule, CentricToastrModule } from '@centric/ng-styleguide';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SingerModule } from './components/singer/singer.module';
import { LocationModule } from './components/location/location.module';
import { ConcertModule } from './components/concert/concert.module';
import { HomeComponent } from './components/home/home.component';
import { LoginComponent } from './components/login/login.component';
import { NgxJwtModule } from 'ngx-jwt/lib/ngx-jwt.module';
import { NgxJwtConfig } from 'ngx-jwt/public-api';
import { of } from 'rxjs';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
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
    CentricButtonModule,
    CentricLoginModule,
    CentricMatCheckboxModule,
    CentricFormModule,
    CentricMatInputModule,
    CentricToastrModule.forRoot()
  ],
  providers: [HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }

export function createNgxJwtConfig(): NgxJwtConfig {
  return {
    tokenGetter: () => of('TOKEN'),
    blacklistedDomains: ['auth-service'],
    whitelistedDomains: [],
    throwNoTokenError: true,
    skipWhenExpired: false,
    headerName: 'Authorization',
    authScheme: 'Bearer'
  };
}