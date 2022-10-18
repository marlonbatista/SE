import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-cabecalho',
  templateUrl: './cabecalho.component.html',
  styleUrls: ['./cabecalho.component.scss']
})
export class CabecalhoComponent implements OnInit {

  @Input() conected!: boolean;
  @Input() admin!: boolean;

  constructor() { }

  ngOnInit(): void {
  }

}
