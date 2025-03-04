namespace TaskManagementSystem.Model;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }

    public DateTime? CompleteTime { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;

    public TaskPriority Priority { get; set; } // Low, Medium, High
    public TaskStatus Status { get; set; } // Pending, In Progress, Completed

    // One-to-Many Ralationship between TaskItem and Category
    public int CategoryId { get; set; }
    public virtual Category Category { get; set; }

    // One-to-Many Ralationship between TaskItem and User
    public int UserId { get; set; }
    public virtual User User { get; set; }

}

public enum TaskPriority { Low, Medium, High }

public enum TaskStatus { Pending, InProgress, Completed }