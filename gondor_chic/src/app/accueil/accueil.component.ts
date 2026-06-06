import { Component } from '@angular/core';

@Component({
  selector: 'app-accueil.component',
  imports: [],
  templateUrl: './accueil.component.html',
  styleUrl: './accueil.component.css',
})
export class AccueilComponent {onSubmit(event: Event, pseudo: string, password: string): void {
    event.preventDefault();

    console.log('Inputs login', {
      pseudo,
      password,
    });
  }
}



