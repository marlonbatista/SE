import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';

import {MatMenuModule} from '@angular/material/menu';
import {MatButtonModule} from '@angular/material/button';
import {MatButtonToggleModule} from '@angular/material/button-toggle';
import {MatDividerModule} from '@angular/material/divider';
import {MatListModule} from '@angular/material/list';
import {MatCardModule} from '@angular/material/card';
import {MatFormFieldModule} from '@angular/material/form-field';
import {MatInputModule} from '@angular/material/input';
import {MatSelectModule} from '@angular/material/select';
import {MatSlideToggleModule} from '@angular/material/slide-toggle';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CabecalhoComponent } from './components/cabecalho/cabecalho.component';
import { NavegacaoComponent } from './components/navegacao/navegacao.component';
import { RodapeComponent } from './components/rodape/rodape.component';
import { MainComponent } from './components/main/main.component';
import { InfoCardComponent } from './components/info-card/info-card.component';
import { FormLoginComponent } from './components/form-login/form-login.component';
import { InicioComponent } from './components/inicio/inicio.component';
import { FormAlunoRegistroComponent } from './components/form-aluno-registro/form-aluno-registro.component';
import { FormAlunoDesempenhoComponent } from './components/form-aluno-desempenho/form-aluno-desempenho.component';
import { FormAlunoMatriculaComponent } from './components/form-aluno-matricula/form-aluno-matricula.component';
import { PerfilComponent } from './components/perfil/perfil.component';
import { RedefinirSenhaComponent } from './components/redefinir-senha/redefinir-senha.component';
import { FormOrganizacionalDisciplinaComponent } from './components/form-organizacional-disciplina/form-organizacional-disciplina.component';

@NgModule({
  declarations: [
    AppComponent,
    CabecalhoComponent,
    NavegacaoComponent,
    RodapeComponent,
    MainComponent,
    InfoCardComponent,
    FormLoginComponent,
    InicioComponent,
    FormAlunoRegistroComponent,
    FormAlunoDesempenhoComponent,
    FormAlunoMatriculaComponent,
    PerfilComponent,
    RedefinirSenhaComponent,
    FormOrganizacionalDisciplinaComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatMenuModule,
    MatButtonModule,
    MatButtonToggleModule,
    MatDividerModule,
    MatListModule,
    MatCardModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatSlideToggleModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
