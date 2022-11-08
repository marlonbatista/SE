import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';

@Component({
  selector: 'app-form-organizacional-disciplina',
  templateUrl: './form-organizacional-disciplina.component.html',
  styleUrls: ['./form-organizacional-disciplina.component.scss']
})
export class FormOrganizacionalDisciplinaComponent implements OnInit {

  disciplinaOrganizacionalForm!: FormGroup;

  acoes = [
    {valor: 0, texto: "Criar"},
    {valor: 1, texto: "Editar"},
    {valor: 2, texto: "Deletar"},
  ];

  constructor(
    private formBuilder: FormBuilder,
    private informacaoService: InformacaoService,
  ) { }

  ngOnInit(): void {
    this.disciplinaOrganizacionalForm = this.formBuilder.group({
      acao: [0, [Validators.required]],
      codigo: ['', [Validators.required]],
      nome: ['', [Validators.required]],
      cargaHoraria: ['', [Validators.required]],
    });
  }

  onSubmit() {
    if(this.disciplinaOrganizacionalForm.invalid) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Preencha os campos obrigatórios', 'danger');
      return;
    }

    this.informacaoService.add('Tudo certo!', 'success');
    // this.informacaoService.remove();
    console.log(this.disciplinaOrganizacionalForm.value);
  }

  onReset () {
    window.location.href = "";
  }

}
