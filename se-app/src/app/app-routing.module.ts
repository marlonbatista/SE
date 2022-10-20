import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { InicioComponent } from './components/inicio/inicio.component';
import { FormLoginComponent } from './components/form-login/form-login.component';
import { FormAlunoRegistroComponent } from './components/form-aluno-registro/form-aluno-registro.component';
import { FormAlunoDesempenhoComponent } from './components/form-aluno-desempenho/form-aluno-desempenho.component';
import { RedefinirSenhaComponent } from './components/redefinir-senha/redefinir-senha.component';
import { FormAlunoMatriculaComponent } from './components/form-aluno-matricula/form-aluno-matricula.component';
import { PerfilComponent } from './components/perfil/perfil.component';
import { FormOrganizacionalDisciplinaComponent } from './components/form-organizacional-disciplina/form-organizacional-disciplina.component';

const routes: Routes = [
  { path: '', component: InicioComponent, data: { titulo: 'Início' },},
  { path: 'login', component: FormLoginComponent, data: { titulo: 'Login' },},
  { path: 'perfil', component: PerfilComponent, data: {titulo: 'Perfil'},},
  { path: 'redefinir-senha', component: RedefinirSenhaComponent, data: { titulo: 'Redefinir Senha' },},
  { path: 'aluno-registro', component: FormAlunoRegistroComponent, data: { titulo: 'Registro do Aluno' },},
  { path: 'aluno-matricula', component: FormAlunoMatriculaComponent, data: {titulo: 'Matrícula do Aluno'},},
  { path: 'aluno-desempenho', component: FormAlunoDesempenhoComponent, data: {titulo: 'Desempenho do Aluno'},},
  { path: 'organizacional-disciplina', component: FormOrganizacionalDisciplinaComponent, data: {titulo: 'Disciplina'},},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
