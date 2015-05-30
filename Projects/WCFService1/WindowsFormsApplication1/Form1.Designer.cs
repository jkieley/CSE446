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
            this.lowerLimitInput = new System.Windows.Forms.TextBox();
            this.UpperlimitLabel = new System.Windows.Forms.Label();
            this.upperLimitInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MakeAGuessLabel = new System.Windows.Forms.Label();
            this.makeAGuessInput = new System.Windows.Forms.TextBox();
            this.generateANumber = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.attemptsLabel = new System.Windows.Forms.Label();
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
            this.lowerLimitLabel.Location = new System.Drawing.Point(12, 47);
            this.lowerLimitLabel.Name = "lowerLimitLabel";
            this.lowerLimitLabel.Size = new System.Drawing.Size(60, 13);
            this.lowerLimitLabel.TabIndex = 1;
            this.lowerLimitLabel.Text = "Lower Limit";
            this.lowerLimitLabel.Click += new System.EventHandler(this.lowerLimitLabel_Click);
            // 
            // lowerLimitInput
            // 
            this.lowerLimitInput.AccessibleName = "";
            this.lowerLimitInput.Location = new System.Drawing.Point(90, 47);
            this.lowerLimitInput.Name = "lowerLimitInput";
            this.lowerLimitInput.Size = new System.Drawing.Size(100, 20);
            this.lowerLimitInput.TabIndex = 2;
            this.lowerLimitInput.TextChanged += new System.EventHandler(this.lowerLimit_TextChanged);
            // 
            // UpperlimitLabel
            // 
            this.UpperlimitLabel.AutoSize = true;
            this.UpperlimitLabel.Location = new System.Drawing.Point(217, 47);
            this.UpperlimitLabel.Name = "UpperlimitLabel";
            this.UpperlimitLabel.Size = new System.Drawing.Size(60, 13);
            this.UpperlimitLabel.TabIndex = 3;
            this.UpperlimitLabel.Text = "Upper Limit";
            // 
            // upperLimitInput
            // 
            this.upperLimitInput.Location = new System.Drawing.Point(297, 47);
            this.upperLimitInput.Name = "upperLimitInput";
            this.upperLimitInput.Size = new System.Drawing.Size(100, 20);
            this.upperLimitInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to Number Guessing Game";
            // 
            // MakeAGuessLabel
            // 
            this.MakeAGuessLabel.AutoSize = true;
            this.MakeAGuessLabel.Location = new System.Drawing.Point(12, 98);
            this.MakeAGuessLabel.Name = "MakeAGuessLabel";
            this.MakeAGuessLabel.Size = new System.Drawing.Size(76, 13);
            this.MakeAGuessLabel.TabIndex = 6;
            this.MakeAGuessLabel.Text = "Make a Guess";
            // 
            // makeAGuessInput
            // 
            this.makeAGuessInput.Location = new System.Drawing.Point(95, 98);
            this.makeAGuessInput.Name = "makeAGuessInput";
            this.makeAGuessInput.Size = new System.Drawing.Size(100, 20);
            this.makeAGuessInput.TabIndex = 7;
            // 
            // generateANumber
            // 
            this.generateANumber.Location = new System.Drawing.Point(439, 47);
            this.generateANumber.Name = "generateANumber";
            this.generateANumber.Size = new System.Drawing.Size(179, 20);
            this.generateANumber.TabIndex = 8;
            this.generateANumber.Text = "Generate a Secret Number";
            this.generateANumber.UseVisualStyleBackColor = true;
            this.generateANumber.Click += new System.EventHandler(this.generateANumber_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(230, 98);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 9;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // attemptsLabel
            // 
            this.attemptsLabel.AutoSize = true;
            this.attemptsLabel.Location = new System.Drawing.Point(334, 101);
            this.attemptsLabel.Name = "attemptsLabel";
            this.attemptsLabel.Size = new System.Drawing.Size(63, 13);
            this.attemptsLabel.TabIndex = 10;
            this.attemptsLabel.Text = "Attempts - 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 287);
            this.Controls.Add(this.attemptsLabel);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.generateANumber);
            this.Controls.Add(this.makeAGuessInput);
            this.Controls.Add(this.MakeAGuessLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upperLimitInput);
            this.Controls.Add(this.UpperlimitLabel);
            this.Controls.Add(this.lowerLimitInput);
            this.Controls.Add(this.lowerLimitLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lowerLimitLabel;
        private System.Windows.Forms.TextBox lowerLimitInput;
        private System.Windows.Forms.Label UpperlimitLabel;
        private System.Windows.Forms.TextBox upperLimitInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label MakeAGuessLabel;
        private System.Windows.Forms.TextBox makeAGuessInput;
        private System.Windows.Forms.Button generateANumber;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label attemptsLabel;
    }
}

