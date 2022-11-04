import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { Router } from '@angular/router';
import { AutenticacaoService } from 'src/app/services/autenticacao/autenticacao.service';

@Component({
  selector: 'app-form-login',
  templateUrl: './form-login.component.html',
  styleUrls: ['./form-login.component.scss']
})
export class FormLoginComponent implements OnInit {

  usuario!: string;
  senha!: string;

  constructor(
    // private formBuilder: FormBuilder,
    private aut: AutenticacaoService,
    private router: Router,
  ) { }

  ngOnInit(): void {
  }

  login() {
    this.aut.login(this.usuario, this.senha).subscribe(
      () => {
        this.router.navigate([''])
        alert('Logou!');
      },
      (error) => {
        alert('Usuário ou senha inválidos');
        console.log(error);
      }
    )
  }

}
