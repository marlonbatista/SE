import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-relatorio-serie',
  templateUrl: './form-relatorio-serie.component.html',
  styleUrls: ['./form-relatorio-serie.component.scss']
})
export class FormRelatorioSerieComponent implements OnInit {

  serie!: number;

  series = [
    {valor: 0, texto: "1"},
    {valor: 1, texto: "2"},
    {valor: 2, texto: "3"},
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
