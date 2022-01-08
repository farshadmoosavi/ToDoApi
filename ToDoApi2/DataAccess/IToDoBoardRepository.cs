using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IToDoBoardRepository  // have problem with the name!!!
    {
        ICollection<Board> GetAllBoards();  //Read
        void AddBoard(Board board);  //Create
        void ChangeBoardTitle(int BoardId, string title);  //Update
        void RemoveBoard(int BoardId);  //Delete
        ICollection<ToDo> GetAllToDosOnBoard(int BoardId);  //Read
        ICollection<ToDo> GetUncompletedToDos();  //Read
        void AddToDoToBoard(int BoardId, ToDo toDo);  //Create
        void ChangeToDoTitle(int ToDoID, string title);  //Update
        void DeleteToDo(int ToDoId);  //Delete
        bool IfDupliCatedTodo(); //use this function as a precondition for both Update & create functions.

    }
}
