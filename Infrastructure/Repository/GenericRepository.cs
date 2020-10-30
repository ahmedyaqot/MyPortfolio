using Core.Interfaces;
using Microsoft.EntityFrameworkCore;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class  
    {
        private readonly DataContext context;
        private DbSet<T> table = null;

        public GenericRepository(DataContext context)
        {
            this.context = context;
            table = this.context.Set<T>();
        }

        public void Delete(object Id)
        {
            T element = GetById(Id);
            table.Remove(element);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object Id)
        {
            return table.Find(Id);
        }

        public void Insert(T entity)
        {
            table.Add(entity);
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            this.context.Entry(entity).State = EntityState.Modified;
        }
    }
}
