using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class ToDoBoardRepository : IToDoBoardRepository
    {
        private ToDoAPIDbContext context;
        
        public ToDoBoardRepository(ToDoAPIDbContext context)
        {
            this.context = context;
        }
        public void AddBoard(Board board)
        {
            context.Boards.Add(board);
        }

        public void AddToDoToBoard(int BoardId, ToDo toDo)
        {
            Board board = context.Boards.Find(BoardId);
            board.ToDoss.Add(toDo); // have some doubts
        }

        public void ChangeBoardTitle(int BoardId,string title)
        {
            Board board = context.Boards.Find(BoardId);
            board.BoardName = title;
        }

        public void ChangeToDoTitle(int ToDoId, string title)
        {
            ToDo todo = context.ToDos.Find(ToDoId);
            todo.ToDoTitle = title;
        }

        public void DeleteToDo(int ToDoId)
        {
            ToDo todo = context.ToDos.Find(ToDoId);
            context.ToDos.Remove(todo);
        }

        public ICollection<Board> GetAllBoards()
        {
            return context.Boards.ToList();
        }

        public ICollection<ToDo> GetAllToDosOnBoard(int BoardId)
        {
            Board board = context.Boards.Find(BoardId);
            return board.ToDoss.ToList();  // have some doubts
        }

        public ICollection<ToDo> GetUncompletedToDos()
        {
            return context.ToDos.Where(v => v.ToDoTitle == null).ToList();  // because todoTitle can take nothing!
            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateTime.Now.AddDays(index),
            //    TemperatureC = rng.Next(-20, 55),
            //    Summary = Summaries[rng.Next(Summaries.Length)]
            //})
            //.ToArray();
        }

        public bool IfDupliCatedTodo()
        {
            //       allDuplicates = dt.AsEnumerable()
            //.GroupBy(dr => new
            //{
            //    Field1 = dr.Field<object>("String"),
            //    Field2 = dr.Field<object>("Date"),
            //    Field3 = dr.Field<object>("Money"),
            //})
            //.Where(g => g.Count() > 1)
            //.SelectMany(g => g)
            //.ToList()
            return false;
        }
            public void RemoveBoard(int BoardId)
        {
            throw new NotImplementedException();
        }
    }
}
