import { Produto } from './Produto';

export interface Pedido {
  id: number;
  valorTotal: number;
  qtdItem: number;
  valorFrete: number;
  clienteId: number;
  produtoId: number;
  produtosPedido: Produto[];
}
