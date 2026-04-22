namespace demoTest1
{
    partial class Operator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BackButton = new System.Windows.Forms.Button();
            this.ComplOt = new System.Windows.Forms.Button();
            this.TypeOt = new System.Windows.Forms.Button();
            this.TimeOt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(13, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(89, 30);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ComplOt
            // 
            this.ComplOt.Location = new System.Drawing.Point(229, 81);
            this.ComplOt.Name = "ComplOt";
            this.ComplOt.Size = new System.Drawing.Size(404, 38);
            this.ComplOt.TabIndex = 1;
            this.ComplOt.Text = "отчёт по количеству выполненых заявок";
            this.ComplOt.UseVisualStyleBackColor = true;
            this.ComplOt.Click += new System.EventHandler(this.ComplOt_Click);
            // 
            // TypeOt
            // 
            this.TypeOt.Location = new System.Drawing.Point(229, 142);
            this.TypeOt.Name = "TypeOt";
            this.TypeOt.Size = new System.Drawing.Size(404, 38);
            this.TypeOt.TabIndex = 2;
            this.TypeOt.Text = "отчёт по типам неисправностей";
            this.TypeOt.UseVisualStyleBackColor = true;
            this.TypeOt.Click += new System.EventHandler(this.TypeOt_Click);
            // 
            // TimeOt
            // 
            this.TimeOt.Location = new System.Drawing.Point(229, 210);
            this.TimeOt.Name = "TimeOt";
            this.TimeOt.Size = new System.Drawing.Size(404, 38);
            this.TimeOt.TabIndex = 3;
            this.TimeOt.Text = "Отчёт по среднему времени выполнения";
            this.TimeOt.UseVisualStyleBackColor = true;
            this.TimeOt.Click += new System.EventHandler(this.TimeOt_Click);
            // 
            // Operator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimeOt);
            this.Controls.Add(this.TypeOt);
            this.Controls.Add(this.ComplOt);
            this.Controls.Add(this.BackButton);
            this.Name = "Operator";
            this.Text = "Operator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ComplOt;
        private System.Windows.Forms.Button TypeOt;
        private System.Windows.Forms.Button TimeOt;
    }
}