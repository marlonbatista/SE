import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-inicio',
  templateUrl: './inicio.component.html',
  styleUrls: ['./inicio.component.scss']
})
export class InicioComponent implements OnInit {

  meses = [
     'janeiro' ,
     'fevereiro' ,
     'março' ,
     'abril' ,
     'maio' ,
     'junho' ,
     'julho' ,
     'agosto' ,
     'setembro' ,
     'outubro' ,
     'novembro' ,
     'dezembro' ,
  ];

  data: Date = new Date();
  dataFor: string = ((this.data.getDate() + " de " + this.meses[(this.data.getMonth())] + " de " + this.data.getFullYear()));

  constructor() { }

  ngOnInit(): void {
  }

}
