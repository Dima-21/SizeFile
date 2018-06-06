namespace TreeView
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
            this.Label = new System.Windows.Forms.Label();
            this.FolderBrowser = new System.Windows.Forms.TextBox();
            this.BBrowser = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.BFind = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NameFolder = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Folders = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Files = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label.Location = new System.Drawing.Point(13, 13);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(52, 24);
            this.Label.TabIndex = 0;
            this.Label.Text = "Path:";
            // 
            // FolderBrowser
            // 
            this.FolderBrowser.Location = new System.Drawing.Point(71, 18);
            this.FolderBrowser.Name = "FolderBrowser";
            this.FolderBrowser.Size = new System.Drawing.Size(171, 20);
            this.FolderBrowser.TabIndex = 1;
            // 
            // BBrowser
            // 
            this.BBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BBrowser.Location = new System.Drawing.Point(248, 18);
            this.BBrowser.Name = "BBrowser";
            this.BBrowser.Size = new System.Drawing.Size(39, 20);
            this.BBrowser.TabIndex = 2;
            this.BBrowser.Text = "•••";
            this.BBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BBrowser.UseVisualStyleBackColor = true;
            this.BBrowser.Click += new System.EventHandler(this.BBrowser_Click);
            // 
            // BFind
            // 
            this.BFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BFind.Location = new System.Drawing.Point(13, 56);
            this.BFind.Name = "BFind";
            this.BFind.Size = new System.Drawing.Size(274, 29);
            this.BFind.TabIndex = 3;
            this.BFind.Text = "Find";
            this.BFind.UseVisualStyleBackColor = true;
            this.BFind.Click += new System.EventHandler(this.BFind_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameFolder,
            this.Size,
            this.Folders,
            this.Files});
            this.listView1.Location = new System.Drawing.Point(17, 106);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(270, 267);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Name
            // 
            this.NameFolder.Text = "Name";
            this.NameFolder.Width = 67;
            // 
            // Size
            // 
            this.Size.Text = "Size";
            this.Size.Width = 76;
            // 
            // Folders
            // 
            this.Folders.Text = "Folders";
            this.Folders.Width = 80;
            // 
            // Files
            // 
            this.Files.Text = "Files";
            this.Files.Width = 87;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 385);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.BFind);
            this.Controls.Add(this.BBrowser);
            this.Controls.Add(this.FolderBrowser);
            this.Controls.Add(this.Label);
            base.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox FolderBrowser;
        private System.Windows.Forms.Button BBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BFind;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NameFolder;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Folders;
        private System.Windows.Forms.ColumnHeader Files;
    }
}

