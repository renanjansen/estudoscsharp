using System;
namespace atv1Pedidos
{
    public class ItemPedido{
        
      public string Descricao {get; set;}
       public float Valor_unitario {get; set;}
       public int Quantidade {get; set;} 

       public double Valor_Total {get; set;}

       public ItemPedido(string descricao, float valor_unitario, int quantidade){
           
           this.Descricao = descricao;
           this.Valor_unitario = valor_unitario;
           this.Quantidade = quantidade;
           

    }
     

    public ItemPedido(){

    }
    public String convertestring(){
        string dados = "Descrição: " + Descricao +" "+ "Valor Unitário: " + Valor_unitario +" "+ "Quantidade: "
        + Quantidade+" "+ "Valor Total: "+Valor_Total;
        return dados;
        }
    }
}
