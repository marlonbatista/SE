import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-navegacao',
  templateUrl: './navegacao.component.html',
  styleUrls: ['./navegacao.component.scss']
})
export class NavegacaoComponent implements OnInit {

  // userConected: boolean = true;
  // userAdmin: boolean = true;

  @Input() conected!: boolean;
  @Input() admin!: boolean;

  constructor() { }

  ngOnInit(): void {
  }

}
