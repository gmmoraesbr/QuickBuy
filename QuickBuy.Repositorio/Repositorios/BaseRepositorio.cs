using QuickBuy.Dominio.Contratos;
using QuickBuy.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly BaseContext baseContext; 

        public BaseRepositorio(BaseContext baseContext)
        {
            this.baseContext = baseContext;
        }

        public void Adicionar(TEntity entity)
        {
            baseContext.Set<TEntity>().Add(entity);
            baseContext.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            baseContext.Set<TEntity>().Update(entity);
            baseContext.SaveChanges();
        }

        public void Dispose()
        {
            baseContext.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return baseContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return baseContext.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            baseContext.Remove(entity);
            baseContext.SaveChanges();
        }
    }
}
