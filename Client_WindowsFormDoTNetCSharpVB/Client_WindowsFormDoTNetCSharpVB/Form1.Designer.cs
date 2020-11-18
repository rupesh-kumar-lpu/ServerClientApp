namespace Client_WindowsFormDoTNetCSharpVB
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
            this.label1 = new System.Windows.Forms.Label();
            this.tosendtb = new System.Windows.Forms.TextBox();
            this.sendbt = new System.Windows.Forms.Button();
            this.msgstb = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Messages From Server";
            // 
            // tosendtb
            // 
            this.tosendtb.Location = new System.Drawing.Point(34, 396);
            this.tosendtb.Name = "tosendtb";
            this.tosendtb.Size = new System.Drawing.Size(650, 22);
            this.tosendtb.TabIndex = 2;
            // 
            // sendbt
            // 
            this.sendbt.Location = new System.Drawing.Point(701, 396);
            this.sendbt.Name = "sendbt";
            this.sendbt.Size = new System.Drawing.Size(75, 23);
            this.sendbt.TabIndex = 3;
            this.sendbt.Text = "Send";
            this.sendbt.UseVisualStyleBackColor = true;
            this.sendbt.Click += new System.EventHandler(this.sendbt_Click);
            // 
            // msgstb
            // 
            this.msgstb.Location = new System.Drawing.Point(34, 42);
            this.msgstb.Name = "msgstb";
            this.msgstb.Size = new System.Drawing.Size(731, 326);
            this.msgstb.TabIndex = 4;
            this.msgstb.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msgstb);
            this.Controls.Add(this.sendbt);
            this.Controls.Add(this.tosendtb);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tosendtb;
        private System.Windows.Forms.Button sendbt;
        private System.Windows.Forms.RichTextBox msgstb;
    }
}

