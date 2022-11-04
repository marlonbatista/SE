import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Subject } from 'rxjs';
import { environment } from 'src/environments/environment';
import { AutenticacaoResposta } from './autenticacao-resposta';

@Injectable({
  providedIn: 'root'
})
export class AutenticacaoService {

  private loginSubject = new Subject<boolean>();

  constructor(public http: HttpClient) { }

  login(Login: string, Senha: string): Observable<AutenticacaoResposta> {
    return this.http.post<AutenticacaoResposta>(`${environment.url_api}autenticacao`, { Login, Senha });
  }
}
