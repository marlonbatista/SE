import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class InformacaoService {

  informacao: string = '';
  classe: string = '';

  constructor() { }

  add(informacao: string, classe: string) {
    this.informacao = informacao;
    this.classe = classe;
  }

  remove() {
    this.informacao = '';
    this.classe = '';
  }
}
