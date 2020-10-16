using System;
using System.Collections;
using System.Collections.Generic;

namespace atv1Pedidos {
    class Program {
        static void Main (string[] args) {
            Pedido pedido = new Pedido(new List<ItemPedido>());

            string resposta = "";
            while (resposta != "n") {
                ItemPedido item = new ItemPedido ();

                Console.WriteLine ("Insira o item pedido: ");
                Console.Write ("Descrição: ");
                item.Descricao = Console.ReadLine ();

                Console.Write ("Valor unitário: ");
                item.Valor_unitario = float.Parse (Console.ReadLine ());

                Console.Write ("Quantidade: ");
                item.Quantidade = int.Parse (Console.ReadLine ());

                

                pedido.incluir(item);

                Console.WriteLine("Deseja inserir outro item?(s/n) ");
                resposta = Console.ReadLine();

            } 
              for(int i = 0; i < pedido.Listar().Count; i++)
              {
                  string text = pedido.Listar()[i].convertestring();
                  Console.WriteLine(text);
              }
        }
    }
}