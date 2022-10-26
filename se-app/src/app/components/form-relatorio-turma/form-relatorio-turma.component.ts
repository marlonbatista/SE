import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-relatorio-turma',
  templateUrl: './form-relatorio-turma.component.html',
  styleUrls: ['./form-relatorio-turma.component.scss']
})
export class FormRelatorioTurmaComponent implements OnInit {

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
