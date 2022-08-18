namespace SuperHeroApi
{
    public class Todo
    {
        public Guid Id { get; set; }
        public bool Completed { get; set; }
        public string Title { get; set; } = string.Empty;
        
    }
}
