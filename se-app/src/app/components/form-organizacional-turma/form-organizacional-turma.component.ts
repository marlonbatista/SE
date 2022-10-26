import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-organizacional-turma',
  templateUrl: './form-organizacional-turma.component.html',
  styleUrls: ['./form-organizacional-turma.component.scss']
})
export class FormOrganizacionalTurmaComponent implements OnInit {

  acao: number = 0;
  serie!: number;
  turma!: string;
  periodo!: string;
  
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
