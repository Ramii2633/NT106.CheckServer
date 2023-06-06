namespace CheckServer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            btnCheck = new Button();
            tbHost = new TextBox();
            label2 = new Label();
            cbIsIP = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(576, 375);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCheck
            // 
            btnCheck.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheck.Location = new Point(466, 487);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(112, 42);
            btnCheck.TabIndex = 1;
            btnCheck.Text = "Kiểm tra";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // tbHost
            // 
            tbHost.Location = new Point(180, 429);
            tbHost.Name = "tbHost";
            tbHost.Size = new Size(336, 31);
            tbHost.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 395);
            label2.Name = "label2";
            label2.Size = new Size(232, 25);
            label2.TabIndex = 4;
            label2.Text = "Thông tin máy cần kiểm tra:";
            // 
            // cbIsIP
            // 
            cbIsIP.AutoSize = true;
            cbIsIP.Location = new Point(61, 431);
            cbIsIP.Name = "cbIsIP";
            cbIsIP.Size = new Size(115, 29);
            cbIsIP.TabIndex = 5;
            cbIsIP.Text = "Địa chỉ IP:";
            cbIsIP.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 538);
            Controls.Add(cbIsIP);
            Controls.Add(label2);
            Controls.Add(tbHost);
            Controls.Add(btnCheck);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Kiểm tra dịch vụ FTP";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnCheck;
        private TextBox tbHost;
        private Label label2;
        private CheckBox cbIsIP;
    }
}