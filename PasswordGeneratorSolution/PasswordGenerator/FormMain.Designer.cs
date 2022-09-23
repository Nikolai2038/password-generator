namespace PasswordGenerator
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NumericUpDown_PasswordLength = new System.Windows.Forms.NumericUpDown();
            this.Label_PasswordLength = new System.Windows.Forms.Label();
            this.GroupBox_UsingSymbols = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Label_Gap_1 = new System.Windows.Forms.Label();
            this.Label_Gap_2 = new System.Windows.Forms.Label();
            this.Button_Generate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_PasswordLength)).BeginInit();
            this.GroupBox_UsingSymbols.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NumericUpDown_PasswordLength);
            this.panel1.Controls.Add(this.Label_PasswordLength);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 23);
            this.panel1.TabIndex = 0;
            // 
            // NumericUpDown_PasswordLength
            // 
            this.NumericUpDown_PasswordLength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NumericUpDown_PasswordLength.Location = new System.Drawing.Point(88, 0);
            this.NumericUpDown_PasswordLength.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.NumericUpDown_PasswordLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDown_PasswordLength.Name = "NumericUpDown_PasswordLength";
            this.NumericUpDown_PasswordLength.Size = new System.Drawing.Size(300, 23);
            this.NumericUpDown_PasswordLength.TabIndex = 1;
            this.NumericUpDown_PasswordLength.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Label_PasswordLength
            // 
            this.Label_PasswordLength.Dock = System.Windows.Forms.DockStyle.Left;
            this.Label_PasswordLength.Location = new System.Drawing.Point(0, 0);
            this.Label_PasswordLength.Name = "Label_PasswordLength";
            this.Label_PasswordLength.Size = new System.Drawing.Size(88, 23);
            this.Label_PasswordLength.TabIndex = 0;
            this.Label_PasswordLength.Text = "Длина пароля:";
            this.Label_PasswordLength.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GroupBox_UsingSymbols
            // 
            this.GroupBox_UsingSymbols.Controls.Add(this.checkBox5);
            this.GroupBox_UsingSymbols.Controls.Add(this.checkBox4);
            this.GroupBox_UsingSymbols.Controls.Add(this.checkBox3);
            this.GroupBox_UsingSymbols.Controls.Add(this.checkBox2);
            this.GroupBox_UsingSymbols.Controls.Add(this.checkBox1);
            this.GroupBox_UsingSymbols.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupBox_UsingSymbols.Location = new System.Drawing.Point(8, 39);
            this.GroupBox_UsingSymbols.Name = "GroupBox_UsingSymbols";
            this.GroupBox_UsingSymbols.Size = new System.Drawing.Size(388, 116);
            this.GroupBox_UsingSymbols.TabIndex = 1;
            this.GroupBox_UsingSymbols.TabStop = false;
            this.GroupBox_UsingSymbols.Text = "Используемые символы:";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox5.Location = new System.Drawing.Point(3, 95);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(382, 19);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "!$%^*~@#\'\"?/|\\";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox4.Location = new System.Drawing.Point(3, 76);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(382, 19);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "()-_=+<>.,{}[]:;";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox3.Location = new System.Drawing.Point(3, 57);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(382, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "0123456789";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox2.Location = new System.Drawing.Point(3, 38);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(382, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "abcdefghijklmnopqrstuvwxyz";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBox1.Location = new System.Drawing.Point(3, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(382, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Label_Gap_1
            // 
            this.Label_Gap_1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Gap_1.Location = new System.Drawing.Point(8, 31);
            this.Label_Gap_1.Name = "Label_Gap_1";
            this.Label_Gap_1.Size = new System.Drawing.Size(388, 8);
            this.Label_Gap_1.TabIndex = 2;
            this.Label_Gap_1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label_Gap_2
            // 
            this.Label_Gap_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label_Gap_2.Location = new System.Drawing.Point(8, 155);
            this.Label_Gap_2.Name = "Label_Gap_2";
            this.Label_Gap_2.Size = new System.Drawing.Size(388, 8);
            this.Label_Gap_2.TabIndex = 3;
            this.Label_Gap_2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Button_Generate
            // 
            this.Button_Generate.Dock = System.Windows.Forms.DockStyle.Top;
            this.Button_Generate.Location = new System.Drawing.Point(8, 163);
            this.Button_Generate.Name = "Button_Generate";
            this.Button_Generate.Size = new System.Drawing.Size(388, 46);
            this.Button_Generate.TabIndex = 4;
            this.Button_Generate.Text = "Сгенерировать пароль и\r\nскопировать его в буфер обмена";
            this.Button_Generate.UseVisualStyleBackColor = true;
            this.Button_Generate.Click += new System.EventHandler(this.Button_Generate_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 217);
            this.Controls.Add(this.Button_Generate);
            this.Controls.Add(this.Label_Gap_2);
            this.Controls.Add(this.GroupBox_UsingSymbols);
            this.Controls.Add(this.Label_Gap_1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Генератор паролей v.1.0.1 | от Nikolai-415";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_PasswordLength)).EndInit();
            this.GroupBox_UsingSymbols.ResumeLayout(false);
            this.GroupBox_UsingSymbols.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private NumericUpDown NumericUpDown_PasswordLength;
        private Label Label_PasswordLength;
        private GroupBox GroupBox_UsingSymbols;
        private Label Label_Gap_1;
        private Label Label_Gap_2;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button Button_Generate;
    }
}