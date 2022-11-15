using System;

public class Task 
{
    /*
     * TODO
     * Name
     * Description
     * Date
     * Completion Status
     * Reminder
     * Additional: Subtasks
     * 
     */

    string taskName
    {
        get
        {
            return taskName;
        }

        set
        {
            taskName = value;
            OnChange();
        }
    }

    string taskDescription { get; set; }
    DateTime taskDate { get; set; }
    bool isCompleted { get; set; }
    // Subtask Subtasks


    /// <summary>
    /// The function that gets called on every change of a Task.
    /// </summary>
    private void OnChange()
    {

    }

    public void SetTaskName(string name)
    {
        if (name == null)
        {
            NullError("Taskname");
        }
        
        this.taskName = name;
    }

    public void SetTaskDescription(string description)
    {
        this.taskDescription = description;
    }

    public void SetTaskDate(DateTime date)
    {
        this.taskDate = date;
    }


    /// <summary>
    /// A function that calls the error popup
    /// </summary>
    /// <param name="cause"></param>
    private void NullError(string cause)
    {
        // Call Error using cause 
    }
}
