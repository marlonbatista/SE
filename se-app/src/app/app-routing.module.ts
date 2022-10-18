import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { InicioComponent } from './components/inicio/inicio.component';
import { FormLoginComponent } from './components/form-login/form-login.component';
import { FormAlunoRegistroComponent } from './components/form-aluno-registro/form-aluno-registro.component';

const routes: Routes = [
  { path: '', component: InicioComponent},
  { path: 'login', component: FormLoginComponent},
  { path: 'aluno-registro', component: FormAlunoRegistroComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
