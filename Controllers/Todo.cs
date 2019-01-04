namespace todoapi.Controllers
{
    public class Todo
    {
        public long ID { get; set; }
        public string Description { get; set; }
        public bool Completed { get; set; }
        public Todo()
        {
            Completed = false;
        }
    }
}