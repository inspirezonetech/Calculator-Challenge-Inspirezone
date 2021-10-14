
namespace Calculator
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
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button_Subtract = new System.Windows.Forms.Button();
            this.button_Multiply = new System.Windows.Forms.Button();
            this.button_Divide = new System.Windows.Forms.Button();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(12, 56);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(70, 50);
            this.button_Add.TabIndex = 1;
            this.button_Add.Text = "Add (+)";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 30);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(146, 20);
            this.textBox.TabIndex = 0;
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button_Subtract
            // 
            this.button_Subtract.Location = new System.Drawing.Point(88, 56);
            this.button_Subtract.Name = "button_Subtract";
            this.button_Subtract.Size = new System.Drawing.Size(70, 50);
            this.button_Subtract.TabIndex = 2;
            this.button_Subtract.Text = "Subtract (-)";
            this.button_Subtract.UseVisualStyleBackColor = true;
            this.button_Subtract.Click += new System.EventHandler(this.button_Subtract_Click);
            // 
            // button_Multiply
            // 
            this.button_Multiply.Location = new System.Drawing.Point(12, 112);
            this.button_Multiply.Name = "button_Multiply";
            this.button_Multiply.Size = new System.Drawing.Size(70, 50);
            this.button_Multiply.TabIndex = 3;
            this.button_Multiply.Text = "Multiply (*)";
            this.button_Multiply.UseVisualStyleBackColor = true;
            this.button_Multiply.Click += new System.EventHandler(this.button_Multiply_Click);
            // 
            // button_Divide
            // 
            this.button_Divide.Location = new System.Drawing.Point(88, 112);
            this.button_Divide.Name = "button_Divide";
            this.button_Divide.Size = new System.Drawing.Size(70, 50);
            this.button_Divide.TabIndex = 4;
            this.button_Divide.Text = "Divide (/)";
            this.button_Divide.UseVisualStyleBackColor = true;
            this.button_Divide.Click += new System.EventHandler(this.button_Divide_Click);
            // 
            // button_Calculate
            // 
            this.button_Calculate.Location = new System.Drawing.Point(12, 168);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(146, 26);
            this.button_Calculate.TabIndex = 5;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = true;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(11, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(0, 13);
            this.label.TabIndex = 6;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 208);
            this.Controls.Add(this.label);
            this.Controls.Add(this.button_Calculate);
            this.Controls.Add(this.button_Divide);
            this.Controls.Add(this.button_Multiply);
            this.Controls.Add(this.button_Subtract);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button_Add);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button button_Subtract;
        private System.Windows.Forms.Button button_Multiply;
        private System.Windows.Forms.Button button_Divide;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.Label label;
    }
}

