namespace Cinema_reservation_system
{
    partial class forgotpass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotpass));
            this.newpasswordlabel = new System.Windows.Forms.Label();
            this.hintlable = new System.Windows.Forms.Label();
            this.questionlabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.hinttextbox = new System.Windows.Forms.TextBox();
            this.newpasswordtextbox = new System.Windows.Forms.TextBox();
            this.closebutton = new System.Windows.Forms.Button();
            this.resetbutton = new System.Windows.Forms.Button();
            this.answerlabel = new System.Windows.Forms.Label();
            this.usernameerror = new System.Windows.Forms.ErrorProvider(this.components);
            this.passworderror = new System.Windows.Forms.ErrorProvider(this.components);
            this.hinterror = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.resetviewbutton = new System.Windows.Forms.Button();
            this.usernamelabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameerror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passworderror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinterror)).BeginInit();
            this.SuspendLayout();
            // 
            // newpasswordlabel
            // 
            this.newpasswordlabel.AutoSize = true;
            this.newpasswordlabel.BackColor = System.Drawing.Color.Transparent;
            this.newpasswordlabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newpasswordlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.newpasswordlabel.Location = new System.Drawing.Point(77, 278);
            this.newpasswordlabel.Name = "newpasswordlabel";
            this.newpasswordlabel.Size = new System.Drawing.Size(175, 25);
            this.newpasswordlabel.TabIndex = 17;
            this.newpasswordlabel.Text = "🔒New Password";
            this.newpasswordlabel.Visible = false;
            // 
            // hintlable
            // 
            this.hintlable.AutoSize = true;
            this.hintlable.BackColor = System.Drawing.Color.Transparent;
            this.hintlable.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hintlable.ForeColor = System.Drawing.Color.Gainsboro;
            this.hintlable.Location = new System.Drawing.Point(77, 152);
            this.hintlable.Name = "hintlable";
            this.hintlable.Size = new System.Drawing.Size(51, 25);
            this.hintlable.TabIndex = 18;
            this.hintlable.Text = "Hint";
            this.hintlable.Visible = false;
            // 
            // questionlabel
            // 
            this.questionlabel.AutoSize = true;
            this.questionlabel.BackColor = System.Drawing.Color.Transparent;
            this.questionlabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questionlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.questionlabel.Location = new System.Drawing.Point(293, 152);
            this.questionlabel.Name = "questionlabel";
            this.questionlabel.Size = new System.Drawing.Size(17, 25);
            this.questionlabel.TabIndex = 19;
            this.questionlabel.Text = ".";
            this.questionlabel.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(639, 388);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // usernametextbox
            // 
            this.usernametextbox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernametextbox.ForeColor = System.Drawing.Color.Black;
            this.usernametextbox.Location = new System.Drawing.Point(298, 98);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(191, 20);
            this.usernametextbox.TabIndex = 22;
            // 
            // hinttextbox
            // 
            this.hinttextbox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hinttextbox.ForeColor = System.Drawing.Color.Black;
            this.hinttextbox.Location = new System.Drawing.Point(298, 214);
            this.hinttextbox.Name = "hinttextbox";
            this.hinttextbox.Size = new System.Drawing.Size(191, 20);
            this.hinttextbox.TabIndex = 23;
            this.hinttextbox.Visible = false;
            // 
            // newpasswordtextbox
            // 
            this.newpasswordtextbox.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newpasswordtextbox.ForeColor = System.Drawing.Color.Black;
            this.newpasswordtextbox.Location = new System.Drawing.Point(298, 278);
            this.newpasswordtextbox.Name = "newpasswordtextbox";
            this.newpasswordtextbox.PasswordChar = '.';
            this.newpasswordtextbox.Size = new System.Drawing.Size(191, 20);
            this.newpasswordtextbox.TabIndex = 24;
            this.newpasswordtextbox.Visible = false;
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closebutton.Location = new System.Drawing.Point(509, 325);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(97, 35);
            this.closebutton.TabIndex = 27;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.resetbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetbutton.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetbutton.Location = new System.Drawing.Point(208, 325);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(102, 35);
            this.resetbutton.TabIndex = 26;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Visible = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click_1);
            // 
            // answerlabel
            // 
            this.answerlabel.AutoSize = true;
            this.answerlabel.BackColor = System.Drawing.Color.Transparent;
            this.answerlabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answerlabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.answerlabel.Location = new System.Drawing.Point(77, 209);
            this.answerlabel.Name = "answerlabel";
            this.answerlabel.Size = new System.Drawing.Size(161, 25);
            this.answerlabel.TabIndex = 28;
            this.answerlabel.Text = "Security Answer";
            this.answerlabel.Visible = false;
            // 
            // usernameerror
            // 
            this.usernameerror.ContainerControl = this;
            // 
            // passworderror
            // 
            this.passworderror.ContainerControl = this;
            // 
            // hinterror
            // 
            this.hinterror.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // resetviewbutton
            // 
            this.resetviewbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(201)))), ((int)(((byte)(187)))));
            this.resetviewbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetviewbutton.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetviewbutton.Location = new System.Drawing.Point(213, 147);
            this.resetviewbutton.Name = "resetviewbutton";
            this.resetviewbutton.Size = new System.Drawing.Size(97, 35);
            this.resetviewbutton.TabIndex = 30;
            this.resetviewbutton.Text = "Reset";
            this.resetviewbutton.UseVisualStyleBackColor = false;
            this.resetviewbutton.Click += new System.EventHandler(this.resetviewbutton_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernamelabel.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernamelabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.usernamelabel.Location = new System.Drawing.Point(77, 93);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(137, 25);
            this.usernamelabel.TabIndex = 31;
            this.usernamelabel.Text = "👨User name";
            // 
            // forgotpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(633, 382);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.resetviewbutton);
            this.Controls.Add(this.answerlabel);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.newpasswordtextbox);
            this.Controls.Add(this.hinttextbox);
            this.Controls.Add(this.usernametextbox);
            this.Controls.Add(this.questionlabel);
            this.Controls.Add(this.hintlable);
            this.Controls.Add(this.newpasswordlabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "forgotpass";
            this.Text = "forgotpass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernameerror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passworderror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hinterror)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label newpasswordlabel;
        private System.Windows.Forms.Label hintlable;
        private System.Windows.Forms.Label questionlabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox usernametextbox;
        public System.Windows.Forms.TextBox hinttextbox;
        public System.Windows.Forms.TextBox newpasswordtextbox;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.Label answerlabel;
        private System.Windows.Forms.ErrorProvider usernameerror;
        private System.Windows.Forms.ErrorProvider passworderror;
        private System.Windows.Forms.ErrorProvider hinterror;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button resetviewbutton;
        private System.Windows.Forms.Label usernamelabel;
    }
}