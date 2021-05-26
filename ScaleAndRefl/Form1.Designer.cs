
namespace ScaleAndRefl
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.ScaleButton = new System.Windows.Forms.RadioButton();
            this.ReflectButton = new System.Windows.Forms.RadioButton();
            this.ScaleXTextBox = new System.Windows.Forms.TextBox();
            this.ReflectTextBox = new System.Windows.Forms.TextBox();
            this.ProceedButton = new System.Windows.Forms.Button();
            this.ScaleYTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1503, 702);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // InputTextBox
            // 
            this.InputTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.InputTextBox.Location = new System.Drawing.Point(52, 713);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(433, 23);
            this.InputTextBox.TabIndex = 0;
            this.InputTextBox.Text = "Type your Input here, Please. Example: (15,8)(16,9)(69,50) and so on.";
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // ScaleButton
            // 
            this.ScaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ScaleButton.AutoSize = true;
            this.ScaleButton.Location = new System.Drawing.Point(52, 751);
            this.ScaleButton.Name = "ScaleButton";
            this.ScaleButton.Size = new System.Drawing.Size(52, 19);
            this.ScaleButton.TabIndex = 1;
            this.ScaleButton.TabStop = true;
            this.ScaleButton.Text = "Scale";
            this.ScaleButton.UseVisualStyleBackColor = true;
            this.ScaleButton.CheckedChanged += new System.EventHandler(this.ScaleButton_CheckedChanged);
            // 
            // ReflectButton
            // 
            this.ReflectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ReflectButton.AutoSize = true;
            this.ReflectButton.Location = new System.Drawing.Point(150, 751);
            this.ReflectButton.Name = "ReflectButton";
            this.ReflectButton.Size = new System.Drawing.Size(61, 19);
            this.ReflectButton.TabIndex = 2;
            this.ReflectButton.TabStop = true;
            this.ReflectButton.Text = "Reflect";
            this.ReflectButton.UseVisualStyleBackColor = true;
            this.ReflectButton.CheckedChanged += new System.EventHandler(this.ReflectButton_CheckedChanged);
            // 
            // ScaleXTextBox
            // 
            this.ScaleXTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ScaleXTextBox.Location = new System.Drawing.Point(251, 751);
            this.ScaleXTextBox.Name = "ScaleXTextBox";
            this.ScaleXTextBox.Size = new System.Drawing.Size(277, 23);
            this.ScaleXTextBox.TabIndex = 3;
            this.ScaleXTextBox.Text = "Scaling Input X";
            this.ScaleXTextBox.TextChanged += new System.EventHandler(this.ScaleTextBox_TextChanged);
            // 
            // ReflectTextBox
            // 
            this.ReflectTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ReflectTextBox.Location = new System.Drawing.Point(905, 751);
            this.ReflectTextBox.Name = "ReflectTextBox";
            this.ReflectTextBox.Size = new System.Drawing.Size(277, 23);
            this.ReflectTextBox.TabIndex = 4;
            this.ReflectTextBox.Text = "Reflection Input";
            // 
            // ProceedButton
            // 
            this.ProceedButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ProceedButton.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ProceedButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProceedButton.Location = new System.Drawing.Point(1333, 713);
            this.ProceedButton.Name = "ProceedButton";
            this.ProceedButton.Size = new System.Drawing.Size(158, 85);
            this.ProceedButton.TabIndex = 5;
            this.ProceedButton.Text = "Proceed";
            this.ProceedButton.UseVisualStyleBackColor = true;
            this.ProceedButton.Click += new System.EventHandler(this.ProceedButton_Click);
            // 
            // ScaleYTextBox
            // 
            this.ScaleYTextBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ScaleYTextBox.Location = new System.Drawing.Point(579, 751);
            this.ScaleYTextBox.Name = "ScaleYTextBox";
            this.ScaleYTextBox.Size = new System.Drawing.Size(277, 23);
            this.ScaleYTextBox.TabIndex = 6;
            this.ScaleYTextBox.Text = "Scaling Input Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 810);
            this.Controls.Add(this.ScaleYTextBox);
            this.Controls.Add(this.ProceedButton);
            this.Controls.Add(this.ReflectTextBox);
            this.Controls.Add(this.ScaleXTextBox);
            this.Controls.Add(this.ReflectButton);
            this.Controls.Add(this.ScaleButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ScaleAndReflForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.RadioButton ScaleButton;
        private System.Windows.Forms.RadioButton ReflectButton;
        private System.Windows.Forms.TextBox ScaleXTextBox;
        private System.Windows.Forms.TextBox ReflectTextBox;
        private System.Windows.Forms.Button ProceedButton;
        private System.Windows.Forms.TextBox ScaleYTextBox;
    }
}

