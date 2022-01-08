using DataAccess.Models;
using System.Collections.Generic;

namespace Business
{
    public interface IBoardBusiness : IRepository<Board>
    {
        IEnumerable<Board> ListAllBoards();      
        void ChangeBoardTitle(Board board, string newTitle);       

    }
}
