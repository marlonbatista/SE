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
import { FormUsuarioComponent } from './components/form-usuario/form-usuario.component';
import { FormRelatorioAlunoComponent } from './components/form-relatorio-aluno/form-relatorio-aluno.component';
import { FormRelatorioTurmaComponent } from './components/form-relatorio-turma/form-relatorio-turma.component';
import { FormRelatorioSerieComponent } from './components/form-relatorio-serie/form-relatorio-serie.component';
import { FormRelatorioLivroComponent } from './components/form-relatorio-livro/form-relatorio-livro.component';
import { FormOrganizacionalSerieComponent } from './components/form-organizacional-serie/form-organizacional-serie.component';
import { FormOrganizacionalTurmaComponent } from './components/form-organizacional-turma/form-organizacional-turma.component';

const routes: Routes = [
  { path: '', component: InicioComponent, data: { titulo: 'Início' },},
  { path: 'login', component: FormLoginComponent, data: { titulo: 'Login' },},
  { path: 'usuario', component: FormUsuarioComponent, data: { titulo: 'Usuário' },},
  { path: 'perfil', component: PerfilComponent, data: {titulo: 'Perfil'},},
  { path: 'redefinir-senha', component: RedefinirSenhaComponent, data: { titulo: 'Redefinir Senha' },},
  { path: 'aluno-registro', component: FormAlunoRegistroComponent, data: { titulo: 'Registro do Aluno' },},
  { path: 'aluno-matricula', component: FormAlunoMatriculaComponent, data: {titulo: 'Matrícula do Aluno'},},
  { path: 'aluno-desempenho', component: FormAlunoDesempenhoComponent, data: {titulo: 'Desempenho do Aluno'},},
  { path: 'organizacional-serie', component: FormOrganizacionalSerieComponent, data: {titulo: 'Série'},},
  { path: 'organizacional-turma', component: FormOrganizacionalTurmaComponent, data: {titulo: 'Turma'},},
  { path: 'organizacional-disciplina', component: FormOrganizacionalDisciplinaComponent, data: {titulo: 'Disciplina'},},
  { path: 'relatorio-aluno', component: FormRelatorioAlunoComponent, data: {titulo: 'Relatório por Aluno'},},
  { path: 'relatorio-turma', component: FormRelatorioTurmaComponent, data: {titulo: 'Relatório por Turma'},},
  { path: 'relatorio-serie', component: FormRelatorioSerieComponent, data: {titulo: 'Relatório por Série'},},
  { path: 'relatorio-livro', component: FormRelatorioLivroComponent, data: {titulo: 'Relatório Livro de Notas'},},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
