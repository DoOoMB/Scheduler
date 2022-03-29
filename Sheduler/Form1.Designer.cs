
namespace Sheduler
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddNewNoteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewNoteButton
            // 
            this.AddNewNoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.AddNewNoteButton.Location = new System.Drawing.Point(0, -1);
            this.AddNewNoteButton.Name = "AddNewNoteButton";
            this.AddNewNoteButton.Size = new System.Drawing.Size(799, 42);
            this.AddNewNoteButton.TabIndex = 0;
            this.AddNewNoteButton.Text = "+";
            this.AddNewNoteButton.UseVisualStyleBackColor = true;
            this.AddNewNoteButton.Click += new System.EventHandler(this.AddNewNoteEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddNewNoteButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewNoteButton;
    }
}

