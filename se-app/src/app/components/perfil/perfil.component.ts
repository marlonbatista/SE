import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';

@Component({
  selector: 'app-perfil',
  templateUrl: './perfil.component.html',
  styleUrls: ['./perfil.component.scss']
})
export class PerfilComponent implements OnInit {

  perfilForm!: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private informacaoService: InformacaoService,
  ) { }

  ngOnInit(): void {
    this.perfilForm = this.formBuilder.group({
      nome: ['', [Validators.required]],
      sobrenome: ['', [Validators.required]],
      cpf: ['', [Validators.required]],
      rg: ['', [Validators.required]],
      email: ['', [Validators.required, Validators.email]],
      novaSenha: ['', [Validators.minLength]],
      ConfirNovaSenha: ['', [PerfilComponent.igualA('novaSenha')]],
      senhaAtual: ['', [Validators.required]],
    });
  }

  static igualA(outroCampo: string) {
    const validador = (formControl: FormControl) => {
      if (outroCampo == null) {
        throw new Error('É necessário informar um campo');
      }

      if (!formControl.root || !(<FormGroup>formControl.root).controls) {
        return null;
      }

      const campo = (<FormGroup>formControl.root).get(outroCampo);

      if (!campo) {
        throw new Error('É necessário informar um campo válido');
      }

      if (campo.value !== formControl.value) {
        return {igualA: outroCampo};
      }

      return null;
    };
    
    return validador;
  }

  onSubmit() {
    if(
        this.perfilForm.get('novaSenha')?.value !== '' && 
        this.perfilForm.get('novaSenha')?.value !== this.perfilForm.get('ConfirNovaSenha')?.value
      ) {
      this.perfilForm.controls['ConfirNovaSenha'].setErrors({'incorrect': true});
    }

    if(this.perfilForm.invalid) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Preencha os campos corretamente', 'danger');
      return;
    }

    this.informacaoService.add('Tudo certo!', 'success');
    // this.informacaoService.remove();
    console.log(this.perfilForm.value);
  }

  onReset () {
    window.location.href = "";
  }

}
