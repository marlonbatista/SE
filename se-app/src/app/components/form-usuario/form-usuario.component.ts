import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-usuario',
  templateUrl: './form-usuario.component.html',
  styleUrls: ['./form-usuario.component.scss']
})
export class FormUsuarioComponent implements OnInit {

  acao: number = 0;
  codigo!: number;
  nome: string = "";
  sobrenome: string = "";
  cpf: string = "";
  rg: string = "";
  email!: string;
  senha: string = "";
  tipo!: number;

  responsavelArray = new Array(1);

  acoes = [
    {valor: 0, texto: "Criar"},
    {valor: 1, texto: "Editar"},
    {valor: 2, texto: "Deletar"},
  ];

  tipos = [
    {valor: 0, texto: "Coordenador"},
    {valor: 1, texto: "Diretor"},
    {valor: 2, texto: "Secretário"},
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
