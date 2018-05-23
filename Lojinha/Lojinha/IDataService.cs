﻿using Lojinha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lojinha
{
    public interface IDataService
    {
        
        void InsereProduto(Produto produto);
        List<Produto> GetProdutos();

        List<Categoria> GetCategorias();

    }
}