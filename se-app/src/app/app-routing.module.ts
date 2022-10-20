import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { InicioComponent } from './components/inicio/inicio.component';
import { FormLoginComponent } from './components/form-login/form-login.component';
import { FormAlunoRegistroComponent } from './components/form-aluno-registro/form-aluno-registro.component';
import { FormAlunoDesempenhoComponent } from './components/form-aluno-desempenho/form-aluno-desempenho.component';
import { FormAlunoMatriculaComponent } from './components/form-aluno-matricula/form-aluno-matricula.component';
import { PerfilComponent } from './components/perfil/perfil.component';

const routes: Routes = [
  { path: '', component: InicioComponent, data: { titulo: 'Início' },},
  { path: 'login', component: FormLoginComponent, data: { titulo: 'Login' },},
  { path: 'aluno-registro', component: FormAlunoRegistroComponent, data: { titulo: 'Registro do Aluno' },},
  { path: 'aluno-desempenho', component: FormAlunoDesempenhoComponent, data: {titulo: 'Desempenho do Aluno'},},
  { path: 'aluno-matricula', component: FormAlunoMatriculaComponent, data: {titulo: 'Matrícula do Aluno'}},
  { path: 'perfil', component: PerfilComponent, data: {titulo: 'Perfil'}},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
