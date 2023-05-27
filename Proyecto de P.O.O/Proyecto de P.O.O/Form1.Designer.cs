namespace Proyecto_de_P.O.O
{
    partial class FrmLog_in
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLog_in));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbxMinimize = new System.Windows.Forms.PictureBox();
            this.ptbxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbxUsername = new System.Windows.Forms.TextBox();
            this.txbxPassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ErrorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            this.TtpMessage = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.ptbxMinimize);
            this.panel1.Controls.Add(this.ptbxClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 37);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // ptbxMinimize
            // 
            this.ptbxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("ptbxMinimize.Image")));
            this.ptbxMinimize.Location = new System.Drawing.Point(730, 3);
            this.ptbxMinimize.Name = "ptbxMinimize";
            this.ptbxMinimize.Size = new System.Drawing.Size(27, 31);
            this.ptbxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxMinimize.TabIndex = 4;
            this.ptbxMinimize.TabStop = false;
            this.ptbxMinimize.Click += new System.EventHandler(this.ptbxMinimize_Click);
            // 
            // ptbxClose
            // 
            this.ptbxClose.Image = ((System.Drawing.Image)(resources.GetObject("ptbxClose.Image")));
            this.ptbxClose.Location = new System.Drawing.Point(765, 3);
            this.ptbxClose.Name = "ptbxClose";
            this.ptbxClose.Size = new System.Drawing.Size(32, 31);
            this.ptbxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbxClose.TabIndex = 3;
            this.ptbxClose.TabStop = false;
            this.ptbxClose.Click += new System.EventHandler(this.ptbxClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Log in";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Proyecto_de_P.O.O.Properties.Resources.Imagen_de_High_School_entrada;
            this.pictureBox1.Location = new System.Drawing.Point(0, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 413);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(436, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Don´t have a login?";
            // 
            // txbxUsername
            // 
            this.txbxUsername.BackColor = System.Drawing.Color.Gray;
            this.txbxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txbxUsername.Location = new System.Drawing.Point(370, 143);
            this.txbxUsername.Name = "txbxUsername";
            this.txbxUsername.Size = new System.Drawing.Size(401, 27);
            this.txbxUsername.TabIndex = 4;
            this.txbxUsername.Text = "Username";
            this.txbxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbxUsername.Enter += new System.EventHandler(this.tbxUsername_Enter);
            this.txbxUsername.Leave += new System.EventHandler(this.txbxUsername_Leave);
            // 
            // txbxPassword
            // 
            this.txbxPassword.BackColor = System.Drawing.Color.Gray;
            this.txbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbxPassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txbxPassword.Location = new System.Drawing.Point(370, 202);
            this.txbxPassword.Name = "txbxPassword";
            this.txbxPassword.Size = new System.Drawing.Size(401, 27);
            this.txbxPassword.TabIndex = 5;
            this.txbxPassword.Text = "Password";
            this.txbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbxPassword.TextChanged += new System.EventHandler(this.txbxPassword_TextChanged);
            this.txbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            this.txbxPassword.Leave += new System.EventHandler(this.txbxPassword_Leave);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogin.Font = new System.Drawing.Font("Forte", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(406, 287);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(328, 32);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Start";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dubai Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(493, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter your date";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Dubai Medium", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(593, 372);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(110, 25);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "CreateAcount";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // ErrorIcon
            // 
            this.ErrorIcon.ContainerControl = this;
            // 
            // FrmLog_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txbxPassword);
            this.Controls.Add(this.txbxUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLog_in";
            this.Text = "Log in";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private PictureBox ptbxMinimize;
        private PictureBox ptbxClose;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox txbxUsername;
        private TextBox txbxPassword;
        private Button btnlogin;
        private Label label3;
        private LinkLabel linkLabel1;
        private ErrorProvider ErrorIcon;
        private ToolTip TtpMessage;
    }
}