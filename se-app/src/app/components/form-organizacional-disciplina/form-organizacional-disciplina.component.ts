import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-organizacional-disciplina',
  templateUrl: './form-organizacional-disciplina.component.html',
  styleUrls: ['./form-organizacional-disciplina.component.scss']
})
export class FormOrganizacionalDisciplinaComponent implements OnInit {

  acao: number = 0;
  codigo!: number;
  nome!: string;
  cargaHoraria!: string;

  acoes = [
    {valor: 0, texto: "Criar"},
    {valor: 1, texto: "Editar"},
    {valor: 2, texto: "Deletar"},
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
