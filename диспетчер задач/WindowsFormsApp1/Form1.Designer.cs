
namespace WindowsFormsApp1
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
            this.lBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.tBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lBox
            // 
            this.lBox.FormattingEnabled = true;
            this.lBox.Location = new System.Drawing.Point(12, 12);
            this.lBox.Name = "lBox";
            this.lBox.Size = new System.Drawing.Size(246, 420);
            this.lBox.TabIndex = 0;
            this.lBox.SelectedIndexChanged += new System.EventHandler(this.lBox_SelectedItemChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(264, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(278, 81);
            this.button2.TabIndex = 2;
            this.button2.Text = "Снять задачу";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tBox
            // 
            this.tBox.Location = new System.Drawing.Point(268, 12);
            this.tBox.Name = "tBox";
            this.tBox.Size = new System.Drawing.Size(274, 20);
            this.tBox.TabIndex = 3;
            this.tBox.TextChanged += new System.EventHandler(this.tBox_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(274, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tBox2
            // 
            this.tBox2.Location = new System.Drawing.Point(264, 312);
            this.tBox2.Name = "tBox2";
            this.tBox2.Size = new System.Drawing.Size(274, 20);
            this.tBox2.TabIndex = 5;
            this.tBox2.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 450);
            this.Controls.Add(this.tBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tBox2;
    }
}

