namespace TaskManagementSystem.Model;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Relationship: One to Many between Category and TaskItem
    //public ICollection<TaskItem> Tasks { get; set; } = new List<TaskItem>(); // Navigation
}