namespace Cinema_reservation_system
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closebutton = new System.Windows.Forms.Button();
            this.loginbutton = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.forgotpasslabel = new System.Windows.Forms.Label();
            this.usernameerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.passworderror = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passworderror)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(630, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closebutton.Location = new System.Drawing.Point(200, 257);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(97, 35);
            this.closebutton.TabIndex = 19;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginbutton.Location = new System.Drawing.Point(343, 257);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(102, 35);
            this.loginbutton.TabIndex = 18;
            this.loginbutton.Text = "login";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernamelabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernamelabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.usernamelabel.Location = new System.Drawing.Point(172, 119);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(137, 25);
            this.usernamelabel.TabIndex = 14;
            this.usernamelabel.Text = "👨User name";
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.ForeColor = System.Drawing.Color.Black;
            this.passwordtextbox.Location = new System.Drawing.Point(323, 171);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.PasswordChar = '*';
            this.passwordtextbox.Size = new System.Drawing.Size(191, 20);
            this.passwordtextbox.TabIndex = 17;
            // 
            // usernametextbox
            // 
            this.usernametextbox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernametextbox.ForeColor = System.Drawing.Color.Black;
            this.usernametextbox.Location = new System.Drawing.Point(323, 119);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(191, 20);
            this.usernametextbox.TabIndex = 16;
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordlabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.passwordlabel.Location = new System.Drawing.Point(172, 171);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(128, 25);
            this.passwordlabel.TabIndex = 15;
            this.passwordlabel.Text = "🔒Password";
            // 
            // forgotpasslabel
            // 
            this.forgotpasslabel.AutoSize = true;
            this.forgotpasslabel.BackColor = System.Drawing.Color.Transparent;
            this.forgotpasslabel.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.forgotpasslabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.forgotpasslabel.Location = new System.Drawing.Point(197, 206);
            this.forgotpasslabel.Name = "forgotpasslabel";
            this.forgotpasslabel.Size = new System.Drawing.Size(128, 18);
            this.forgotpasslabel.TabIndex = 20;
            this.forgotpasslabel.Text = "Forgot Password?";
            this.forgotpasslabel.Click += new System.EventHandler(this.forgotpasslabel_Click);
            // 
            // usernameerror
            // 
            this.usernameerror.ContainerControl = this;
            // 
            // passworderror
            // 
            this.passworderror.ContainerControl = this;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 384);
            this.Controls.Add(this.forgotpasslabel);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.passwordlabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "login";
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passworderror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Label usernamelabel;
        public System.Windows.Forms.TextBox passwordtextbox;
        public System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label forgotpasslabel;
        private System.Windows.Forms.ErrorProvider usernameerror;
        private System.Windows.Forms.ErrorProvider passworderror;
    }
}