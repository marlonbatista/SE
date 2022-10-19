import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-rodape',
  templateUrl: './rodape.component.html',
  styleUrls: ['./rodape.component.scss']
})
export class RodapeComponent implements OnInit {

  // userConected: boolean = true;

  @Input() conected!: boolean;
  @Input() admin!: boolean;

  constructor() { }

  ngOnInit(): void {
  }

}
