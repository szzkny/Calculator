namespace Calculator
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.lbl_display = new System.Windows.Forms.Label();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_backspace = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_extract = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_polarity = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_display
            // 
            this.lbl_display.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_display.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_display.Location = new System.Drawing.Point(60, 34);
            this.lbl_display.Name = "lbl_display";
            this.lbl_display.Size = new System.Drawing.Size(489, 50);
            this.lbl_display.TabIndex = 0;
            this.lbl_display.Text = "0123456789";
            this.lbl_display.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_7.Location = new System.Drawing.Point(60, 119);
            this.btn_7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(63, 48);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_8.Location = new System.Drawing.Point(151, 119);
            this.btn_8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(63, 48);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_9.Location = new System.Drawing.Point(245, 119);
            this.btn_9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(63, 48);
            this.btn_9.TabIndex = 3;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_backspace
            // 
            this.btn_backspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_backspace.Location = new System.Drawing.Point(486, 119);
            this.btn_backspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(63, 48);
            this.btn_backspace.TabIndex = 4;
            this.btn_backspace.Text = "<--";
            this.btn_backspace.UseVisualStyleBackColor = true;
            this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_add.Location = new System.Drawing.Point(404, 119);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(63, 48);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn_extract
            // 
            this.btn_extract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_extract.Location = new System.Drawing.Point(404, 178);
            this.btn_extract.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_extract.Name = "btn_extract";
            this.btn_extract.Size = new System.Drawing.Size(63, 48);
            this.btn_extract.TabIndex = 10;
            this.btn_extract.Text = "-";
            this.btn_extract.UseVisualStyleBackColor = true;
            this.btn_extract.Click += new System.EventHandler(this.operator_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_clear.Location = new System.Drawing.Point(486, 178);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(63, 48);
            this.btn_clear.TabIndex = 9;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_6.Location = new System.Drawing.Point(245, 178);
            this.btn_6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(63, 48);
            this.btn_6.TabIndex = 8;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_5.Location = new System.Drawing.Point(151, 178);
            this.btn_5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(63, 48);
            this.btn_5.TabIndex = 7;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_4.Location = new System.Drawing.Point(60, 178);
            this.btn_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(63, 48);
            this.btn_4.TabIndex = 6;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_3.Location = new System.Drawing.Point(245, 240);
            this.btn_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(63, 48);
            this.btn_3.TabIndex = 13;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_2.Location = new System.Drawing.Point(151, 240);
            this.btn_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(63, 48);
            this.btn_2.TabIndex = 12;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_1.Location = new System.Drawing.Point(60, 240);
            this.btn_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(63, 48);
            this.btn_1.TabIndex = 11;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.number_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_equal.Location = new System.Drawing.Point(404, 304);
            this.btn_equal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(145, 48);
            this.btn_equal.TabIndex = 20;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // btn_dot
            // 
            this.btn_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_dot.Location = new System.Drawing.Point(245, 304);
            this.btn_dot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(63, 48);
            this.btn_dot.TabIndex = 18;
            this.btn_dot.Text = ",";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.btn_dot_Click);
            // 
            // btn_polarity
            // 
            this.btn_polarity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_polarity.Location = new System.Drawing.Point(151, 304);
            this.btn_polarity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_polarity.Name = "btn_polarity";
            this.btn_polarity.Size = new System.Drawing.Size(63, 48);
            this.btn_polarity.TabIndex = 17;
            this.btn_polarity.Text = "+/-";
            this.btn_polarity.UseVisualStyleBackColor = true;
            this.btn_polarity.Click += new System.EventHandler(this.btn_polarity_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_0.Location = new System.Drawing.Point(60, 304);
            this.btn_0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(63, 48);
            this.btn_0.TabIndex = 16;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.number_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 372);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn_polarity);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_extract);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_backspace);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.lbl_display);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbl_display;
        private Button btn_7;
        private Button btn_8;
        private Button btn_9;
        private Button btn_backspace;
        private Button btn_add;
        private Button btn_extract;
        private Button btn_clear;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_3;
        private Button btn_2;
        private Button btn_1;
        private Button btn_equal;
        private Button btn_dot;
        private Button btn_polarity;
        private Button btn_0;
    }
}