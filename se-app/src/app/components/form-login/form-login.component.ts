import { Component, OnInit, Output } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AutenticacaoService } from 'src/app/services/autenticacao/autenticacao.service';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';

@Component({
  selector: 'app-form-login',
  templateUrl: './form-login.component.html',
  styleUrls: ['./form-login.component.scss']
})
export class FormLoginComponent implements OnInit {

  @Output() card!: boolean;

  usuario!: string;
  senha!: string;

  loginForm!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private aut: AutenticacaoService,
    private router: Router,
    private informacaoService: InformacaoService,
  ) { }

  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      usuario: ['', [Validators.required]],
      senha: ['', [Validators.required]],
    });
  }

  onSubmit() {
    if(this.loginForm.invalid) {
      return;
    }

    // console.log(this.loginForm.value);

    this.login();
  }

  login() {
    let usuario = this.loginForm.get('usuario')?.value;
    let senha = this.loginForm.get('senha')?.value;
    this.aut.login(usuario, senha).subscribe(
      () => {

        this.informacaoService.add('Sucesso!', 'success');
        this.router.navigate(['']);
        this.informacaoService.remove();
      },
      (error) => {
        this.informacaoService.add(error.error, 'danger');
        console.log(error);
      }
    )
  }

}
