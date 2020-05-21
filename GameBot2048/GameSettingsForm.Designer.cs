namespace GameBot2048
{
    partial class GameSettingsForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameSettingsForm));
            this.buttonStart = new System.Windows.Forms.Button();
            this.NumericUpDownRows = new System.Windows.Forms.NumericUpDown();
            this.NumericUpDownColumns = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonStart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(131, 304);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(139, 46);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumericUpDownRows
            // 
            this.NumericUpDownRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(153)))), ((int)(((byte)(110)))));
            this.NumericUpDownRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericUpDownRows.Location = new System.Drawing.Point(131, 69);
            this.NumericUpDownRows.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.NumericUpDownRows.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumericUpDownRows.Name = "NumericUpDownRows";
            this.NumericUpDownRows.Size = new System.Drawing.Size(141, 26);
            this.NumericUpDownRows.TabIndex = 3;
            this.NumericUpDownRows.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownRows.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // NumericUpDownColumns
            // 
            this.NumericUpDownColumns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(153)))), ((int)(((byte)(110)))));
            this.NumericUpDownColumns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericUpDownColumns.Location = new System.Drawing.Point(131, 133);
            this.NumericUpDownColumns.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.NumericUpDownColumns.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.NumericUpDownColumns.Name = "NumericUpDownColumns";
            this.NumericUpDownColumns.Size = new System.Drawing.Size(141, 26);
            this.NumericUpDownColumns.TabIndex = 4;
            this.NumericUpDownColumns.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownColumns.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(127, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number of columns";
            // 
            // NumericUpDownSpeed
            // 
            this.NumericUpDownSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(153)))), ((int)(((byte)(110)))));
            this.NumericUpDownSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumericUpDownSpeed.Location = new System.Drawing.Point(131, 194);
            this.NumericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NumericUpDownSpeed.Name = "NumericUpDownSpeed";
            this.NumericUpDownSpeed.Size = new System.Drawing.Size(141, 26);
            this.NumericUpDownSpeed.TabIndex = 4;
            this.NumericUpDownSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumericUpDownSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(127, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Animation speed";
            // 
            // GameSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(153)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumericUpDownSpeed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumericUpDownColumns);
            this.Controls.Add(this.NumericUpDownRows);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown NumericUpDownColumns;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NumericUpDownRows;
        private System.Windows.Forms.NumericUpDown NumericUpDownSpeed;
        private System.Windows.Forms.Label label3;
    }
}