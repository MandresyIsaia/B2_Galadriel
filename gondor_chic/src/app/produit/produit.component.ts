import { Component, OnInit, signal } from '@angular/core';
import { ApiService } from '../services/api.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-produit',
  templateUrl: './produit.component.html',
  styleUrl: './produit.component.css',
  imports: [CommonModule]
})
export class ProduitComponent implements OnInit {

  produit = signal<any | null>(null);

  client: any;
  quantite = 1;
  loading = signal(true);

  constructor(private api: ApiService) {}

  ngOnInit(): void {

    this.client = JSON.parse(localStorage.getItem('client') || '{}');

    this.api.getHome(this.client.id).subscribe({
      next: (data) => {

        this.produit.set({
          nom: data.libelleProduit,
          prix: data.prix,
          stock: data.quantiteStock,
          image: data.imageLink,
          imageAlt: data.libelleProduit
        });

        this.loading.set(false);
      },
      error: (err) => {
        this.loading.set(false);
        console.error(err);
      }
    });
  }

  incrementer(): void {
    const p = this.produit();
    if (p && this.quantite < p.stock) this.quantite++;
  }

  decrementer(): void {
    if (this.quantite > 1) this.quantite--;
  }

  changerQuantite(valeur: string): void {
    const q = Number.parseInt(valeur, 10);
    const p = this.produit();

    if (!p) return;

    if (Number.isNaN(q) || q < 1) {
      this.quantite = 1;
      return;
    }

    this.quantite = Math.min(q, p.stock);
  }

  ajouterAuPanier(): void {
    console.log('AJOUT PANIER', {
      client: this.client.id,
      produit: this.produit(),
      quantite: this.quantite
    });
  }
}
