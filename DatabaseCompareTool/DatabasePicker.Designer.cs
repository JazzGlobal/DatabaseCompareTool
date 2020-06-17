namespace DatabaseCompareTool
{
    partial class DatabasePicker
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
            this.databaseList = new System.Windows.Forms.ListBox();
            this.chooseDataBase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // databaseList
            // 
            this.databaseList.FormattingEnabled = true;
            this.databaseList.ItemHeight = 16;
            this.databaseList.Location = new System.Drawing.Point(12, 12);
            this.databaseList.Name = "databaseList";
            this.databaseList.Size = new System.Drawing.Size(454, 228);
            this.databaseList.TabIndex = 0;
            // 
            // chooseDataBase
            // 
            this.chooseDataBase.Location = new System.Drawing.Point(12, 258);
            this.chooseDataBase.Name = "chooseDataBase";
            this.chooseDataBase.Size = new System.Drawing.Size(454, 46);
            this.chooseDataBase.TabIndex = 1;
            this.chooseDataBase.Text = "Select";
            this.chooseDataBase.UseVisualStyleBackColor = true;
            this.chooseDataBase.Click += new System.EventHandler(this.chooseDataBase_Click);
            // 
            // DatabasePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 323);
            this.Controls.Add(this.chooseDataBase);
            this.Controls.Add(this.databaseList);
            this.Name = "DatabasePicker";
            this.Text = "Choose A Database";
            this.Load += new System.EventHandler(this.DatabasePicker_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox databaseList;
        private System.Windows.Forms.Button chooseDataBase;
    }
}