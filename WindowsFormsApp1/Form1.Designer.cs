
namespace WindowsFormsApp1
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
            this.OldNameTB = new System.Windows.Forms.TextBox();
            this.NewNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AllFiles = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SwapList = new System.Windows.Forms.Button();
            this.ResultFindFilesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OldNameTB
            // 
            this.OldNameTB.Location = new System.Drawing.Point(12, 37);
            this.OldNameTB.Name = "OldNameTB";
            this.OldNameTB.Size = new System.Drawing.Size(265, 20);
            this.OldNameTB.TabIndex = 0;
            this.OldNameTB.Tag = "";
            // 
            // NewNameTB
            // 
            this.NewNameTB.Location = new System.Drawing.Point(97, 97);
            this.NewNameTB.Name = "NewNameTB";
            this.NewNameTB.Size = new System.Drawing.Size(265, 20);
            this.NewNameTB.TabIndex = 1;
            this.NewNameTB.TextChanged += new System.EventHandler(this.NewNameTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter old name of file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter new name of file";
            // 
            // AllFiles
            // 
            this.AllFiles.FormattingEnabled = true;
            this.AllFiles.Location = new System.Drawing.Point(12, 148);
            this.AllFiles.Name = "AllFiles";
            this.AllFiles.Size = new System.Drawing.Size(350, 290);
            this.AllFiles.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Rename";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SwapList
            // 
            this.SwapList.Location = new System.Drawing.Point(287, 119);
            this.SwapList.Name = "SwapList";
            this.SwapList.Size = new System.Drawing.Size(75, 23);
            this.SwapList.TabIndex = 6;
            this.SwapList.Text = "All files";
            this.SwapList.UseVisualStyleBackColor = true;
            this.SwapList.Click += new System.EventHandler(this.SwapList_Click);
            // 
            // ResultFindFilesList
            // 
            this.ResultFindFilesList.FormattingEnabled = true;
            this.ResultFindFilesList.Location = new System.Drawing.Point(15, 148);
            this.ResultFindFilesList.Name = "ResultFindFilesList";
            this.ResultFindFilesList.Size = new System.Drawing.Size(350, 290);
            this.ResultFindFilesList.TabIndex = 7;
            this.ResultFindFilesList.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.ResultFindFilesList);
            this.Controls.Add(this.SwapList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AllFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewNameTB);
            this.Controls.Add(this.OldNameTB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OldNameTB;
        private System.Windows.Forms.TextBox NewNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox AllFiles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SwapList;
        private System.Windows.Forms.ListBox ResultFindFilesList;
    }
}

