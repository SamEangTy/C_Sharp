namespace App1
{
    partial class LoginForm
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.userID = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.bntReset = new System.Windows.Forms.Button();
            this.sadf = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(306, 97);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(202, 22);
            this.txtID.TabIndex = 0;
            this.txtID.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // userID
            // 
            this.userID.AutoSize = true;
            this.userID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userID.Location = new System.Drawing.Point(171, 97);
            this.userID.Name = "userID";
            this.userID.Size = new System.Drawing.Size(88, 25);
            this.userID.TabIndex = 1;
            this.userID.Text = "User ID :";
            this.userID.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(147, 312);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(121, 47);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // bntReset
            // 
            this.bntReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntReset.Location = new System.Drawing.Point(306, 312);
            this.bntReset.Name = "bntReset";
            this.bntReset.Size = new System.Drawing.Size(113, 47);
            this.bntReset.TabIndex = 3;
            this.bntReset.Text = "Reset";
            this.bntReset.UseVisualStyleBackColor = true;
            this.bntReset.Click += new System.EventHandler(this.bntReset_Click);
            // 
            // sadf
            // 
            this.sadf.AutoSize = true;
            this.sadf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sadf.Location = new System.Drawing.Point(169, 145);
            this.sadf.Name = "sadf";
            this.sadf.Size = new System.Drawing.Size(109, 25);
            this.sadf.TabIndex = 5;
            this.sadf.Text = "Password :";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(306, 145);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(202, 22);
            this.Password.TabIndex = 4;
            this.Password.UseSystemPasswordChar = true;
            this.Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Password_KeyPress);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sadf);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.bntReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.userID);
            this.Controls.Add(this.txtID);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label userID;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button bntReset;
        private System.Windows.Forms.Label sadf;
        private System.Windows.Forms.TextBox Password;
    }
}