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
           
             return this._contexto.Categorias.Where(c => c.Id == id).SingleOrDefault();
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
                new Produto("Placa Testing","desc",12,789m,"ainda nao", this.GetCategoriaId("1")),
                new Produto("Placa Testing","desc",12,789m,"ainda nao", this.GetCategoriaId("1"))
            };

            foreach (var produto in produtos)
            {
                this._contexto.Produtos.Add(produto);
                this._contexto.ItensPedido.Add(new ItemPedido(produto, 1));
            }
            this._contexto.SaveChanges();
        }

        

    }
}
