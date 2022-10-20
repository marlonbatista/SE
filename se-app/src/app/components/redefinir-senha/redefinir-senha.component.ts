import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-redefinir-senha',
  templateUrl: './redefinir-senha.component.html',
  styleUrls: ['./redefinir-senha.component.scss']
})
export class RedefinirSenhaComponent implements OnInit {

  email!: string;

  constructor() { }

  ngOnInit(): void {
  }

}
