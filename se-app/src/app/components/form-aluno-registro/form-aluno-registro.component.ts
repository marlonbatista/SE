import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, Validators } from '@angular/forms';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';
import { iRegistroAluno } from './iRegistroAluno';

@Component({
  selector: 'app-form-aluno-registro',
  templateUrl: './form-aluno-registro.component.html',
  styleUrls: ['./form-aluno-registro.component.scss']
})
export class FormAlunoRegistroComponent implements OnInit {

  registroAlunoForm!: FormGroup;
  nContratantes: number = 0;

  acoes = [
    {valor: 0, texto: "Criar"},
    {valor: 1, texto: "Editar"},
    {valor: 2, texto: "Deletar"},
  ];
  acaoSelecionada = this.acoes[0].valor;

  tipos = [
    {valor: 0, texto: "Pai"},
    {valor: 1, texto: "Mãe"},
    {valor: 2, texto: "Avô"},
    {valor: 3, texto: "Avó"},
    {valor: 4, texto: "Outro"},
  ];

  constructor(
    private formBuilder: FormBuilder,
    private informacaoService: InformacaoService,
  ) { }

  ngOnInit(): void {
    this.registroAlunoForm = this.formBuilder.group({
      acao: [0, [Validators.required]],
      codigo: [{ value: '', disabled: true }, [Validators.required]],
      nome: ['', [Validators.required]],
      sobrenome: ['', [Validators.required]],
      dataNascimento: ['', [Validators.required]],
      localNascimento: ['', [Validators.required]],
      certidaoNascimento: ['', [Validators.required]],
      cpf: ['', [Validators.required]],
      rg: ['', [Validators.required]],
      endereco: this.formBuilder.group({
        logradouro: ['', [Validators.required]],
        numero: ['', [Validators.required]],
        bairro: ['', [Validators.required]],
        cidade: ['', [Validators.required]],
        estado: ['', [Validators.required]],
      }),
      responsaveis: this.formBuilder.array([]),
    });
  }

  responsaveis(): FormArray {
    return this.registroAlunoForm.get('responsaveis') as FormArray;
  }

  criarResponsavel(): FormGroup {
    return this.formBuilder.group({
      tipo: [''],
      nome: [''],
      sobrenome: [''],
      cpf: [''],
      rg: [''],
      telefones: this.formBuilder.array([]),
      contratante: [false],
    });
  }

  addResponsaveis() {
    this.responsaveis().push(this.criarResponsavel());
  }
  removeResponsavel( respIndex: number) {
    this.responsaveis().removeAt(respIndex);
  }

  responsavelTelefone(respIndex: number): FormArray {
    return this.responsaveis().at(respIndex).get('telefones') as FormArray;
  }

  novoTelefone(): FormGroup {
    return this.formBuilder.group({
      telefone: [''],
    });
  }

  addResponsavelTelefone(respIndex: number) {
    this.responsavelTelefone(respIndex).push(this.novoTelefone());
  }

  removeResponsavelTelefone(respIndex: number, telIndex: number) {
    this.responsavelTelefone(respIndex).removeAt(telIndex);
  }

  // ação = 'criar' => desabilita campo 'código'; ação != 'criar' => habilita campo 'código'
  liberaCodigo (acao: number) {
    if (acao == 0) {
      this.registroAlunoForm.controls['codigo'].setValue('');
      this.registroAlunoForm.controls['codigo'].disable();
    } else {
      this.registroAlunoForm.controls['codigo'].enable();
    }
  }

  onSubmit() {
    // verifica os campos obrigatórios
    if(this.registroAlunoForm.invalid) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Preencha os campos obrigatórios', 'danger');
      return;
    }

    // verifica se possui no mínimo 1 responsavel
    if (this.responsaveis().length < 1) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Insira no mínimo um responsável', 'danger');
      return;
    }

    // verifica se cada responsável possui pelo menos 1 telefone
    for (let index = 0; index < this.responsaveis().length; index++) {
      if (this.responsavelTelefone(index).length < 1) {
        window.scrollTo(0, 0);
        this.informacaoService.add('Insira no mínimo um telefone por responsável', 'danger');
        return;
      }
    }

    // verifica se existe pelo menos 1 contratante
    for (let index = 0; index < this.responsaveis().length; index++) {
      let resposta = this.responsaveis().get(`${index}`)?.get('contratante')?.value; 
      if (resposta) this.nContratantes++;
    }
    if (this.nContratantes < 1) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Mínimo um contratante', 'danger');
      
      return;
    }
    this.nContratantes = 0;

    // se tudo válido, envia mensagem e envia os dados para a api
    this.informacaoService.add('Tudo certo!', 'success');
    // this.informacaoService.remove();
    console.log(this.registroAlunoForm.value);
  }

  onReset () {
    window.location.href = "";
  }
}
