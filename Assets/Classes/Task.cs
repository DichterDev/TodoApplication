using System;
using System.Collections.Generic;

namespace TodoApplication
{
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

        string taskName { get; set; }

        string taskDescription { get; set; }
        DateTime taskDate { get; set; }
        bool isCompleted { get; set; }
        int completionStatus { get; set; }
        List<SubTask> Subtasks = new List<SubTask>();

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
            if (description == null)
            {
                NullError("Taskdescription");
            }

            this.taskDescription = description;
        }

        public void SetTaskDate(DateTime date)
        {
            if (date == null)
            {
                NullError("Taskdate");
            }

            this.taskDate = date;
        }

        public void AddSubTask(SubTask subTask)
        {
            this.Subtasks.Add(subTask);
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

    public class SubTask
    {
        string subTaskName { get; set; }
        bool isCompleted { set; get; } = false;
        Task Task { get; set; }

        public void SetSubtaskName(string name)
        {
            this.subTaskName = name;
        }

        public void ChangeCompletion()
        {
            this.isCompleted = !isCompleted;
        }

        public void AddToTask()
        {
            Task.AddSubTask(this);
        }
    }

}