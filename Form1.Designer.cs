namespace TextSearchWinForms
{
    partial class Form1
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
            this.lv_Results = new System.Windows.Forms.ListView();
            this.lbl1 = new System.Windows.Forms.Label();
            this.text_fileName = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_submit = new System.Windows.Forms.Button();
            this.txt_SearchString = new System.Windows.Forms.TextBox();
            this.Position = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Line = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_Results
            // 
            this.lv_Results.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Position,
            this.Line});
            this.lv_Results.HideSelection = false;
            this.lv_Results.Location = new System.Drawing.Point(279, 12);
            this.lv_Results.Name = "lv_Results";
            this.lv_Results.Size = new System.Drawing.Size(509, 426);
            this.lv_Results.TabIndex = 0;
            this.lv_Results.UseCompatibleStateImageBehavior = false;
            this.lv_Results.View = System.Windows.Forms.View.Details;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(13, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(107, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Upload file to search.";
            // 
            // text_fileName
            // 
            this.text_fileName.Location = new System.Drawing.Point(16, 25);
            this.text_fileName.Name = "text_fileName";
            this.text_fileName.Size = new System.Drawing.Size(228, 20);
            this.text_fileName.TabIndex = 2;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(16, 51);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(16, 197);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 4;
            this.btn_submit.Text = "Submit";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // txt_SearchString
            // 
            this.txt_SearchString.Location = new System.Drawing.Point(16, 171);
            this.txt_SearchString.Name = "txt_SearchString";
            this.txt_SearchString.Size = new System.Drawing.Size(228, 20);
            this.txt_SearchString.TabIndex = 5;
            // 
            // Position
            // 
            this.Position.Text = "Position";
            // 
            // Line
            // 
            this.Line.Text = "Line";
            this.Line.Width = 443;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "String to search.";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(13, 414);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(10, 13);
            this.lbl_Status.TabIndex = 7;
            this.lbl_Status.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_SearchString);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.text_fileName);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lv_Results);
            this.Name = "Form1";
            this.Text = "Text Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_Results;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox text_fileName;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader Line;
        private System.Windows.Forms.TextBox txt_SearchString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Status;
    }
}

