using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class BoardBusiness : BaseBusiness, IBoardBusiness
    {
        private readonly UnitOfWork _unitOfWork;
        public BoardBusiness(UnitOfWork unitOfWork, DbContextOptions<ToDoAPIDbContext> option):base(option)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(Board entity)
        {
            _unitOfWork.BoardtRepository.Add(entity);
        }       

        public void AddRange(IEnumerable<Board> entities)
        {
            _unitOfWork.BoardtRepository.AddRange(entities);
        }

        public void ChangeBoardTitle(Board board, string newTitle)
        {            
            board.BoardName = newTitle;
        }

        public IEnumerable<Board> Find(Expression<Func<Board, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Board Get(int id)
        {
            return _unitOfWork.BoardtRepository.Get(id);   
        }       

        public IEnumerable<Board> ListAllBoards() 
        {
            return _unitOfWork.BoardtRepository.GetAll();
        }       

        public void Remove(Board board)
        {
            _unitOfWork.BoardtRepository.Remove(board);
        }

        public void RemoveRange(IEnumerable<Board> entities)
        {
            _unitOfWork.BoardtRepository.RemoveRange(entities);
        }
    }
}
