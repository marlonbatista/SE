import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';

@Component({
  selector: 'app-form-organizacional-serie',
  templateUrl: './form-organizacional-serie.component.html',
  styleUrls: ['./form-organizacional-serie.component.scss']
})
export class FormOrganizacionalSerieComponent implements OnInit {

  serieOrganizacionalForm!: FormGroup;

  acoes = [
    {valor: 0, texto: "Criar"},
    {valor: 1, texto: "Editar"},
    {valor: 2, texto: "Deletar"},
  ];

  idisciplinas = [
    {valor: 0, texto: "Arte"},
    {valor: 1, texto: "Matemática"},
    {valor: 2, texto: "Português"},
  ]

  constructor(
    private formBuilder: FormBuilder,
    private informacaoService: InformacaoService,
  ) { }

  ngOnInit(): void {
    this.serieOrganizacionalForm = this.formBuilder.group({
      acao: [0, [Validators.required]],
      serie: ['', [Validators.required]],
      disciplinas: ['', [Validators.required]],
    });
  }

  disciplinas(): FormArray {
    return this.serieOrganizacionalForm.get('responsaveis') as FormArray;
  }

  criarDisciplina(): FormGroup {
    return this.formBuilder.group({
      disciplina: [''],
    });
  }

  onSubmit() {
    if(this.serieOrganizacionalForm.invalid) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Preencha os campos obrigatórios', 'danger');
      return;
    }

    this.informacaoService.add('Tudo certo!', 'success');
    // // this.informacaoService.remove();
    console.log(this.serieOrganizacionalForm.value);
  }

  onReset () {
    window.location.href = "";
  }

}
