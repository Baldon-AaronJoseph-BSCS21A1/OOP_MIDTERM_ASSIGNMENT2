using System.Security.Policy;

namespace Todolist
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button(); // New button for marking task as done
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridView2)).BeginInit();
            SuspendLayout();
            //
            // dataGridView1
            //
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(67, 46);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 392);
            dataGridView1.TabIndex = 0;
            //
            // dataGridView2
            //
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(430, 46);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(295, 392);
            dataGridView2.TabIndex = 1;
            //
            // textBox1
            //
            textBox1.Location = new Point(67, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(300, 27);
            textBox1.TabIndex = 2;
            //
            // button1
            //
            button1.Location = new Point(291, 12);
            button1.Name = "button1";
            button1.Size = new Size(76, 24);
            button1.TabIndex = 3;
            button1.Text = "Add Task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            //
            // button2
            //
            button2.Location = new Point(67, 444);
            button2.Name = "button2";
            button2.Size = new Size(120, 29);
            button2.TabIndex = 5;
            button2.Text = "Mark as Done";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            //
            // textBox2
            //
            textBox2.Location = new Point(430, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(295, 27);
            textBox2.TabIndex = 4;
            textBox2.Text = "DONE TASKS";
            textBox2.TextAlign = HorizontalAlignment.Center;
            //
            // Form1
            //
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 500); 
            Controls.Add(button2); 
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dataGridView2)).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private TextBox textBox1;
        private Button button1;
        private Button button2; // New button to mark tasks as done
        private TextBox textBox2;
    }
}
