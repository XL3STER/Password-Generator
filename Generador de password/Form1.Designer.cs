namespace Generador_de_password
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
            this.button1 = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Lowercase1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Symbols1 = new System.Windows.Forms.CheckBox();
            this.Numbers1 = new System.Windows.Forms.CheckBox();
            this.Uppercase1 = new System.Windows.Forms.CheckBox();
            this.Length = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Strength = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 265);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // Lowercase1
            // 
            this.Lowercase1.AutoSize = true;
            this.Lowercase1.Location = new System.Drawing.Point(159, 69);
            this.Lowercase1.Name = "Lowercase1";
            this.Lowercase1.Size = new System.Drawing.Size(107, 17);
            this.Lowercase1.TabIndex = 2;
            this.Lowercase1.Text = "Lowercase (a - z)";
            this.Lowercase1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "Copiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(322, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 31);
            this.button3.TabIndex = 4;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Symbols1
            // 
            this.Symbols1.AutoSize = true;
            this.Symbols1.Location = new System.Drawing.Point(159, 103);
            this.Symbols1.Name = "Symbols1";
            this.Symbols1.Size = new System.Drawing.Size(65, 17);
            this.Symbols1.TabIndex = 5;
            this.Symbols1.Text = "Symbols";
            this.Symbols1.UseVisualStyleBackColor = true;
            // 
            // Numbers1
            // 
            this.Numbers1.AutoSize = true;
            this.Numbers1.Location = new System.Drawing.Point(29, 103);
            this.Numbers1.Name = "Numbers1";
            this.Numbers1.Size = new System.Drawing.Size(68, 17);
            this.Numbers1.TabIndex = 7;
            this.Numbers1.Text = "Numbers";
            this.Numbers1.UseVisualStyleBackColor = true;
            // 
            // Uppercase1
            // 
            this.Uppercase1.AutoSize = true;
            this.Uppercase1.Location = new System.Drawing.Point(29, 69);
            this.Uppercase1.Name = "Uppercase1";
            this.Uppercase1.Size = new System.Drawing.Size(110, 17);
            this.Uppercase1.TabIndex = 6;
            this.Uppercase1.Text = "Uppercase (A - Z)";
            this.Uppercase1.UseVisualStyleBackColor = true;
            // 
            // Length
            // 
            this.Length.Location = new System.Drawing.Point(55, 30);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(52, 20);
            this.Length.TabIndex = 8;
            this.Length.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Length";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Count";
            // 
            // Count
            // 
            this.Count.Location = new System.Drawing.Point(197, 32);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(52, 20);
            this.Count.TabIndex = 10;
            this.Count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Strength";
            // 
            // Strength
            // 
            this.Strength.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Strength.FormattingEnabled = true;
            this.Strength.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.Strength.Location = new System.Drawing.Point(372, 32);
            this.Strength.Name = "Strength";
            this.Strength.Size = new System.Drawing.Size(69, 21);
            this.Strength.TabIndex = 13;
            this.Strength.SelectedIndexChanged += new System.EventHandler(this.Strength_SelectedIndexChanged_1);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 171);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(468, 84);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(487, 265);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Strength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.Numbers1);
            this.Controls.Add(this.Uppercase1);
            this.Controls.Add(this.Symbols1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Lowercase1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Generador Password";
            ((System.ComponentModel.ISupportInitialize)(this.Length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Count)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.CheckBox Lowercase1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox Symbols1;
        private System.Windows.Forms.CheckBox Numbers1;
        private System.Windows.Forms.CheckBox Uppercase1;
        private System.Windows.Forms.NumericUpDown Length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Count;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Strength;
        private System.Windows.Forms.RichTextBox richTextBox1;

    }
}

