import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';

@Component({
  selector: 'app-form-aluno-matricula',
  templateUrl: './form-aluno-matricula.component.html',
  styleUrls: ['./form-aluno-matricula.component.scss']
})
export class FormAlunoMatriculaComponent implements OnInit {

  // acao!: number;
  // codigo!: number;
  // nome!: string;
  // sobrenome!: string;
  // ano!: number;
  // serie!: number;
  // turma!: number;
  // periodo!: number;

  matriculaAlunoForm!: FormGroup;

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
    this.matriculaAlunoForm = this.formBuilder.group({
      acao: [0, [Validators.required]],
      codigo: [{ value: '', disabled: true }, [Validators.required]],
      nome: ['', [Validators.required]],
      sobrenome: ['', [Validators.required]],
      ano: ['', [Validators.required]],
      serie: ['', [Validators.required]],
      turma: ['', [Validators.required]],
      periodo: ['', [Validators.required]],
    });
  }

  liberaCodigo (acao: number) {
    if (acao == 0) {
      this.matriculaAlunoForm.controls['codigo'].setValue('');
      this.matriculaAlunoForm.controls['codigo'].disable();
    } else {
      this.matriculaAlunoForm.controls['codigo'].enable();
    }
  }

  onSubmit() {
    if(this.matriculaAlunoForm.invalid) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Preencha os campos obrigatórios', 'danger');
      return;
    }

    this.informacaoService.add('Tudo certo!', 'success');
    // this.informacaoService.remove();
    console.log(this.matriculaAlunoForm.value);
  }

  onReset () {
    window.location.href = "";
  }

}
