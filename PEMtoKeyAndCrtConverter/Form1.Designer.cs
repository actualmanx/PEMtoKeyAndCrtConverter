namespace PEMtoKeyAndCrtConverter
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
            txtPrivKeyPath = new TextBox();
            txtFullChainPath = new TextBox();
            btnBrowsePrivKey = new Button();
            btnBrowseFullChain = new Button();
            btnConvert = new Button();
            openFileDialog1 = new OpenFileDialog();
            statusStrip1 = new StatusStrip();
            lblStatus = new ToolStripStatusLabel();
            txtKeyFilename = new TextBox();
            txtCrtFilename = new TextBox();
            btnBrowseKeyOutput = new Button();
            btnBrowseCrtOutput = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPrivKeyPath
            // 
            txtPrivKeyPath.Location = new Point(14, 41);
            txtPrivKeyPath.Name = "txtPrivKeyPath";
            txtPrivKeyPath.ReadOnly = true;
            txtPrivKeyPath.Size = new Size(150, 31);
            txtPrivKeyPath.TabIndex = 7;
            // 
            // txtFullChainPath
            // 
            txtFullChainPath.Location = new Point(14, 118);
            txtFullChainPath.Name = "txtFullChainPath";
            txtFullChainPath.ReadOnly = true;
            txtFullChainPath.Size = new Size(150, 31);
            txtFullChainPath.TabIndex = 8;
            // 
            // btnBrowsePrivKey
            // 
            btnBrowsePrivKey.Location = new Point(244, 38);
            btnBrowsePrivKey.Name = "btnBrowsePrivKey";
            btnBrowsePrivKey.Size = new Size(146, 34);
            btnBrowsePrivKey.TabIndex = 3;
            btnBrowsePrivKey.Text = "Privkey.Pem";
            btnBrowsePrivKey.UseVisualStyleBackColor = true;
            btnBrowsePrivKey.Click += btnBrowsePrivKey_Click;
            // 
            // btnBrowseFullChain
            // 
            btnBrowseFullChain.Location = new Point(244, 118);
            btnBrowseFullChain.Name = "btnBrowseFullChain";
            btnBrowseFullChain.Size = new Size(146, 34);
            btnBrowseFullChain.TabIndex = 4;
            btnBrowseFullChain.Text = "Fullchain.Pem";
            btnBrowseFullChain.UseVisualStyleBackColor = true;
            btnBrowseFullChain.Click += btnBrowseFullChain_Click;
            // 
            // btnConvert
            // 
            btnConvert.Location = new Point(634, 361);
            btnConvert.Name = "btnConvert";
            btnConvert.Size = new Size(146, 34);
            btnConvert.TabIndex = 0;
            btnConvert.Text = "Convert All";
            btnConvert.UseVisualStyleBackColor = true;
            btnConvert.Click += btnConvert_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatus });
            statusStrip1.Location = new Point(0, 418);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 32);
            statusStrip1.TabIndex = 7;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.Text = "Status";
            // 
            // txtKeyFilename
            // 
            txtKeyFilename.Location = new Point(462, 40);
            txtKeyFilename.Name = "txtKeyFilename";
            txtKeyFilename.Size = new Size(150, 31);
            txtKeyFilename.TabIndex = 5;
            txtKeyFilename.Text = "private.key";
            // 
            // txtCrtFilename
            // 
            txtCrtFilename.Location = new Point(464, 120);
            txtCrtFilename.Name = "txtCrtFilename";
            txtCrtFilename.Size = new Size(150, 31);
            txtCrtFilename.TabIndex = 6;
            txtCrtFilename.Text = "certificate.crt";
            // 
            // btnBrowseKeyOutput
            // 
            btnBrowseKeyOutput.Location = new Point(668, 37);
            btnBrowseKeyOutput.Name = "btnBrowseKeyOutput";
            btnBrowseKeyOutput.Size = new Size(112, 34);
            btnBrowseKeyOutput.TabIndex = 1;
            btnBrowseKeyOutput.Text = "Save As";
            btnBrowseKeyOutput.UseVisualStyleBackColor = true;
            btnBrowseKeyOutput.Click += btnBrowseKeyOutput_Click;
            // 
            // btnBrowseCrtOutput
            // 
            btnBrowseCrtOutput.Location = new Point(668, 120);
            btnBrowseCrtOutput.Name = "btnBrowseCrtOutput";
            btnBrowseCrtOutput.Size = new Size(112, 34);
            btnBrowseCrtOutput.TabIndex = 2;
            btnBrowseCrtOutput.Text = "Save As";
            btnBrowseCrtOutput.UseVisualStyleBackColor = true;
            btnBrowseCrtOutput.Click += btnBrowseCrtOutput_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(244, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 12;
            label1.Text = "Open";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 87);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 13;
            label2.Text = "Open";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(462, 9);
            label3.Name = "label3";
            label3.Size = new Size(152, 25);
            label3.TabIndex = 14;
            label3.Text = "Output File Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(462, 87);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 15;
            label4.Text = "Output File Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 9);
            label5.Name = "label5";
            label5.Size = new Size(86, 25);
            label5.TabIndex = 16;
            label5.Text = "FIle Input";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 87);
            label6.Name = "label6";
            label6.Size = new Size(86, 25);
            label6.TabIndex = 17;
            label6.Text = "FIle Input";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBrowseCrtOutput);
            Controls.Add(btnBrowseKeyOutput);
            Controls.Add(txtCrtFilename);
            Controls.Add(txtKeyFilename);
            Controls.Add(statusStrip1);
            Controls.Add(btnConvert);
            Controls.Add(btnBrowseFullChain);
            Controls.Add(btnBrowsePrivKey);
            Controls.Add(txtFullChainPath);
            Controls.Add(txtPrivKeyPath);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Pem To Key & Crt";
            Load += Form1_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrivKeyPath;
        private TextBox txtFullChainPath;
        private Button btnBrowsePrivKey;
        private Button btnBrowseFullChain;
        private Button btnConvert;
        private OpenFileDialog openFileDialog1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatus;
        private TextBox txtKeyFilename;
        private TextBox txtCrtFilename;
        private Button btnBrowseKeyOutput;
        private Button btnBrowseCrtOutput;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
