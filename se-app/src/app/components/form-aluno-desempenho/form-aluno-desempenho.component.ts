import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-aluno-desempenho',
  templateUrl: './form-aluno-desempenho.component.html',
  styleUrls: ['./form-aluno-desempenho.component.scss']
})
export class FormAlunoDesempenhoComponent implements OnInit {

  ano!: number;
  serie!: number;
  turma!: string;
  turno!: string;
  materia!: string;

  turnos = [
    {valor: 0, texto: "Manhã"},
    {valor: 1, texto: "Tarde"},
    {valor: 2, texto: "Noite"},
  ];

  materias = [
    {valor: 0, texto: "Arte"},
    {valor: 1, texto: "Matemática"},
    {valor: 2, texto: "Português"},
  ]

  codigo!: number;
  nota!: number;
  falta!: number;

  desempenhoAlunoArray = new Array(1);

  adicionarDesempenhoAluno() {
    this.desempenhoAlunoArray.push(1);
  }

  removerDesempenhoAluno() {
    this.desempenhoAlunoArray.pop();
  }

  title = 'Desempenho do Aluno';

  constructor () {
  }

  ngOnInit(): void {}

}
