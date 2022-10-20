import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.scss']
})
export class PerfilComponent implements OnInit {

  nome!: string;
  sobrenome!: string;
  cpf!: string;
  rg!: string;
  email!: string;
  novaSenha!: string;
  confirmaSenha!: string;
  senhaAtual!: string;

  constructor() { }

  ngOnInit(): void {
  }

}
