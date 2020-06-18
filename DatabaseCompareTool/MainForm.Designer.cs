namespace DatabaseCompareTool
{
    partial class MainForm
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
            this.compareButton = new System.Windows.Forms.Button();
            this.firstDBTextBox = new System.Windows.Forms.TextBox();
            this.secondDBTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.browseForFirstDB = new System.Windows.Forms.Button();
            this.browseForSecondDB = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // compareButton
            // 
            this.compareButton.Location = new System.Drawing.Point(235, 121);
            this.compareButton.Name = "compareButton";
            this.compareButton.Size = new System.Drawing.Size(185, 28);
            this.compareButton.TabIndex = 0;
            this.compareButton.Text = "Compare";
            this.compareButton.UseVisualStyleBackColor = true;
            this.compareButton.Click += new System.EventHandler(this.compareButton_Click);
            // 
            // firstDBTextBox
            // 
            this.firstDBTextBox.Location = new System.Drawing.Point(12, 28);
            this.firstDBTextBox.Name = "firstDBTextBox";
            this.firstDBTextBox.Size = new System.Drawing.Size(408, 22);
            this.firstDBTextBox.TabIndex = 1;
            // 
            // secondDBTextBox
            // 
            this.secondDBTextBox.Location = new System.Drawing.Point(12, 83);
            this.secondDBTextBox.Name = "secondDBTextBox";
            this.secondDBTextBox.Size = new System.Drawing.Size(408, 22);
            this.secondDBTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Database # 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database # 2";
            // 
            // browseForFirstDB
            // 
            this.browseForFirstDB.Location = new System.Drawing.Point(427, 26);
            this.browseForFirstDB.Name = "browseForFirstDB";
            this.browseForFirstDB.Size = new System.Drawing.Size(83, 24);
            this.browseForFirstDB.TabIndex = 5;
            this.browseForFirstDB.Text = "Browse ...";
            this.browseForFirstDB.UseVisualStyleBackColor = true;
            this.browseForFirstDB.Click += new System.EventHandler(this.browseForFirstDB_Click);
            // 
            // browseForSecondDB
            // 
            this.browseForSecondDB.Location = new System.Drawing.Point(427, 81);
            this.browseForSecondDB.Name = "browseForSecondDB";
            this.browseForSecondDB.Size = new System.Drawing.Size(83, 23);
            this.browseForSecondDB.TabIndex = 6;
            this.browseForSecondDB.Text = "Browse ...";
            this.browseForSecondDB.UseVisualStyleBackColor = true;
            this.browseForSecondDB.Click += new System.EventHandler(this.browseForSecondDB_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(15, 121);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(185, 28);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 161);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.browseForSecondDB);
            this.Controls.Add(this.browseForFirstDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secondDBTextBox);
            this.Controls.Add(this.firstDBTextBox);
            this.Controls.Add(this.compareButton);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Database Compare Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button compareButton;
        private System.Windows.Forms.TextBox firstDBTextBox;
        private System.Windows.Forms.TextBox secondDBTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button browseForFirstDB;
        private System.Windows.Forms.Button browseForSecondDB;
        private System.Windows.Forms.Button clearButton;
    }
}

