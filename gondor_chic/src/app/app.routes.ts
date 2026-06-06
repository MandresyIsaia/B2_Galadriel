import { Routes } from '@angular/router';

export const routes: Routes = [
	{
		path: '',
		title: 'Gondor Chic',
		loadComponent: () =>
			import('./accueil/accueil.component').then((m) => m.AccueilComponent),
	},
	{
		path: 'produit',
		title: 'Produit du jour - Gondor Chic',
		loadComponent: () =>
			import('./produit/produit.component').then((m) => m.ProduitComponent),
	},
	{
		path: '**',
		redirectTo: '',
	},
];
