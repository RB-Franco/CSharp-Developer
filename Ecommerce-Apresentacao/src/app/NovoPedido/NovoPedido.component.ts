import { Component, OnInit } from '@angular/core';
import { Cliente } from '../_modelos/Cliente';
import { Produto } from '../_modelos/Produto';
import { NovoPedidoService } from '../_sevicos/NovoPedido.service';

@Component({
  selector:'app-NovoPedido',
  templateUrl: './NovoPedido.component.html',
  styleUrls: ['./NovoPedido.component.css']
})
export class NovoPedidoComponent implements OnInit {

  _filtroLista = '';
  get filtroLista(): string {
    return this._filtroLista;
  }
  set filtroLista(value: string) {
    this._filtroLista = value;
    this.clientesFiltrados = this.filtroLista ? this.filtrarClientes(this.filtroLista) :  this.Cliente;
  }

  clientesFiltrados: Cliente [];
  Cliente: Cliente[];
  Produto: Produto[];

  constructor(private novoPedidoService: NovoPedidoService) { }

  ngOnInit() {
    this.getClientes();
    this.getProdutos();
  }

  getClientes() {
    this.novoPedidoService.getClientes().subscribe(
      // tslint:disable-next-line: variable-name
      (_clientes: Cliente[]) => {
        this.Cliente = _clientes;
        console.log(_clientes);
      }, error => {
        console.log(error);
      });
    }

    getProdutos(){
      this.novoPedidoService.getProdutos().subscribe(
        // tslint:disable-next-line: variable-name
        (_produto: Produto[]) => {
          this.Produto = _produto;
          console.log(_produto);
        }, error => {
          console.log(error);
        });
      }
      filtrarClientes(filtrarPor: string): Cliente [] {
        filtrarPor = filtrarPor.toLocaleLowerCase();
        return this.Cliente.filter(
          cliente => cliente.nome.toLocaleLowerCase().indexOf(filtrarPor) !== -1
          );
        }

      }