import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { ApiService } from '../services/api.service';

@Component({
  selector: 'app-login.component',
  templateUrl: './login.component.html',
  styleUrl: './login.component.css',
})
export class LoginComponent {

  constructor(
    private api: ApiService,
    private router: Router
  ) {}

  onSubmit(event: Event, pseudo: string, password: string): void {
    event.preventDefault();

    this.api.login({
      pseudo: pseudo,
      motDePasse: password
    }).subscribe({
      next: (user) => {

        // STOCKAGE USER
        localStorage.setItem('client', JSON.stringify(user));

        // REDIRECTION HOME
        this.router.navigate(['/produit']);
      },
      error: (err) => {
        console.error('Login error', err);
        alert('Pseudo ou mot de passe incorrect');
      }
    });
  }
}
