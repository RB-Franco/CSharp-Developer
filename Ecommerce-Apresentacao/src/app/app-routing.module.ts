import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NovoPedidoComponent } from './NovoPedido/NovoPedido.component';
import { PedidosComponent } from './Pedidos/Pedidos.component';

const routes: Routes = [
  {path: 'ConsultaPedidos', component: PedidosComponent},
  {path: 'NovoPedido', component: NovoPedidoComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
