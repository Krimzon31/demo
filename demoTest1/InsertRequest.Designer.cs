namespace demoTest1
{
    partial class InsertRequest
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
            this.InsertRequestButton = new System.Windows.Forms.Button();
            this.typeBox = new System.Windows.Forms.TextBox();
            this.modelBox = new System.Windows.Forms.TextBox();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InsertRequestButton
            // 
            this.InsertRequestButton.Location = new System.Drawing.Point(322, 309);
            this.InsertRequestButton.Name = "InsertRequestButton";
            this.InsertRequestButton.Size = new System.Drawing.Size(150, 48);
            this.InsertRequestButton.TabIndex = 0;
            this.InsertRequestButton.Text = "Подать заявку";
            this.InsertRequestButton.UseVisualStyleBackColor = true;
            this.InsertRequestButton.Click += new System.EventHandler(this.InsertRequestButton_Click);
            // 
            // typeBox
            // 
            this.typeBox.Location = new System.Drawing.Point(294, 113);
            this.typeBox.Name = "typeBox";
            this.typeBox.Size = new System.Drawing.Size(215, 22);
            this.typeBox.TabIndex = 1;
            // 
            // modelBox
            // 
            this.modelBox.Location = new System.Drawing.Point(294, 150);
            this.modelBox.Name = "modelBox";
            this.modelBox.Size = new System.Drawing.Size(215, 22);
            this.modelBox.TabIndex = 2;
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(294, 189);
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(215, 22);
            this.descriptionBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Тип автомобиля";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(135, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Модель автомобиля";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Описание проблемы";
            // 
            // InsertRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.modelBox);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.InsertRequestButton);
            this.Name = "InsertRequest";
            this.Text = "InsertRequest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertRequestButton;
        private System.Windows.Forms.TextBox typeBox;
        private System.Windows.Forms.TextBox modelBox;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}