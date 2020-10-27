import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent {

  @Output() onLogin = new EventEmitter<any>();
  loginFormGroup: FormGroup;

  constructor() {
    this.loginFormGroup = new FormGroup({
      username: new FormControl(),
      password: new FormControl(),
      rememberMe: new FormControl()
    });
  }

  onSubmit(): void {
    this.onLogin.emit(true);
    console.log('Submitted');
  }

}
