namespace Ohmaze_level_maker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.result = new System.Windows.Forms.TextBox();
            this.mWidth = new System.Windows.Forms.TextBox();
            this.mHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generator = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.save_image = new System.Windows.Forms.Button();
            this.save_code = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.result.Location = new System.Drawing.Point(6, 406);
            this.result.Multiline = true;
            this.result.Name = "result";
            this.result.ReadOnly = true;
            this.result.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.result.Size = new System.Drawing.Size(323, 238);
            this.result.TabIndex = 1;
            this.result.TextChanged += new System.EventHandler(this.result_TextChanged);
            // 
            // mWidth
            // 
            this.mWidth.Location = new System.Drawing.Point(119, 12);
            this.mWidth.Name = "mWidth";
            this.mWidth.Size = new System.Drawing.Size(118, 20);
            this.mWidth.TabIndex = 3;
            // 
            // mHeight
            // 
            this.mHeight.Location = new System.Drawing.Point(119, 38);
            this.mHeight.Name = "mHeight";
            this.mHeight.Size = new System.Drawing.Size(118, 20);
            this.mHeight.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height";
            // 
            // generator
            // 
            this.generator.Location = new System.Drawing.Point(119, 64);
            this.generator.Name = "generator";
            this.generator.Size = new System.Drawing.Size(118, 23);
            this.generator.TabIndex = 7;
            this.generator.Text = "Generate";
            this.generator.UseVisualStyleBackColor = true;
            this.generator.Click += new System.EventHandler(this.generator_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(72, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 54);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Result:";
            // 
            // save_image
            // 
            this.save_image.Enabled = false;
            this.save_image.Location = new System.Drawing.Point(168, 356);
            this.save_image.Name = "save_image";
            this.save_image.Size = new System.Drawing.Size(75, 23);
            this.save_image.TabIndex = 22;
            this.save_image.Text = "Save image";
            this.save_image.UseVisualStyleBackColor = true;
            this.save_image.Click += new System.EventHandler(this.button14_Click);
            // 
            // save_code
            // 
            this.save_code.Enabled = false;
            this.save_code.Location = new System.Drawing.Point(72, 356);
            this.save_code.Name = "save_code";
            this.save_code.Size = new System.Drawing.Size(75, 23);
            this.save_code.TabIndex = 23;
            this.save_code.Text = "Save code";
            this.save_code.UseVisualStyleBackColor = true;
            this.save_code.Click += new System.EventHandler(this.button12_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.Control;
            this.button11.Image = global::Ohmaze_level_maker.Properties.Resources.bee_up;
            this.button11.Location = new System.Drawing.Point(190, 290);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(53, 54);
            this.button11.TabIndex = 19;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.Control;
            this.button10.Image = global::Ohmaze_level_maker.Properties.Resources.p6;
            this.button10.Location = new System.Drawing.Point(72, 290);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(53, 54);
            this.button10.TabIndex = 18;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Control;
            this.button9.Image = global::Ohmaze_level_maker.Properties.Resources.key_green;
            this.button9.Location = new System.Drawing.Point(190, 230);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(53, 54);
            this.button9.TabIndex = 16;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Control;
            this.button8.Image = global::Ohmaze_level_maker.Properties.Resources.key_red;
            this.button8.Location = new System.Drawing.Point(131, 230);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(53, 54);
            this.button8.TabIndex = 15;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Control;
            this.button7.Image = global::Ohmaze_level_maker.Properties.Resources.key_blue;
            this.button7.Location = new System.Drawing.Point(72, 230);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 54);
            this.button7.TabIndex = 14;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Control;
            this.button6.Image = global::Ohmaze_level_maker.Properties.Resources.lock_green;
            this.button6.Location = new System.Drawing.Point(190, 170);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(53, 54);
            this.button6.TabIndex = 13;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.Image = global::Ohmaze_level_maker.Properties.Resources.lock_red;
            this.button5.Location = new System.Drawing.Point(131, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(53, 54);
            this.button5.TabIndex = 12;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Image = global::Ohmaze_level_maker.Properties.Resources.lock_blue;
            this.button4.Location = new System.Drawing.Point(72, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(53, 54);
            this.button4.TabIndex = 11;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.Image = global::Ohmaze_level_maker.Properties.Resources.finish;
            this.button3.Location = new System.Drawing.Point(190, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(53, 54);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::Ohmaze_level_maker.Properties.Resources.wall;
            this.button2.Location = new System.Drawing.Point(131, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 54);
            this.button2.TabIndex = 9;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Ohmaze_level_maker.Properties.Resources.tile;
            this.pictureBox1.Location = new System.Drawing.Point(335, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(606, 651);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 649);
            this.Controls.Add(this.save_code);
            this.Controls.Add(this.save_image);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.generator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mHeight);
            this.Controls.Add(this.mWidth);
            this.Controls.Add(this.result);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Ohmaze level designer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.TextBox mWidth;
        private System.Windows.Forms.TextBox mHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generator;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button save_image;
        private System.Windows.Forms.Button save_code;
    }
}

