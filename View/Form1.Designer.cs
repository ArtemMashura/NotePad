namespace MVC_practice
{
    partial class MainForm1
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
            this.DateTB = new System.Windows.Forms.TextBox();
            this.TextTB = new System.Windows.Forms.TextBox();
            this.noteSave_BTN = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FindTB = new System.Windows.Forms.TextBox();
            this.FindBTN = new System.Windows.Forms.Button();
            this.FindErrorLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateTB
            // 
            this.DateTB.Location = new System.Drawing.Point(30, 28);
            this.DateTB.Name = "DateTB";
            this.DateTB.Size = new System.Drawing.Size(100, 20);
            this.DateTB.TabIndex = 1;
            // 
            // TextTB
            // 
            this.TextTB.Location = new System.Drawing.Point(30, 105);
            this.TextTB.Name = "TextTB";
            this.TextTB.Size = new System.Drawing.Size(100, 20);
            this.TextTB.TabIndex = 2;
            // 
            // noteSave_BTN
            // 
            this.noteSave_BTN.Location = new System.Drawing.Point(30, 144);
            this.noteSave_BTN.Name = "noteSave_BTN";
            this.noteSave_BTN.Size = new System.Drawing.Size(100, 23);
            this.noteSave_BTN.TabIndex = 3;
            this.noteSave_BTN.Text = "Save";
            this.noteSave_BTN.UseVisualStyleBackColor = true;
            this.noteSave_BTN.Click += new System.EventHandler(this.noteSave_BTN_Click_1);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(12, 128);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(199, 13);
            this.ErrorLabel.TabIndex = 4;
            this.ErrorLabel.Text = "Дата или имя не могут быть пустыми";
            this.ErrorLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Заголовок";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Текст";
            // 
            // TitleTB
            // 
            this.TitleTB.Location = new System.Drawing.Point(30, 66);
            this.TitleTB.Name = "TitleTB";
            this.TitleTB.Size = new System.Drawing.Size(100, 20);
            this.TitleTB.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Найти";
            // 
            // FindTB
            // 
            this.FindTB.Location = new System.Drawing.Point(30, 227);
            this.FindTB.Name = "FindTB";
            this.FindTB.Size = new System.Drawing.Size(100, 20);
            this.FindTB.TabIndex = 10;
            // 
            // FindBTN
            // 
            this.FindBTN.Location = new System.Drawing.Point(30, 253);
            this.FindBTN.Name = "FindBTN";
            this.FindBTN.Size = new System.Drawing.Size(100, 23);
            this.FindBTN.TabIndex = 11;
            this.FindBTN.Text = "Найти";
            this.FindBTN.UseVisualStyleBackColor = true;
            this.FindBTN.Click += new System.EventHandler(this.FindBTN_Click);
            // 
            // FindErrorLabel
            // 
            this.FindErrorLabel.AutoSize = true;
            this.FindErrorLabel.Location = new System.Drawing.Point(27, 289);
            this.FindErrorLabel.Name = "FindErrorLabel";
            this.FindErrorLabel.Size = new System.Drawing.Size(80, 13);
            this.FindErrorLabel.TabIndex = 12;
            this.FindErrorLabel.Text = "Ошибка ввода";
            this.FindErrorLabel.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(232, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(570, 450);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Удалить заметки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.FindErrorLabel);
            this.Controls.Add(this.FindBTN);
            this.Controls.Add(this.FindTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TitleTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.noteSave_BTN);
            this.Controls.Add(this.TextTB);
            this.Controls.Add(this.DateTB);
            this.Name = "MainForm1";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox DateTB;
        private System.Windows.Forms.TextBox TextTB;
        private System.Windows.Forms.Button noteSave_BTN;
        public System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TitleTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FindTB;
        private System.Windows.Forms.Button FindBTN;
        private System.Windows.Forms.Label FindErrorLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
    }
}

