namespace WindowsFormsAppSpecButton
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
            this.specialButton11 = new SpecialButton.SpecialButton1();
            this.SuspendLayout();
            // 
            // specialButton11
            // 
            this.specialButton11.BackColor = System.Drawing.Color.Gray;
            this.specialButton11.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.specialButton11.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.specialButton11.ForeColor = System.Drawing.Color.White;
            this.specialButton11.Location = new System.Drawing.Point(221, 226);
            this.specialButton11.Margin = new System.Windows.Forms.Padding(4, 1, 4, 1);
            this.specialButton11.MinimumSize = new System.Drawing.Size(150, 35);
            this.specialButton11.Name = "specialButton11";
            this.specialButton11.Padding = new System.Windows.Forms.Padding(4);
            this.specialButton11.Size = new System.Drawing.Size(330, 145);
            this.specialButton11.TabIndex = 0;
            this.specialButton11.Text = "Tap Me";
            this.specialButton11.UseVisualStyleBackColor = false;
            this.specialButton11.Click += new System.EventHandler(this.specialButton11_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.specialButton11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private SpecialButton.SpecialButton1 specialButton11;
    }
}

