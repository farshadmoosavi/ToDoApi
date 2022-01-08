using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Business
{
    public class BaseBusiness
    {
        protected UnitOfWork uow;
        public BaseBusiness(DbContextOptions<ToDoAPIDbContext> option)
        {
            uow = new UnitOfWork(option);
        }
    }
}