namespace TaskApp.Domain
{
    public class WorkTask
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Description { get; private set; }

        public int Priority {get; private set;}
        public bool IsCompleted { get; private set; }
    

    public WorkTask(string title, string description,int priority)
        {
            if (priority < 1|| priority >5)
            throw new ArgumentException("Priority must be between 1 and 5") ;

            Title  = title;
            Description = description;
            Priority= priority;
            IsCompleted = false;

        }

} }
