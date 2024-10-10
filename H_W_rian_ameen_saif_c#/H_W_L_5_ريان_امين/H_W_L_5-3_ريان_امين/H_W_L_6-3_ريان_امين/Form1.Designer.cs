namespace H_W_L_6_3_ريان_امين
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
            this.btnclose = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.go_to_down = new System.Windows.Forms.Button();
            this.go_to_front_of = new System.Windows.Forms.Button();
            this.btnbottom = new System.Windows.Forms.Button();
            this.btnfront_of = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnclose.Location = new System.Drawing.Point(576, 387);
            this.btnclose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(87, 57);
            this.btnclose.TabIndex = 11;
            this.btnclose.Text = "إغلاق";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // btnstop
            // 
            this.btnstop.BackColor = System.Drawing.Color.Black;
            this.btnstop.ForeColor = System.Drawing.Color.White;
            this.btnstop.Location = new System.Drawing.Point(559, 322);
            this.btnstop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(114, 57);
            this.btnstop.TabIndex = 10;
            this.btnstop.Text = "stop";
            this.btnstop.UseVisualStyleBackColor = false;
            this.btnstop.Click += new System.EventHandler(this.Btnstop_Click);
            // 
            // go_to_down
            // 
            this.go_to_down.BackColor = System.Drawing.Color.Green;
            this.go_to_down.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_to_down.ForeColor = System.Drawing.Color.White;
            this.go_to_down.Location = new System.Drawing.Point(472, 257);
            this.go_to_down.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.go_to_down.Name = "go_to_down";
            this.go_to_down.Size = new System.Drawing.Size(114, 57);
            this.go_to_down.TabIndex = 9;
            this.go_to_down.Text = "التحرك للأسفل";
            this.go_to_down.UseVisualStyleBackColor = false;
            this.go_to_down.Click += new System.EventHandler(this.Go_to_down_Click);
            // 
            // go_to_front_of
            // 
            this.go_to_front_of.BackColor = System.Drawing.Color.Green;
            this.go_to_front_of.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_to_front_of.ForeColor = System.Drawing.Color.White;
            this.go_to_front_of.Location = new System.Drawing.Point(640, 257);
            this.go_to_front_of.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.go_to_front_of.Name = "go_to_front_of";
            this.go_to_front_of.Size = new System.Drawing.Size(120, 57);
            this.go_to_front_of.TabIndex = 8;
            this.go_to_front_of.Text = "التحرك للامام";
            this.go_to_front_of.UseVisualStyleBackColor = false;
            this.go_to_front_of.Click += new System.EventHandler(this.Go_to_front_of_Click);
            // 
            // btnbottom
            // 
            this.btnbottom.BackColor = System.Drawing.Color.Maroon;
            this.btnbottom.Location = new System.Drawing.Point(12, 61);
            this.btnbottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnbottom.Name = "btnbottom";
            this.btnbottom.Size = new System.Drawing.Size(55, 86);
            this.btnbottom.TabIndex = 7;
            this.btnbottom.Text = "v";
            this.btnbottom.UseVisualStyleBackColor = false;
            // 
            // btnfront_of
            // 
            this.btnfront_of.BackColor = System.Drawing.Color.Maroon;
            this.btnfront_of.Location = new System.Drawing.Point(12, 3);
            this.btnfront_of.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnfront_of.Name = "btnfront_of";
            this.btnfront_of.Size = new System.Drawing.Size(105, 50);
            this.btnfront_of.TabIndex = 6;
            this.btnfront_of.Text = ">";
            this.btnfront_of.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.go_to_down);
            this.Controls.Add(this.go_to_front_of);
            this.Controls.Add(this.btnbottom);
            this.Controls.Add(this.btnfront_of);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Button go_to_down;
        private System.Windows.Forms.Button go_to_front_of;
        private System.Windows.Forms.Button btnbottom;
        private System.Windows.Forms.Button btnfront_of;
    }
}

