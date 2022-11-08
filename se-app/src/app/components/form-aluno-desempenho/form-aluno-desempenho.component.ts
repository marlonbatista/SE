import { Component, OnInit } from '@angular/core';
import { FormArray, FormBuilder, FormGroup, FormControl, Validators } from '@angular/forms';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';

@Component({
  selector: 'app-form-aluno-desempenho',
  templateUrl: './form-aluno-desempenho.component.html',
  styleUrls: ['./form-aluno-desempenho.component.scss']
})
export class FormAlunoDesempenhoComponent implements OnInit {

  desempenhoAlunoForm!: FormGroup;

  periodos = [
    {valor: 0, texto: "Manhã"},
    {valor: 1, texto: "Tarde"},
    {valor: 2, texto: "Noite"},
  ];

  disciplinas = [
    {valor: 0, texto: "Arte"},
    {valor: 1, texto: "Matemática"},
    {valor: 2, texto: "Português"},
  ];

  desempenhoAlunoArray = new Array(1);

  adicionarDesempenhoAluno() {
    this.desempenhoAlunoArray.push(1); 
  }

  removerDesempenhoAluno() {
    this.desempenhoAlunoArray.pop();
  }

  constructor(
    private formBuilder: FormBuilder,
    private informacaoService: InformacaoService,
  ) {}

  ngOnInit(): void {
    this.desempenhoAlunoForm = this.formBuilder.group({
      ano: ['', [Validators.required]],
      serie: ['', [Validators.required]],
      turma: ['', [Validators.required]],
      periodo: ['', [Validators.required]],
      disciplina: ['', [Validators.required]],
      alunos: this.formBuilder.array([]),
    });
  }

  alunos(): FormArray {
    return this.desempenhoAlunoForm.get('alunos') as FormArray;
  }

  criarAluno(): FormGroup {
    return this.formBuilder.group({
      codigo: [''],
      nota: [''],
      falta: [''],
    });
  }

  addAluno() {
    this.alunos().push(this.criarAluno());
  }
  removeAluno( alunIndex: number) {
    this.alunos().removeAt(alunIndex);
  }

  onSubmit() {
    if(this.desempenhoAlunoForm.invalid) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Preencha os campos obrigatórios', 'danger');
      return;
    }

    if (this.alunos().length < 1) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Insira no mínimo um aluno', 'danger');
      return;
    }

    this.informacaoService.add('Tudo certo!', 'success');
    // // this.informacaoService.remove();
    console.log(this.desempenhoAlunoForm.value);
  }

  onReset () {
    window.location.href = "";
  }
}
