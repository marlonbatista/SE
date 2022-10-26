import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-relatorio-aluno',
  templateUrl: './form-relatorio-aluno.component.html',
  styleUrls: ['./form-relatorio-aluno.component.scss']
})
export class FormRelatorioAlunoComponent implements OnInit {

  codigo!: number;
  nome: string = "";
  sobrenome: string = "";
  serie!: number;
  turma!: number;

  series = [
    {valor: 0, texto: "1"},
    {valor: 1, texto: "2"},
    {valor: 2, texto: "3"},
  ];

  turmas = [
    {valor: 0, texto: "A"},
    {valor: 1, texto: "B"},
    {valor: 2, texto: "C"},
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
