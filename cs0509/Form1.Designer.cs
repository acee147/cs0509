namespace cs0509
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
            buttonProperty = new Button();
            SuspendLayout();
            // 
            // buttonProperty
            // 
            buttonProperty.BackColor = SystemColors.Info;
            buttonProperty.ForeColor = SystemColors.ActiveCaptionText;
            buttonProperty.Location = new Point(301, 138);
            buttonProperty.Name = "buttonProperty";
            buttonProperty.Size = new Size(150, 151);
            buttonProperty.TabIndex = 0;
            buttonProperty.Text = "button1";
            buttonProperty.UseVisualStyleBackColor = false;
            buttonProperty.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonProperty);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonProperty;
    }
}
