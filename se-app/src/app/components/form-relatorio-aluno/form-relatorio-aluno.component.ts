import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';

@Component({
  selector: 'app-form-relatorio-aluno',
  templateUrl: './form-relatorio-aluno.component.html',
  styleUrls: ['./form-relatorio-aluno.component.scss']
})
export class FormRelatorioAlunoComponent implements OnInit {

  alunoRelatorioForm!: FormGroup;

  series = [
    {valor: 0, texto: "1"},
    {valor: 1, texto: "2"},
    {valor: 2, texto: "3"},
  ];

  turmas = [
    {valor: 0, texto: "A"},
    {valor: 1, texto: "B"},
    {valor: 2, texto: "C"},
  ];

  constructor(
    private formBuilder: FormBuilder,
    private informacaoService: InformacaoService,
  ) { }

  ngOnInit(): void {
    this.alunoRelatorioForm = this.formBuilder.group({
      codigo: ['', [Validators.required]],
      nome: ['', [Validators.required]],
      sobrenome: ['', [Validators.required]],
      serie: ['', [Validators.required]],
      turma: ['', [Validators.required]],
    });
  }

  onSubmit() {
    if(this.alunoRelatorioForm.invalid) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Preencha os campos obrigatórios', 'danger');
      return;
    }

    this.informacaoService.add('Tudo certo!', 'success');
    // this.informacaoService.remove();
    console.log(this.alunoRelatorioForm.value);
  }

  onReset () {
    window.location.href = "";
  }

}
