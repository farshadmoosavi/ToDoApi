using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess.Models
{
    public class UnitOfWork : IDisposable
    {
        private ToDoAPIDbContext context; 
        private GenericRepository<Board> boardRepository;
        private GenericRepository<ToDo> todoRepository;
        public UnitOfWork(DbContextOptions<ToDoAPIDbContext> option)
        {
            context = new ToDoAPIDbContext(option);
        }

        public GenericRepository<Board> BoardtRepository
        {
            get
            {

                if (this.boardRepository == null)
                {
                    this.boardRepository = new GenericRepository<Board>(context);
                }
                return boardRepository;
            }
        }

        public GenericRepository<ToDo> ToDoRepository
        {
            get
            {

                if (this.todoRepository == null)
                {
                    this.todoRepository = new GenericRepository<ToDo>(context);
                }
                return todoRepository;
            }
        }

        public void Complete()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }


}
