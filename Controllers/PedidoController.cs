using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using CasaDoCodigo.Models;
using CasaDoCodigo.Models.ViewModels;

namespace CasaDoCodigo.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IDataService _dataService;

        public PedidoController(IDataService dataService)
        {
            this._dataService = dataService;
        }

        public IActionResult Carrossel() 
        {
            List<Produto> produtos = _dataService.GetProdutos();
            return View(produtos);
        }

        public IActionResult Carrinho() 
        {
            CarrinhoViewModel viewModel = GetCarrinhoViewModel();
            return View(viewModel);
        }

        public IActionResult Resumo() 
        {
            CarrinhoViewModel viewModel = GetCarrinhoViewModel();
            return View(viewModel);
        }

        public CarrinhoViewModel GetCarrinhoViewModel()
        {
            List<Produto> produtos = this._dataService.GetProdutos();
            
            var itensCarrinho = this._dataService.GetItensPedido();

            CarrinhoViewModel viewModel = new CarrinhoViewModel(itensCarrinho);

            return viewModel;
        }
    }
}