import { Routes } from '@angular/router';

export const routes: Routes = [
	{
		path: '',
		title: 'Gondor Chic',
		loadComponent: () =>
			import('./login/login.component').then((m) => m.LoginComponent),
	},
	{
		path: '**',
		redirectTo: '',
	},
];