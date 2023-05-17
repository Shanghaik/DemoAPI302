namespace TestAPIWF
{
    partial class Form1
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
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Result = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbt_Period = new System.Windows.Forms.TextBox();
            this.tbt_Distance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Calculate.Location = new System.Drawing.Point(13, 195);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(216, 66);
            this.btn_Calculate.TabIndex = 0;
            this.btn_Calculate.Text = "Tính Pace";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Result
            // 
            this.btn_Result.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Result.Location = new System.Drawing.Point(313, 198);
            this.btn_Result.Name = "btn_Result";
            this.btn_Result.Size = new System.Drawing.Size(198, 60);
            this.btn_Result.TabIndex = 1;
            this.btn_Result.Text = "...";
            this.btn_Result.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập thời gian";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nhập quãng đường";
            // 
            // tbt_Period
            // 
            this.tbt_Period.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Period.Location = new System.Drawing.Point(313, 21);
            this.tbt_Period.Name = "tbt_Period";
            this.tbt_Period.Size = new System.Drawing.Size(338, 38);
            this.tbt_Period.TabIndex = 4;
            this.tbt_Period.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbt_Distance
            // 
            this.tbt_Distance.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbt_Distance.Location = new System.Drawing.Point(310, 103);
            this.tbt_Distance.Name = "tbt_Distance";
            this.tbt_Distance.Size = new System.Drawing.Size(341, 38);
            this.tbt_Distance.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 274);
            this.Controls.Add(this.tbt_Distance);
            this.Controls.Add(this.tbt_Period);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Result);
            this.Controls.Add(this.btn_Calculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_Calculate;
        private Button btn_Result;
        private Label label1;
        private Label label2;
        private TextBox tbt_Period;
        private TextBox tbt_Distance;
    }
}