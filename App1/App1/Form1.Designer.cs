namespace App1
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
            this.lbHello = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.btnConcel = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbHello
            // 
            this.lbHello.AutoSize = true;
            this.lbHello.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHello.Location = new System.Drawing.Point(63, 80);
            this.lbHello.Name = "lbHello";
            this.lbHello.Size = new System.Drawing.Size(147, 54);
            this.lbHello.TabIndex = 0;
            this.lbHello.Text = "label1";
            this.lbHello.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSet.Location = new System.Drawing.Point(63, 353);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(94, 47);
            this.btnSet.TabIndex = 1;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // btnConcel
            // 
            this.btnConcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcel.Location = new System.Drawing.Point(196, 353);
            this.btnConcel.Name = "btnConcel";
            this.btnConcel.Size = new System.Drawing.Size(156, 47);
            this.btnConcel.TabIndex = 2;
            this.btnConcel.Text = "Concel";
            this.btnConcel.UseVisualStyleBackColor = true;
            this.btnConcel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(654, 353);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(134, 47);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnConcel);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.lbHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbHello;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Button btnConcel;
        private System.Windows.Forms.Button btnLogout;
    }
}

