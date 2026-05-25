import { Routes } from '@angular/router';

export const routes: Routes = [
	{
		path: '',
		title: 'Gondor Chic',
		loadComponent: () =>
			import('./login/login.component').then((m) => m.LoginComponent),
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
