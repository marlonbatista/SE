import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-aluno-registro',
  templateUrl: './form-aluno-registro.component.html',
  styleUrls: ['./form-aluno-registro.component.scss']
})
export class FormAlunoRegistroComponent implements OnInit {
  
  acao: number = 0;
  codigo: number = 0;
  nome: string = "";
  sobrenome: string = "";
  dataNascimento!: Date;
  localNascimento: string = "";
  certidaoNascimento: string = "";
  cpf: string = "";
  rg: string = "";
  tipo: number = 0;

  responsavelArray = new Array(1);

  acoes = [
    {valor: 0, texto: "Criar"},
    {valor: 1, texto: "Editar"},
    {valor: 2, texto: "Deletar"},
  ]
  acaoSelecionada = this.acoes[0].valor;

  tipos = [
    {valor: 0, texto: "Pai"},
    {valor: 1, texto: "Mãe"},
    {valor: 2, texto: "Avô"},
    {valor: 3, texto: "Avó"},
    {valor: 4, texto: "Outro"},
  ]
  tipoSelecionado = this.tipos[0].valor;

  constructor() { }

  ngOnInit(): void {
  }

  addResponsavel() {
    this.responsavelArray.push(1);
  }

  removeResponsavel() {
    this.responsavelArray.pop();
  }
}
