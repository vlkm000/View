namespace MyView
{
    partial class FilterSize
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
            this.textBox_Size = new System.Windows.Forms.TextBox();
            this.LabelSize = new System.Windows.Forms.Label();
            this.buttonSize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_Size
            // 
            this.textBox_Size.Location = new System.Drawing.Point(114, 34);
            this.textBox_Size.Name = "textBox_Size";
            this.textBox_Size.Size = new System.Drawing.Size(100, 22);
            this.textBox_Size.TabIndex = 0;
            this.textBox_Size.Text = "3";
            // 
            // LabelSize
            // 
            this.LabelSize.AutoSize = true;
            this.LabelSize.Location = new System.Drawing.Point(51, 39);
            this.LabelSize.Name = "LabelSize";
            this.LabelSize.Size = new System.Drawing.Size(30, 17);
            this.LabelSize.TabIndex = 1;
            this.LabelSize.Text = "Par";
            // 
            // buttonSize
            // 
            this.buttonSize.Location = new System.Drawing.Point(91, 81);
            this.buttonSize.Name = "buttonSize";
            this.buttonSize.Size = new System.Drawing.Size(73, 25);
            this.buttonSize.TabIndex = 2;
            this.buttonSize.Text = "OK";
            this.buttonSize.UseVisualStyleBackColor = true;
            this.buttonSize.Click += new System.EventHandler(this.buttonSize_Click);
            // 
            // FilterSize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 130);
            this.Controls.Add(this.buttonSize);
            this.Controls.Add(this.LabelSize);
            this.Controls.Add(this.textBox_Size);
            this.Name = "FilterSize";
            this.Text = "FilterPar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Size;
        private System.Windows.Forms.Label LabelSize;
        private System.Windows.Forms.Button buttonSize;
    }
}