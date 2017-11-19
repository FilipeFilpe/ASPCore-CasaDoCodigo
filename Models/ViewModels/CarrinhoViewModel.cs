using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CasaDoCodigo.Models.ViewModels
{
    public class CarrinhoViewModel
    {
        public List<ItemPedido> Itens { get; private set; }
        public decimal Total{
            get
            {
                return Itens.Sum(i => i.Subtotal);
            }
        }

        public CarrinhoViewModel(List<ItemPedido> itens)
        {
            this.Itens = itens;
        }
    }
}