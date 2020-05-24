﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections;
using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string EnderecoCompleto { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int NumeroEndereco { get; set; }

        public FormaPagamento FormaPagamento { get; set; }
        public int FormaPagamentoId { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos um item de pedidos ou muitos itens de pedido
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }

    }
}