import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Cliente } from '../_modelos/Cliente';
import { Produto } from '../_modelos/Produto';

@Injectable({
  providedIn: 'root'
})
export class NovoPedidoService {
  baseURL_Cli = 'http://localhost:5000/api/cliente';
  baseURL_Prod = 'http://localhost:5000/api/produto';


constructor(private http: HttpClient) { }


getClientes(): Observable<Cliente[]> {
  return this.http.get<Cliente[]>(this.baseURL_Cli);
}

getProdutos(): Observable<Produto[]> {
  return this.http.get<Produto[]>(this.baseURL_Prod);
}

getProdutosById(id: number): Observable<Produto> {
  return this.http.get<Produto>(this.baseURL_Prod);
}
}
