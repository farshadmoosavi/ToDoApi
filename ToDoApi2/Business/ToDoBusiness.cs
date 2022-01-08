using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business
{
    public class ToDoBusiness : BaseBusiness, IToDoBusiness
    {
        private readonly UnitOfWork _unitOfWork;
        public ToDoBusiness(UnitOfWork unitOfWork, DbContextOptions<ToDoAPIDbContext> option): base(option)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(ToDo entity)
        {
            _unitOfWork.ToDoRepository.Add(entity);
        }

        public void AddRange(IEnumerable<ToDo> entities)
        {
            _unitOfWork.ToDoRepository.AddRange(entities);
        }

        public void AddToDoToABoard(ToDo todo, Board board)
        {
            todo.BoardId = board.Id;
            _unitOfWork.ToDoRepository.Add(todo);
        }

        public void ChangeTitleOrStatus(ToDo todo)
        {
            throw new NotImplementedException();
        }

        public void DeleteToDo(ToDo todo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDo> Find(Expression<Func<ToDo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public ToDo Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDo> GetAlll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDo> ListAllToDos()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ToDo> ListUncompletedToDos()
        {
            throw new NotImplementedException();
        }

        public void Remove(ToDo entity)
        {
            throw new NotImplementedException();
        }

        public void RemoveRange(IEnumerable<ToDo> entities)
        {
            throw new NotImplementedException();
        }
    }
}
