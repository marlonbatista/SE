import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';

@Component({
  selector: 'app-form-usuario',
  templateUrl: './form-usuario.component.html',
  styleUrls: ['./form-usuario.component.scss']
})
export class FormUsuarioComponent implements OnInit {

  usuarioForm!: FormGroup;

  acoes = [
    {valor: 0, texto: "Criar"},
    {valor: 1, texto: "Editar"},
    {valor: 2, texto: "Deletar"},
  ];

  tipos = [
    {valor: 0, texto: "Coordenador"},
    {valor: 1, texto: "Diretor"},
    {valor: 2, texto: "Secretário"},
  ];

  constructor(
    private formBuilder: FormBuilder,
    private informacaoService: InformacaoService,
  ) { }

  ngOnInit(): void {
    this.usuarioForm = this.formBuilder.group({
      acao: [0, [Validators.required]],
      codigo: [{ value: '', disabled: true }, [Validators.required]],
      nome: ['', [Validators.required]],
      sobrenome: ['', [Validators.required]],
      cpf: ['', [Validators.required]],
      rg: ['', [Validators.required]],
      email: ['', [Validators.required, Validators.email]],
      senha: ['', [Validators.required, Validators.minLength]],
      tipoUsuario: ['', [Validators.required]],
    });
  }

  liberaCodigo (acao: number) {
    if (acao == 0) {
      this.usuarioForm.controls['codigo'].setValue('');
      this.usuarioForm.controls['codigo'].disable();
    } else {
      this.usuarioForm.controls['codigo'].enable();
    }
  }

  onSubmit() {
    if(this.usuarioForm.invalid) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Preencha os campos obrigatórios', 'danger');
      return;
    }

    this.informacaoService.add('Tudo certo!', 'success');
    // this.informacaoService.remove();
    console.log(this.usuarioForm.value);
  }

  onReset () {
    window.location.href = "";
  }

}
