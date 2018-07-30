using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Blazor;

namespace BlazorDemo
{


public class TodoBusiness
{
    public static List<TodoItem> Todos { get; set; } 
        //= new List<TodoItem> {
        //new TodoItem { Title = "Go windsurfing", Description = "Hope it's windy" },
        //new TodoItem { Title = "Back to work", Description = "Write a new blog post. Get with it!" },
        //new TodoItem { Title = "Maintenance Mode: Markdown Monster", Description = "Work on bug list for MM" },
        //new TodoItem { Title = "Fix Air Conditioner", Description = "Buy supplies and measure" },
        //new TodoItem { Title = "Write Web Assembly Article", Description="Create small demo, write up internals." }
    //};


        private HttpClient _httpClient;

        public TodoBusiness(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<TodoItem>> LoadTodos()
        {            
            Todos = await _httpClient.GetJsonAsync<List<TodoItem>>("/sample-data/todos.json");            
            return Todos;         
        }
    }


    public class TodoItem
    {
        public DateTime Entered { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }

        public TodoItem()
        {
            Entered = DateTime.Now;
        }
    }
}

