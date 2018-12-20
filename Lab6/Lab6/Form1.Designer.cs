namespace Lab6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDownMinX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxX = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMinY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(53, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(653, 416);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(801, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 26);
            this.textBox1.TabIndex = 1;
            // 
            // numericUpDownMinX
            // 
            this.numericUpDownMinX.Location = new System.Drawing.Point(801, 133);
            this.numericUpDownMinX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMinX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownMinX.Name = "numericUpDownMinX";
            this.numericUpDownMinX.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownMinX.TabIndex = 2;
            this.numericUpDownMinX.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // numericUpDownMaxX
            // 
            this.numericUpDownMaxX.Location = new System.Drawing.Point(801, 199);
            this.numericUpDownMaxX.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMaxX.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxX.Name = "numericUpDownMaxX";
            this.numericUpDownMaxX.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownMaxX.TabIndex = 3;
            this.numericUpDownMaxX.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownMinY
            // 
            this.numericUpDownMinY.Location = new System.Drawing.Point(801, 266);
            this.numericUpDownMinY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMinY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownMinY.Name = "numericUpDownMinY";
            this.numericUpDownMinY.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownMinY.TabIndex = 4;
            this.numericUpDownMinY.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // numericUpDownMaxY
            // 
            this.numericUpDownMaxY.Location = new System.Drawing.Point(801, 331);
            this.numericUpDownMaxY.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMaxY.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxY.Name = "numericUpDownMaxY";
            this.numericUpDownMaxY.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownMaxY.TabIndex = 5;
            this.numericUpDownMaxY.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownLevel
            // 
            this.numericUpDownLevel.Location = new System.Drawing.Point(801, 406);
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownLevel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 541);
            this.Controls.Add(this.numericUpDownLevel);
            this.Controls.Add(this.numericUpDownMaxY);
            this.Controls.Add(this.numericUpDownMinY);
            this.Controls.Add(this.numericUpDownMaxX);
            this.Controls.Add(this.numericUpDownMinX);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMinY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownMinX;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxX;
        private System.Windows.Forms.NumericUpDown numericUpDownMinY;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxY;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
    }
}

