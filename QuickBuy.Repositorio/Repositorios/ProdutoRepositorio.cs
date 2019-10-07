using QuickBuy.Dominio.Contratos;
using QuickBuy.Entidades.Dominio;
using QuickBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(BaseContext baseContext) : base(baseContext)
        {
        }
    }
}
