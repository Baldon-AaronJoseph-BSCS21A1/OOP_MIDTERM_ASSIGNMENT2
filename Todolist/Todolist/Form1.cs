using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Windows.Forms;

namespace Todolist
{
    public partial class Form1 : Form
    {
        private BindingSource activeTaskBindingSource = new BindingSource();
        private BindingSource completedTaskBindingSource = new BindingSource();
        private List<Task> _activeTasks = new List<Task>();
        private List<Task> _completedTasks = new List<Task>();
        private int _nextTaskId = 1;

        public Form1()
        {
            InitializeComponent();

            // Set up DataGridViews
            dataGridView1.DataSource = activeTaskBindingSource;
            dataGridView2.DataSource = completedTaskBindingSource;

            // Make sure entire row is selected
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            
            activeTaskBindingSource.DataSource = _activeTasks;
            completedTaskBindingSource.DataSource = _completedTasks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string taskDescription = textBox1.Text;

            if (string.IsNullOrWhiteSpace(taskDescription))
            {
                MessageBox.Show("Please enter a task description.");
                return;
            }

            // Create a new task object
            Task newTask = new Task
            {
                Id = _nextTaskId++,
                Description = taskDescription,
                IsCompleted = false,
                CompletionTime = DateTime.Now
            };

            // Add the new task to the active tasks list
            _activeTasks.Add(newTask);

            // Refresh the DataGridView
            activeTaskBindingSource.ResetBindings(false);

            // Clear the textbox
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if there is a selected task
            if (dataGridView1.CurrentRow != null)
            {
                // Get the selected task
                Task selectedTask = (Task)dataGridView1.CurrentRow.DataBoundItem;

                // Check if the task is null for some reason
                if (selectedTask == null)
                {
                    MessageBox.Show("Selected task could not be found. Please try again.");
                    return;
                }

                // Mark task as done
                selectedTask.IsCompleted = true;

                // Move task to completed list
                _activeTasks.Remove(selectedTask);
                _completedTasks.Add(selectedTask);

                // Refresh both grids
                activeTaskBindingSource.ResetBindings(false);
                completedTaskBindingSource.ResetBindings(false);
            }
            else
            {
                // If no task is selected
                MessageBox.Show("Please select a task to mark as done.");
            }
        }

        
    }

    public class Task
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CompletionTime { get; set; }
    }
}
