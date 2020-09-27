import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Pedido } from '../_modelos/Pedido';

@Injectable({
  providedIn: 'root'
})
export class PedidoService {
  baseURL = 'http://localhost:5000/api/pedido';

  constructor(private http: HttpClient) { }

  getPedidos(): Observable<Pedido[]> {
    return this.http.get<Pedido[]>(this.baseURL);
  }

}
