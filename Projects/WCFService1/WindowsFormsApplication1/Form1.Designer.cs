namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lowerLimitLabel = new System.Windows.Forms.Label();
            this.lowerLimit = new System.Windows.Forms.TextBox();
            this.UpperlimitLabel = new System.Windows.Forms.Label();
            this.UpperLimit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lowerLimitLabel
            // 
            this.lowerLimitLabel.AutoSize = true;
            this.lowerLimitLabel.Location = new System.Drawing.Point(13, 13);
            this.lowerLimitLabel.Name = "lowerLimitLabel";
            this.lowerLimitLabel.Size = new System.Drawing.Size(60, 13);
            this.lowerLimitLabel.TabIndex = 1;
            this.lowerLimitLabel.Text = "Lower Limit";
            this.lowerLimitLabel.Click += new System.EventHandler(this.lowerLimitLabel_Click);
            // 
            // lowerLimit
            // 
            this.lowerLimit.AccessibleName = "";
            this.lowerLimit.Location = new System.Drawing.Point(91, 13);
            this.lowerLimit.Name = "lowerLimit";
            this.lowerLimit.Size = new System.Drawing.Size(100, 20);
            this.lowerLimit.TabIndex = 2;
            this.lowerLimit.TextChanged += new System.EventHandler(this.lowerLimit_TextChanged);
            // 
            // UpperlimitLabel
            // 
            this.UpperlimitLabel.AutoSize = true;
            this.UpperlimitLabel.Location = new System.Drawing.Point(237, 19);
            this.UpperlimitLabel.Name = "UpperlimitLabel";
            this.UpperlimitLabel.Size = new System.Drawing.Size(60, 13);
            this.UpperlimitLabel.TabIndex = 3;
            this.UpperlimitLabel.Text = "Upper Limit";
            // 
            // UpperLimit
            // 
            this.UpperLimit.Location = new System.Drawing.Point(313, 10);
            this.UpperLimit.Name = "UpperLimit";
            this.UpperLimit.Size = new System.Drawing.Size(100, 20);
            this.UpperLimit.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 266);
            this.Controls.Add(this.UpperLimit);
            this.Controls.Add(this.UpperlimitLabel);
            this.Controls.Add(this.lowerLimit);
            this.Controls.Add(this.lowerLimitLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lowerLimitLabel;
        private System.Windows.Forms.TextBox lowerLimit;
        private System.Windows.Forms.Label UpperlimitLabel;
        private System.Windows.Forms.TextBox UpperLimit;
    }
}

