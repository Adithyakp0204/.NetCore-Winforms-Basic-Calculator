namespace DotNetCore
{
    partial class Form1_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1_Main));
            panel1_Main = new Panel();
            label_Result = new Label();
            btn_clear = new Button();
            btn_Calculate = new Button();
            comboBox1_Operations = new ComboBox();
            textBox2 = new TextBox();
            textBox1_Num1 = new TextBox();
            panel1_Main.SuspendLayout();
            SuspendLayout();
            // 
            // panel1_Main
            // 
            panel1_Main.Controls.Add(label_Result);
            panel1_Main.Controls.Add(btn_clear);
            panel1_Main.Controls.Add(btn_Calculate);
            panel1_Main.Controls.Add(comboBox1_Operations);
            panel1_Main.Controls.Add(textBox2);
            panel1_Main.Controls.Add(textBox1_Num1);
            panel1_Main.Dock = DockStyle.Fill;
            panel1_Main.Location = new Point(0, 0);
            panel1_Main.Name = "panel1_Main";
            panel1_Main.Size = new Size(352, 314);
            panel1_Main.TabIndex = 0;
            // 
            // label_Result
            // 
            label_Result.AutoSize = true;
            label_Result.Font = new Font("Calibri", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label_Result.Location = new Point(35, 155);
            label_Result.Name = "label_Result";
            label_Result.Size = new Size(66, 23);
            label_Result.TabIndex = 6;
            label_Result.Text = "Result :";
            label_Result.Click += label_Result_Click;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.LightSkyBlue;
            btn_clear.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_clear.ForeColor = SystemColors.InactiveCaptionText;
            btn_clear.Location = new Point(193, 103);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(121, 33);
            btn_clear.TabIndex = 5;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_Calculate
            // 
            btn_Calculate.BackColor = Color.LightSkyBlue;
            btn_Calculate.Font = new Font("Calibri", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_Calculate.ForeColor = SystemColors.InactiveCaptionText;
            btn_Calculate.Location = new Point(31, 103);
            btn_Calculate.Name = "btn_Calculate";
            btn_Calculate.Size = new Size(146, 33);
            btn_Calculate.TabIndex = 4;
            btn_Calculate.Text = "Calculate";
            btn_Calculate.UseVisualStyleBackColor = false;
            btn_Calculate.Click += btn_Calculate_Click;
            // 
            // comboBox1_Operations
            // 
            comboBox1_Operations.FormattingEnabled = true;
            comboBox1_Operations.Items.AddRange(new object[] { "+", "-", "*", "/" });
            comboBox1_Operations.Location = new Point(193, 58);
            comboBox1_Operations.Name = "comboBox1_Operations";
            comboBox1_Operations.Size = new Size(121, 23);
            comboBox1_Operations.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = Color.DarkSlateGray;
            textBox2.Location = new Point(31, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(146, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox1_Num1
            // 
            textBox1_Num1.BackColor = Color.White;
            textBox1_Num1.BorderStyle = BorderStyle.FixedSingle;
            textBox1_Num1.ForeColor = Color.DarkSlateGray;
            textBox1_Num1.Location = new Point(31, 28);
            textBox1_Num1.Name = "textBox1_Num1";
            textBox1_Num1.Size = new Size(283, 23);
            textBox1_Num1.TabIndex = 0;
            // 
            // Form1_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 314);
            Controls.Add(panel1_Main);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            panel1_Main.ResumeLayout(false);
            panel1_Main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1_Main;
        private TextBox textBox1_Num1;
        private TextBox textBox2;
        private ComboBox comboBox1_Operations;
        private Button btn_clear;
        private Button btn_Calculate;
        private Label label_Result;
    }
}
