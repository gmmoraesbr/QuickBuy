using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Entidades.Dominio
{
    public class ItemPedido : Entidade
    {
        public int Id { get; set; }

        public int PedidoId { get; set; } 

        public virtual Pedido Pedido { get; set; }

        public int ProdutoId { get; set; }

        public virtual Produto Produto { get; set; }

        public int Quantidade { get; set; }
        
        public override void Validate()
        {
            if (ProdutoId == 0)
                AdicionarCritica("Não foi identificado qual a referência do produto");

            if (Quantidade == 0)
                AdicionarCritica("Quantidade não foi informado");
        }
    }
}
