namespace TodoListAPI.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        public string DueDate { get; set; }
        public string CompletedDate { get; set; }
        public string Description { get; set; }
    }
}