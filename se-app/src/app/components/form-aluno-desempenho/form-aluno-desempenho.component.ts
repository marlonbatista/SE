import { Component, OnInit } from '@angular/core';
// import { ViewportScroller } from '@angular/common';

@Component({
  selector: 'app-form-aluno-desempenho',
  templateUrl: './form-aluno-desempenho.component.html',
  styleUrls: ['./form-aluno-desempenho.component.scss']
})
export class FormAlunoDesempenhoComponent implements OnInit {

  ano!: number;
  serie!: number;
  turma!: string;
  periodo!: string;
  disciplina!: string;

  periodos = [
    {valor: 0, texto: "Manhã"},
    {valor: 1, texto: "Tarde"},
    {valor: 2, texto: "Noite"},
  ];

  disciplinas = [
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
    // this.viewportScroller.setOffset([0, 200]);
    // this.viewportScroller.scrollToAnchor( 'desempenho2'); 
  }

  removerDesempenhoAluno() {
    this.desempenhoAlunoArray.pop();
  }

  constructor( /*rivate viewportScroller: ViewportScroller*/) {}

  ngOnInit(): void {}

}
