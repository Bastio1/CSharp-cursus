namespace OOP2
{
    partial class OOP2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_CreateObj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 31);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(616, 220);
            this.textBox1.TabIndex = 0;
            // 
            // btn_CreateObj
            // 
            this.btn_CreateObj.Location = new System.Drawing.Point(27, 290);
            this.btn_CreateObj.Name = "btn_CreateObj";
            this.btn_CreateObj.Size = new System.Drawing.Size(124, 38);
            this.btn_CreateObj.TabIndex = 1;
            this.btn_CreateObj.Text = "Create Objects";
            this.btn_CreateObj.UseVisualStyleBackColor = true;
            this.btn_CreateObj.Click += new System.EventHandler(this.btn_CreateObj_Click);
            // 
            // OOP2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 385);
            this.Controls.Add(this.btn_CreateObj);
            this.Controls.Add(this.textBox1);
            this.Name = "OOP2";
            this.Text = "OOP2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_CreateObj;
    }
}

