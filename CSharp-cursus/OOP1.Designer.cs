namespace CSharp_cursus
{
    partial class OOP1
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
            this.btn_CreateOb = new System.Windows.Forms.Button();
            this.btn_SetString = new System.Windows.Forms.Button();
            this.btn_GetString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(484, 227);
            this.textBox1.TabIndex = 0;
            // 
            // btn_CreateOb
            // 
            this.btn_CreateOb.Location = new System.Drawing.Point(45, 320);
            this.btn_CreateOb.Name = "btn_CreateOb";
            this.btn_CreateOb.Size = new System.Drawing.Size(90, 33);
            this.btn_CreateOb.TabIndex = 1;
            this.btn_CreateOb.Text = "Create Ob";
            this.btn_CreateOb.UseVisualStyleBackColor = true;
            this.btn_CreateOb.Click += new System.EventHandler(this.btn_CreateOb_Click);
            // 
            // btn_SetString
            // 
            this.btn_SetString.Location = new System.Drawing.Point(241, 320);
            this.btn_SetString.Name = "btn_SetString";
            this.btn_SetString.Size = new System.Drawing.Size(90, 33);
            this.btn_SetString.TabIndex = 2;
            this.btn_SetString.Text = "Set String";
            this.btn_SetString.UseVisualStyleBackColor = true;
            this.btn_SetString.Click += new System.EventHandler(this.btn_SetString_Click);
            // 
            // btn_GetString
            // 
            this.btn_GetString.Location = new System.Drawing.Point(439, 320);
            this.btn_GetString.Name = "btn_GetString";
            this.btn_GetString.Size = new System.Drawing.Size(90, 33);
            this.btn_GetString.TabIndex = 3;
            this.btn_GetString.Text = "Get String";
            this.btn_GetString.UseVisualStyleBackColor = true;
            this.btn_GetString.Click += new System.EventHandler(this.btn_GetString_Click);
            // 
            // OOP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 384);
            this.Controls.Add(this.btn_GetString);
            this.Controls.Add(this.btn_SetString);
            this.Controls.Add(this.btn_CreateOb);
            this.Controls.Add(this.textBox1);
            this.Name = "OOP1";
            this.Text = "OOP1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_CreateOb;
        private System.Windows.Forms.Button btn_SetString;
        private System.Windows.Forms.Button btn_GetString;
    }
}

