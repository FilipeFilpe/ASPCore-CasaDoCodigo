using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CasaDoCodigo.Models;
using System.Runtime.Serialization;

namespace CasaDoCodigo.Models
{
    public class ItemPedido : BaseModel
    {
        [DataMember]
        public Pedido Pedido { get; private set; }
        [DataMember]
        public Produto Produto { get; private set; }
        [DataMember]
        public int Quantidade { get; private set; }
        [DataMember]
        public decimal PrecoUnitario { get; private set; }
        [DataMember]
        public decimal Subtotal {
            get
            {
                return Quantidade * PrecoUnitario;
            }
        }
        
        public ItemPedido()
        {
            
        }
        public ItemPedido(Pedido pedido, int id, Produto produto, int quantidade)
                         : this(pedido, produto, quantidade)
        {
            this.Id = id;
        }
        public ItemPedido(Pedido pedido, Produto produto, int quantidade)
        {
            this.Pedido = pedido;
            this.Produto = produto;
            this.Quantidade = quantidade;
            this.PrecoUnitario = produto.Preco;
        }

        public void AtualizaQuantidade(int quantidade)
        {
            this.Quantidade = quantidade;
        }
    }
}