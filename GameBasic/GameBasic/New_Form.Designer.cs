namespace GameBasic
{
    partial class New_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_Form));
            this.number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.even = new System.Windows.Forms.Button();
            this.odd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.unmute = new System.Windows.Forms.PictureBox();
            this.mute = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cuoc2 = new System.Windows.Forms.RadioButton();
            this.cuoc4 = new System.Windows.Forms.RadioButton();
            this.cuoc5 = new System.Windows.Forms.RadioButton();
            this.cuoc10 = new System.Windows.Forms.RadioButton();
            this.label = new System.Windows.Forms.Label();
            this.your_money = new System.Windows.Forms.Label();
            this.recharge = new System.Windows.Forms.Button();
            this.tien_no = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute)).BeginInit();
            this.SuspendLayout();
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number.HideSelection = false;
            this.number.Location = new System.Drawing.Point(171, 58);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(158, 29);
            this.number.TabIndex = 0;
            this.number.TextChanged += new System.EventHandler(this.equal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(7, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số tiền bạn đặt($)";
            // 
            // even
            // 
            this.even.AutoSize = true;
            this.even.BackColor = System.Drawing.Color.DarkGray;
            this.even.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.even.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.even.Location = new System.Drawing.Point(16, 130);
            this.even.Name = "even";
            this.even.Size = new System.Drawing.Size(78, 69);
            this.even.TabIndex = 2;
            this.even.Text = "Chẵn";
            this.even.UseVisualStyleBackColor = false;
            this.even.Click += new System.EventHandler(this.even_Click);
            // 
            // odd
            // 
            this.odd.AutoSize = true;
            this.odd.BackColor = System.Drawing.Color.DarkGray;
            this.odd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.odd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.odd.Location = new System.Drawing.Point(464, 139);
            this.odd.Name = "odd";
            this.odd.Size = new System.Drawing.Size(78, 69);
            this.odd.TabIndex = 3;
            this.odd.Text = "Lẻ";
            this.odd.UseVisualStyleBackColor = false;
            this.odd.Click += new System.EventHandler(this.odd_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(100, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 105);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(255, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(99, 100);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 100);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(211, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 40);
            this.button3.TabIndex = 6;
            this.button3.Text = "Roll";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Roll);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(180, 301);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 32);
            this.textBox2.TabIndex = 7;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // unmute
            // 
            this.unmute.Image = global::GameBasic.Properties.Resources.unmute;
            this.unmute.Location = new System.Drawing.Point(524, 16);
            this.unmute.Name = "unmute";
            this.unmute.Size = new System.Drawing.Size(27, 26);
            this.unmute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.unmute.TabIndex = 10;
            this.unmute.TabStop = false;
            this.unmute.Click += new System.EventHandler(this.unmute_Click);
            // 
            // mute
            // 
            this.mute.Image = global::GameBasic.Properties.Resources.Mute_PNG_Pic1;
            this.mute.Location = new System.Drawing.Point(490, 15);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(27, 27);
            this.mute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mute.TabIndex = 9;
            this.mute.TabStop = false;
            this.mute.Click += new System.EventHandler(this.enable_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(25, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tổng";
            // 
            // cuoc2
            // 
            this.cuoc2.AutoSize = true;
            this.cuoc2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cuoc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cuoc2.Location = new System.Drawing.Point(100, 252);
            this.cuoc2.Name = "cuoc2";
            this.cuoc2.Size = new System.Drawing.Size(49, 24);
            this.cuoc2.TabIndex = 13;
            this.cuoc2.TabStop = true;
            this.cuoc2.Text = "X2";
            this.cuoc2.UseVisualStyleBackColor = false;
            // 
            // cuoc4
            // 
            this.cuoc4.AutoSize = true;
            this.cuoc4.BackColor = System.Drawing.Color.GhostWhite;
            this.cuoc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cuoc4.Location = new System.Drawing.Point(189, 252);
            this.cuoc4.Name = "cuoc4";
            this.cuoc4.Size = new System.Drawing.Size(49, 24);
            this.cuoc4.TabIndex = 14;
            this.cuoc4.TabStop = true;
            this.cuoc4.Text = "X4";
            this.cuoc4.UseVisualStyleBackColor = false;
            // 
            // cuoc5
            // 
            this.cuoc5.AutoSize = true;
            this.cuoc5.BackColor = System.Drawing.Color.Honeydew;
            this.cuoc5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cuoc5.Location = new System.Drawing.Point(280, 252);
            this.cuoc5.Name = "cuoc5";
            this.cuoc5.Size = new System.Drawing.Size(49, 24);
            this.cuoc5.TabIndex = 15;
            this.cuoc5.TabStop = true;
            this.cuoc5.Text = "X5";
            this.cuoc5.UseVisualStyleBackColor = false;
            // 
            // cuoc10
            // 
            this.cuoc10.AutoSize = true;
            this.cuoc10.BackColor = System.Drawing.Color.Honeydew;
            this.cuoc10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cuoc10.Location = new System.Drawing.Point(373, 252);
            this.cuoc10.Name = "cuoc10";
            this.cuoc10.Size = new System.Drawing.Size(59, 24);
            this.cuoc10.TabIndex = 16;
            this.cuoc10.TabStop = true;
            this.cuoc10.Text = "X10";
            this.cuoc10.UseVisualStyleBackColor = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label.Location = new System.Drawing.Point(7, 18);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(158, 24);
            this.label.TabIndex = 8;
            this.label.Text = "Số tiền bạn có ($)";
            // 
            // your_money
            // 
            this.your_money.AutoSize = true;
            this.your_money.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.your_money.Location = new System.Drawing.Point(170, 18);
            this.your_money.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.your_money.Name = "your_money";
            this.your_money.Size = new System.Drawing.Size(0, 24);
            this.your_money.TabIndex = 17;
            this.your_money.Click += new System.EventHandler(this.your_money_Click);
            // 
            // recharge
            // 
            this.recharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.recharge.ForeColor = System.Drawing.Color.Red;
            this.recharge.Location = new System.Drawing.Point(395, 11);
            this.recharge.Margin = new System.Windows.Forms.Padding(2);
            this.recharge.Name = "recharge";
            this.recharge.Size = new System.Drawing.Size(80, 32);
            this.recharge.TabIndex = 18;
            this.recharge.Text = "Nạp tiền";
            this.recharge.UseVisualStyleBackColor = true;
            this.recharge.Click += new System.EventHandler(this.recharge_Click);
            // 
            // tien_no
            // 
            this.tien_no.AutoSize = true;
            this.tien_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tien_no.ForeColor = System.Drawing.Color.Red;
            this.tien_no.Location = new System.Drawing.Point(498, 399);
            this.tien_no.Name = "tien_no";
            this.tien_no.Size = new System.Drawing.Size(0, 24);
            this.tien_no.TabIndex = 20;
            // 
            // New_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(569, 431);
            this.Controls.Add(this.tien_no);
            this.Controls.Add(this.recharge);
            this.Controls.Add(this.your_money);
            this.Controls.Add(this.cuoc10);
            this.Controls.Add(this.cuoc5);
            this.Controls.Add(this.cuoc4);
            this.Controls.Add(this.cuoc2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unmute);
            this.Controls.Add(this.mute);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.odd);
            this.Controls.Add(this.even);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.number);
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.MaximizeBox = false;
            this.Name = "New_Form";
            this.Text = "Casino";
            this.Load += new System.EventHandler(this.OnPageLoad);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unmute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button even;
        private System.Windows.Forms.Button odd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.PictureBox mute;
        private System.Windows.Forms.PictureBox unmute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton cuoc2;
        private System.Windows.Forms.RadioButton cuoc4;
        private System.Windows.Forms.RadioButton cuoc5;
        private System.Windows.Forms.RadioButton cuoc10;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label your_money;
        private System.Windows.Forms.Button recharge;
        private System.Windows.Forms.Label tien_no;
    }
}