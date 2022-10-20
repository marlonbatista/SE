import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-aluno-matricula',
  templateUrl: './form-aluno-matricula.component.html',
  styleUrls: ['./form-aluno-matricula.component.scss']
})
export class FormAlunoMatriculaComponent implements OnInit {

  acao!: number;
  codigo!: number;
  nome!: string;
  sobrenome!: string;
  ano!: number;
  serie!: number;
  turma!: number;
  periodo!: number;

  acoes = [
    {valor: 0, texto: "Criar"},
    {valor: 1, texto: "Editar"},
    {valor: 2, texto: "Deletar"},
  ];

  periodos = [
    {valor: 0, texto: "Manhã"},
    {valor: 1, texto: "Tarde"},
    {valor: 2, texto: "Noite"},
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
