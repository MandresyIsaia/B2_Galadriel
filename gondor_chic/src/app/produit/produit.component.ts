import { Component } from '@angular/core';

@Component({
  selector: 'app-produit',
  imports: [],
  templateUrl: './produit.component.html',
  styleUrl: './produit.component.css',
})
export class ProduitComponent {
  readonly produit = {
    nom: "Pèlerine de Maillon d'Arsenic",
    prix: 50,
    stock: 10,
    image: '/assets/img/produit_jour.png',
    imageAlt: "Pèlerine de Maillon d'Arsenic",
  };

  quantite = 1;

  incrementer(): void {
    if (this.quantite < this.produit.stock) {
      this.quantite++;
    }
  }

  decrementer(): void {
    if (this.quantite > 1) {
      this.quantite--;
    }
  }

  changerQuantite(valeur: string): void {
    const quantite = Number.parseInt(valeur, 10);

    if (Number.isNaN(quantite) || quantite < 1) {
      this.quantite = 1;
      return;
    }

    this.quantite = Math.min(quantite, this.produit.stock);
  }

  ajouterAuPanier(): void {
    console.log('Produit ajouté au panier', {
      produit: this.produit.nom,
      quantite: this.quantite,
    });
  }
}
