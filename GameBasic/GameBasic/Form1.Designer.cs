namespace GameBasic
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
            System.Windows.Forms.Button start;
            this.money = new System.Windows.Forms.TextBox();
            this.btn_recharge = new System.Windows.Forms.Button();
            start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start
            // 
            start.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            start.ForeColor = System.Drawing.Color.DarkTurquoise;
            start.Image = global::GameBasic.Properties.Resources.f8c21fadae8dfc41b2d003f3275f4fba;
            start.Location = new System.Drawing.Point(155, 235);
            start.Name = "start";
            start.Size = new System.Drawing.Size(177, 50);
            start.TabIndex = 0;
            start.Text = "Play";
            start.UseVisualStyleBackColor = true;
            start.Click += new System.EventHandler(this.start_Click);
            // 
            // money
            // 
            this.money.BackColor = System.Drawing.Color.Yellow;
            this.money.Enabled = false;
            this.money.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.money.ForeColor = System.Drawing.Color.Red;
            this.money.Location = new System.Drawing.Point(155, 306);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(177, 22);
            this.money.TabIndex = 1;
            this.money.TextChanged += new System.EventHandler(this.money_TextChanged);
            // 
            // btn_recharge
            // 
            this.btn_recharge.Location = new System.Drawing.Point(375, 416);
            this.btn_recharge.Name = "btn_recharge";
            this.btn_recharge.Size = new System.Drawing.Size(75, 28);
            this.btn_recharge.TabIndex = 2;
            this.btn_recharge.Text = "Nạp tiền";
            this.btn_recharge.UseVisualStyleBackColor = true;
            this.btn_recharge.Click += new System.EventHandler(this.btn_recharge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::GameBasic.Properties.Resources.f8c21fadae8dfc41b2d003f3275f4fba;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(475, 494);
            this.Controls.Add(this.btn_recharge);
            this.Controls.Add(this.money);
            this.Controls.Add(start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Casino";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox money;
        private System.Windows.Forms.Button btn_recharge;
    }
}

