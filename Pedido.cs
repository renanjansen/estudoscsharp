using System;
using System.Collections.Generic;

namespace atv1Pedidos {

    public class Pedido {
        private List<ItemPedido> item = new List<ItemPedido> ();

        public static object Lista { get; private set; }

        public Pedido (List<ItemPedido> item) {
            this.item = item;
        }

        public Pedido () 
        {

        }

        public void incluir (ItemPedido itens) {
            item.Add (itens);
        }

        public List<ItemPedido> Listar () {
            return item;
        }
    }
}