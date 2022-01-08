using DataAccess.Models;
using System.Collections.Generic;

namespace Business
{
    public interface IToDoBusiness : IRepository<ToDo>
    {
        IEnumerable<ToDo> ListAllToDos();
        IEnumerable<ToDo> ListUncompletedToDos();
        void AddToDoToABoard(ToDo todo, Board board);
        void ChangeTitleOrStatus(ToDo todo);
        void DeleteToDo(ToDo todo);
    }
}
