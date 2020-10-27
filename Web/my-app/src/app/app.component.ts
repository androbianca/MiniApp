import { Component } from '@angular/core';
import { CustomRoutes } from '@centric/ng-styleguide';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  opened: boolean = true;
  isLoggedIn = false;
  menuItems: CustomRoutes = [
    {
      name: 'Concert',
      path: 'concert',
    },
    {
      name: 'Singer',
      path: 'singer',
    },
    {
      name: 'Location',
      path: 'location',
    },
    {
      name: 'Home',
      path: '',
    }
  ]

  toggleMenu(): void {
    this.opened = !this.opened;
  }

  onLoginEvent(event: any): void {
    this.isLoggedIn = event;
  }
}
