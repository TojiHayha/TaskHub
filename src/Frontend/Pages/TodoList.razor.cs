using TaskHub.Models;

namespace TaskHub.Pages;

public partial class TodoList
{
    public List<TodoItem>? ItemsList { get; set; }
    public IReadOnlyCollection<TodoItem>? SelectedValues { get; set; } = new List<TodoItem>();
    public bool ReadOnly { get; set; }

    protected override void OnInitialized()
    {
        CreateList();
    }

    public void CreateList()
    {
        ItemsList = new List<TodoItem>
        {
            new TodoItem { Id = Guid.NewGuid(), Title = "Pay wather debt", IsCompleted = true},
            new TodoItem { Id = Guid.NewGuid(), Title = "Go to market", IsCompleted = true},
            new TodoItem { Id = Guid.NewGuid(), Title = "Go to home", IsCompleted = false},
            new TodoItem { Id = Guid.NewGuid(), Title = "Cooked", IsCompleted = false},
        };
    }
}
