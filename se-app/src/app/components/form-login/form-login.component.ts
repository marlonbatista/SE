import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-form-login',
  templateUrl: './form-login.component.html',
  styleUrls: ['./form-login.component.scss']
})
export class FormLoginComponent implements OnInit {

  usuario!: string;
  senha!: string;

  constructor() { }

  ngOnInit(): void {
  }

  logar() {
    
  }

}
