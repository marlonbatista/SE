import { Component, OnInit } from '@angular/core';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';

@Component({
  selector: 'app-info-card',
  templateUrl: './info-card.component.html',
  styleUrls: ['./info-card.component.scss']
})
export class InfoCardComponent implements OnInit {
InformacaoService: any;

  constructor(public informacaoService: InformacaoService) { }

  ngOnInit(): void {
  }

}
