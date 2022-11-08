import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';

@Component({
  selector: 'app-form-organizacional-turma',
  templateUrl: './form-organizacional-turma.component.html',
  styleUrls: ['./form-organizacional-turma.component.scss']
})
export class FormOrganizacionalTurmaComponent implements OnInit {

  turmaOrganizacionalForm!: FormGroup;
  
  acoes = [
    {valor: 0, texto: "Criar"},
    {valor: 1, texto: "Editar"},
    {valor: 2, texto: "Deletar"},
  ];

  periodos = [
    {valor: 0, texto: "Manhã"},
    {valor: 1, texto: "Tarde"},
    {valor: 2, texto: "Noite"},
  ];
  constructor(
    private formBuilder: FormBuilder,
    private informacaoService: InformacaoService,
  ) { }

  ngOnInit(): void {
    this.turmaOrganizacionalForm = this.formBuilder.group({
      acao: [0, [Validators.required]],
      serie: ['', [Validators.required]],
      turma: ['', [Validators.required]],
      periodo: ['', [Validators.required]],
    });
  }

  onSubmit() {
    if(this.turmaOrganizacionalForm.invalid) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Preencha os campos obrigatórios', 'danger');
      return;
    }

    this.informacaoService.add('Tudo certo!', 'success');
    // this.informacaoService.remove();
    console.log(this.turmaOrganizacionalForm.value);
  }

  onReset () {
    window.location.href = "";
  }

}
