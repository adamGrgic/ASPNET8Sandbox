
namespace Sandbox.Data.Models.Todo
{
    public class TodoItem
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime CompletedDate { get; set;}
    }
}
