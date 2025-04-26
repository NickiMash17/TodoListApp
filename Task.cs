namespace TodoListApp
{
    public class Task
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string description)
        {
            Description = description;
            IsCompleted = false;
        }

        public override string ToString()
        {
            return $"{(IsCompleted ? "[✓]" : "[ ]")} {Description}";
        }
    }
}