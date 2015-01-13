namespace HazLog
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
            this.btntree = new System.Windows.Forms.Button();
            this.btnblue = new System.Windows.Forms.Button();
            this.btnmap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btntree
            // 
            this.btntree.Location = new System.Drawing.Point(369, 12);
            this.btntree.Name = "btntree";
            this.btntree.Size = new System.Drawing.Size(75, 23);
            this.btntree.TabIndex = 0;
            this.btntree.Text = "Tree";
            this.btntree.UseVisualStyleBackColor = true;
            this.btntree.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnblue
            // 
            this.btnblue.Location = new System.Drawing.Point(450, 12);
            this.btnblue.Name = "btnblue";
            this.btnblue.Size = new System.Drawing.Size(75, 23);
            this.btnblue.TabIndex = 1;
            this.btnblue.Text = "BluePrint";
            this.btnblue.UseVisualStyleBackColor = true;
            // 
            // btnmap
            // 
            this.btnmap.Location = new System.Drawing.Point(531, 12);
            this.btnmap.Name = "btnmap";
            this.btnmap.Size = new System.Drawing.Size(75, 23);
            this.btnmap.TabIndex = 2;
            this.btnmap.Text = "MindMap";
            this.btnmap.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 246);
            this.Controls.Add(this.btnmap);
            this.Controls.Add(this.btnblue);
            this.Controls.Add(this.btntree);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btntree;
        private System.Windows.Forms.Button btnblue;
        private System.Windows.Forms.Button btnmap;
    }
}

