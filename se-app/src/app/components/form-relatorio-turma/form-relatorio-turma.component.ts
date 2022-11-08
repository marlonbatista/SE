import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';

@Component({
  selector: 'app-form-relatorio-turma',
  templateUrl: './form-relatorio-turma.component.html',
  styleUrls: ['./form-relatorio-turma.component.scss']
})
export class FormRelatorioTurmaComponent implements OnInit {

  turmaRelatorioForm!: FormGroup;

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
    this.turmaRelatorioForm = this.formBuilder.group({
      serie: ['', [Validators.required]],
      turma: ['', [Validators.required]],
    });
  }

  onSubmit() {
    if(this.turmaRelatorioForm.invalid) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Preencha os campos obrigatórios', 'danger');
      return;
    }

    this.informacaoService.add('Tudo certo!', 'success');
    // this.informacaoService.remove();
    console.log(this.turmaRelatorioForm.value);
  }

  onReset () {
    window.location.href = "";
  }

}
