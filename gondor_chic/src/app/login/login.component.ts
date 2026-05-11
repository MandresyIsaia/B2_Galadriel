import { Component } from '@angular/core';

@Component({
  selector: 'app-login.component',
  imports: [],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
})
export class LoginComponent {onSubmit(event: Event, pseudo: string, password: string): void {
    event.preventDefault();

    console.log('[auth] tentative de connexion', {
      pseudo,
      passwordLength: password.length,
    });
  }
}



