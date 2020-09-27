import { Component, OnInit } from '@angular/core';
import { Pedido } from '../_modelos/Pedido';
import { PedidoService } from '../_sevicos/Pedido.service';

@Component({
  selector: 'app-Pedidos',
  templateUrl: './Pedidos.component.html',
  styleUrls: ['./Pedidos.component.css']
})
export class PedidosComponent implements OnInit {

  Pedidos: Pedido [];

  constructor(private pedidoService : PedidoService) { }

  ngOnInit() {
    this.getPedidos();
  }

  getPedidos() {
    this.pedidoService.getPedidos().subscribe(
      (_pedidos: Pedido[]) => {
        this.Pedidos = _pedidos;
      }, error => {
        console.log(error);
      });
    }
  }
