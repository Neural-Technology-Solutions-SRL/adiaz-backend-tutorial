﻿namespace TodosApi
{
    public class Todo
    {
        public Guid Id { get; set; }

        public string? Title { get; set; }

        public bool Completed { get; set; }
    }
}
