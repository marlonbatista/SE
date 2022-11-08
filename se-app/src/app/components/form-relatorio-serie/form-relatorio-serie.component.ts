import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { InformacaoService } from 'src/app/services/informacao/informacao.service';

@Component({
  selector: 'app-form-relatorio-serie',
  templateUrl: './form-relatorio-serie.component.html',
  styleUrls: ['./form-relatorio-serie.component.scss']
})
export class FormRelatorioSerieComponent implements OnInit {

  serieRelatorioForm!: FormGroup;

  series = [
    {valor: 0, texto: "1"},
    {valor: 1, texto: "2"},
    {valor: 2, texto: "3"},
  ];

  constructor(
    private formBuilder: FormBuilder,
    private informacaoService: InformacaoService,
  ) { }

  ngOnInit(): void {
    this.serieRelatorioForm = this.formBuilder.group({
      serie: ['', [Validators.required]],
    });
  }

  onSubmit() {
    if(this.serieRelatorioForm.invalid) {
      window.scrollTo(0, 0);
      this.informacaoService.add('Preencha os campos obrigatórios', 'danger');
      return;
    }

    this.informacaoService.add('Tudo certo!', 'success');
    // this.informacaoService.remove();
    console.log(this.serieRelatorioForm.value);
  }

  onReset () {
    window.location.href = "";
  }

}
