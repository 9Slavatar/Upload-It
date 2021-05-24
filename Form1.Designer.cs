
namespace Upload_It_
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
            this.title = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.title.SuspendLayout();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.title.Controls.Add(this.name);
            this.title.Controls.Add(this.exit);
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(230, 30);
            this.title.TabIndex = 0;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.title_MouseDown);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(3, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(78, 21);
            this.name.TabIndex = 1;
            this.name.Text = "Upload It!";
            this.name.MouseDown += new System.Windows.Forms.MouseEventHandler(this.name_MouseDown);
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(195, -4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(30, 34);
            this.exit.TabIndex = 0;
            this.exit.Text = "x";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Open context menu for using this";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(225, 62);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Upload It!";
            this.TopMost = true;
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.title.ResumeLayout(false);
            this.title.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel title;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label1;
    }
}

