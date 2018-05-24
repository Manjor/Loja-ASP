﻿using Lojinha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha
{
    public class DataService : IDataService
    {

        private readonly BancoContext _contexto;

        public DataService(BancoContext contexto)
        {
            this._contexto = contexto;
        }

        //Retorna a lista de Produtos
        public List<Produto> GetProdutos()
        {
            return this._contexto.Produtos.ToList();
        }

        //Retorna a Categoria desejada pelo Id 
        public Categoria GetCategoriaId(int id)
        {
<<<<<<< HEAD
            //Declara uma variavel inteira
            int idInt;
            //Converte o dado do parametro para inteiro
            Int32.TryParse(id, out idInt);

            


            //Cria uma variavel que irá receber o resultado da clausula Where
            //Que irá capturar no banco de dados a Categoria correspondente 
            //Ao Id inserido no parametro
            var catId = this._contexto.Categorias.Where(c => c.Id == idInt);


            
             return categoria;
=======
           
             return this._contexto.Categorias.Where(c => c.Id == id).SingleOrDefault();
>>>>>>> 98f008b8ae101d36f5ffcf40cc54456fbaa2c1cb
        }

        //Retorna a lista de Categorias
        public List<Categoria> GetCategoria()
        {
            return this._contexto.Categorias.ToList();
        }


        //Salva a inserção no banco de dados
        public void InsereProduto(Produto produto)
        {
            this._contexto.Produtos.Add(produto);
            this._contexto.SaveChanges();
        }

        //Metodo que adiciona um produto ao banco de dados
        public void AddProduto(Produto produto)
        {

            this._contexto.Produtos.Add(produto);
            this._contexto.SaveChanges();
        }
        //Metodo de Inserção de Dados no Banco de Dados por meio de uma lista
        public void InsereDB()
        {
            List<Produto> produtos = new List<Produto>
            {
                new Produto("Placa Testing","desc",12,789m,"ainda nao", this.GetCategoriaId(1)),
                new Produto("Placa Testing","desc",12,789m,"ainda nao", this.GetCategoriaId(1))
            };

            foreach (var produto in produtos)
            {
                this._contexto.Produtos.Add(produto);
                this._contexto.ItensPedido.Add(new ItemPedido(produto, 1));
            }
            this._contexto.SaveChanges();
        }



        /**********************************************/

        //Busca os pedidos dentro do banco e cria uma lista deles
        public List<ItemPedido> GetItemPedidos()
        {
            return this._contexto.ItensPedido.ToList();
        }

        //Busca um registro de Pedido do banco, por meio do Id inserido
        public ItemPedido GetPedidoId(int id)
        {
            return this._contexto.ItensPedido.Where(p => p.Id == id).SingleOrDefault();
        }

        public void AddItemPedido(ItemPedido itemPedido)
        {
            this._contexto.ItensPedido.Add(itemPedido);
            this._contexto.SaveChanges();
            
        }

    }
}
