namespace oct5mathquiz
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
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plusLeftLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plusRightLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sum = new System.Windows.Forms.NumericUpDown();
            this.quotient = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.divRightLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.divLeftLabel = new System.Windows.Forms.Label();
            this.product = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.mulRightLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.mulLeftLabel = new System.Windows.Forms.Label();
            this.difference = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.minusRightLabel = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.minusLeftLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(346, 10);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(213, 48);
            this.timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left:";
            // 
            // plusLeftLabel
            // 
            this.plusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusLeftLabel.Location = new System.Drawing.Point(-6, 69);
            this.plusLeftLabel.Name = "plusLeftLabel";
            this.plusLeftLabel.Size = new System.Drawing.Size(97, 50);
            this.plusLeftLabel.TabIndex = 2;
            this.plusLeftLabel.Text = "?";
            this.plusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusLeftLabel.Click += new System.EventHandler(this.plusLeftLabel_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(253, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // plusRightLabel
            // 
            this.plusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusRightLabel.Location = new System.Drawing.Point(125, 73);
            this.plusRightLabel.Name = "plusRightLabel";
            this.plusRightLabel.Size = new System.Drawing.Size(106, 42);
            this.plusRightLabel.TabIndex = 4;
            this.plusRightLabel.Text = "?";
            this.plusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plusRightLabel.Click += new System.EventHandler(this.plusRightLabel_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "+";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // sum
            // 
            this.sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sum.Location = new System.Drawing.Point(359, 65);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(200, 62);
            this.sum.TabIndex = 2;
            this.sum.ValueChanged += new System.EventHandler(this.sum_ValueChanged);
            this.sum.Enter += new System.EventHandler(this.sum_Enter);
            // 
            // quotient
            // 
            this.quotient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quotient.Location = new System.Drawing.Point(359, 267);
            this.quotient.Name = "quotient";
            this.quotient.Size = new System.Drawing.Size(200, 62);
            this.quotient.TabIndex = 5;
            this.quotient.Enter += new System.EventHandler(this.sum_Enter);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 10;
            this.label3.Text = "/";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divRightLabel
            // 
            this.divRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divRightLabel.Location = new System.Drawing.Point(135, 287);
            this.divRightLabel.Name = "divRightLabel";
            this.divRightLabel.Size = new System.Drawing.Size(84, 42);
            this.divRightLabel.TabIndex = 9;
            this.divRightLabel.Text = "?";
            this.divRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(253, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 8;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // divLeftLabel
            // 
            this.divLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divLeftLabel.Location = new System.Drawing.Point(-8, 283);
            this.divLeftLabel.Name = "divLeftLabel";
            this.divLeftLabel.Size = new System.Drawing.Size(99, 50);
            this.divLeftLabel.TabIndex = 7;
            this.divLeftLabel.Text = "?";
            this.divLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // product
            // 
            this.product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.product.Location = new System.Drawing.Point(359, 199);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(200, 62);
            this.product.TabIndex = 4;
            this.product.Enter += new System.EventHandler(this.sum_Enter);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(69, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 50);
            this.label8.TabIndex = 15;
            this.label8.Text = "*";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mulRightLabel
            // 
            this.mulRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulRightLabel.Location = new System.Drawing.Point(135, 216);
            this.mulRightLabel.Name = "mulRightLabel";
            this.mulRightLabel.Size = new System.Drawing.Size(84, 42);
            this.mulRightLabel.TabIndex = 14;
            this.mulRightLabel.Text = "?";
            this.mulRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(253, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 13;
            this.label10.Text = "=";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mulLeftLabel
            // 
            this.mulLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mulLeftLabel.Location = new System.Drawing.Point(-10, 216);
            this.mulLeftLabel.Name = "mulLeftLabel";
            this.mulLeftLabel.Size = new System.Drawing.Size(101, 50);
            this.mulLeftLabel.TabIndex = 12;
            this.mulLeftLabel.Text = "?";
            this.mulLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // difference
            // 
            this.difference.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.Location = new System.Drawing.Point(359, 133);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(200, 62);
            this.difference.TabIndex = 3;
            this.difference.Enter += new System.EventHandler(this.sum_Enter);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(69, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 50);
            this.label12.TabIndex = 20;
            this.label12.Text = "-";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusRightLabel
            // 
            this.minusRightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusRightLabel.Location = new System.Drawing.Point(135, 141);
            this.minusRightLabel.Name = "minusRightLabel";
            this.minusRightLabel.Size = new System.Drawing.Size(96, 42);
            this.minusRightLabel.TabIndex = 19;
            this.minusRightLabel.Text = "?";
            this.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(253, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 50);
            this.label14.TabIndex = 18;
            this.label14.Text = "=";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // minusLeftLabel
            // 
            this.minusLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusLeftLabel.Location = new System.Drawing.Point(-3, 137);
            this.minusLeftLabel.Name = "minusLeftLabel";
            this.minusLeftLabel.Size = new System.Drawing.Size(88, 50);
            this.minusLeftLabel.TabIndex = 17;
            this.minusLeftLabel.Text = "?";
            this.minusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(145, 366);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(293, 60);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start the quiz";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 497);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.minusRightLabel);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.minusLeftLabel);
            this.Controls.Add(this.product);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mulRightLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.mulLeftLabel);
            this.Controls.Add(this.quotient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.divRightLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.divLeftLabel);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.plusRightLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.plusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mathquiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label plusLeftLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label plusRightLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown sum;
        private System.Windows.Forms.NumericUpDown quotient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label divRightLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label divLeftLabel;
        private System.Windows.Forms.NumericUpDown product;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label mulRightLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label mulLeftLabel;
        private System.Windows.Forms.NumericUpDown difference;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label minusRightLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label minusLeftLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}

