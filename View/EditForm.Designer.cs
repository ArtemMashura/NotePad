namespace MVC_practice.View
{
    partial class EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EditTitleTB = new System.Windows.Forms.TextBox();
            this.EditTextTB = new System.Windows.Forms.TextBox();
            this.EditDateTB = new System.Windows.Forms.TextBox();
            this.SaveBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Заголовок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Текст";
            // 
            // EditTitleTB
            // 
            this.EditTitleTB.Location = new System.Drawing.Point(12, 64);
            this.EditTitleTB.Name = "EditTitleTB";
            this.EditTitleTB.Size = new System.Drawing.Size(100, 20);
            this.EditTitleTB.TabIndex = 3;
            // 
            // EditTextTB
            // 
            this.EditTextTB.Location = new System.Drawing.Point(12, 103);
            this.EditTextTB.Name = "EditTextTB";
            this.EditTextTB.Size = new System.Drawing.Size(100, 20);
            this.EditTextTB.TabIndex = 4;
            // 
            // EditDateTB
            // 
            this.EditDateTB.Location = new System.Drawing.Point(12, 25);
            this.EditDateTB.Name = "EditDateTB";
            this.EditDateTB.Size = new System.Drawing.Size(100, 20);
            this.EditDateTB.TabIndex = 5;
            // 
            // SaveBTN
            // 
            this.SaveBTN.Location = new System.Drawing.Point(12, 139);
            this.SaveBTN.Name = "SaveBTN";
            this.SaveBTN.Size = new System.Drawing.Size(100, 23);
            this.SaveBTN.TabIndex = 6;
            this.SaveBTN.Text = "Сохранить";
            this.SaveBTN.UseVisualStyleBackColor = true;
            this.SaveBTN.Click += new System.EventHandler(this.SaveBTN_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 251);
            this.Controls.Add(this.SaveBTN);
            this.Controls.Add(this.EditDateTB);
            this.Controls.Add(this.EditTextTB);
            this.Controls.Add(this.EditTitleTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EditTitleTB;
        private System.Windows.Forms.TextBox EditTextTB;
        private System.Windows.Forms.TextBox EditDateTB;
        private System.Windows.Forms.Button SaveBTN;
    }
}