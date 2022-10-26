import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-organizacional-serie',
  templateUrl: './form-organizacional-serie.component.html',
  styleUrls: ['./form-organizacional-serie.component.scss']
})
export class FormOrganizacionalSerieComponent implements OnInit {

  acao: number = 0;
  serie!: number;
  disciplina!: string;

  acoes = [
    {valor: 0, texto: "Criar"},
    {valor: 1, texto: "Editar"},
    {valor: 2, texto: "Deletar"},
  ];

  disciplinas = [
    {valor: 0, texto: "Arte"},
    {valor: 1, texto: "Matemática"},
    {valor: 2, texto: "Português"},
  ]

  constructor() { }

  ngOnInit(): void {
  }

}
