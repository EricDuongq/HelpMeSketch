using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApi.Models;
using WebApi.Services;

namespace WebApi.Controllers
{
    [RoutePrefix("api/todos")]
    public class ToDoController : ApiController
    {
        readonly ToDoService toDoService = new ToDoService();

        [HttpGet, Route]
        public List<ToDo> GetAll()
        {
            return toDoService.GetAll();
        }

        [HttpPost, Route]
        public int Create(ToDoCreate model)
        {
            return toDoService.Create(model);
        }
    }
}