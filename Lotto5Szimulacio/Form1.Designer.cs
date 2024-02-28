namespace Lotto5Szimulacio
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
            panel = new Panel();
            btnSorsolas = new Button();
            leredmenyek = new Label();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Location = new Point(18, 20);
            panel.Name = "panel";
            panel.Size = new Size(468, 366);
            panel.TabIndex = 0;
            // 
            // btnSorsolas
            // 
            btnSorsolas.Location = new Point(549, 20);
            btnSorsolas.Name = "btnSorsolas";
            btnSorsolas.Size = new Size(75, 23);
            btnSorsolas.TabIndex = 1;
            btnSorsolas.Text = "Sorsolás";
            btnSorsolas.UseVisualStyleBackColor = true;
            btnSorsolas.Click += btnSorsolas_Click;
            // 
            // leredmenyek
            // 
            leredmenyek.AutoSize = true;
            leredmenyek.Location = new Point(549, 72);
            leredmenyek.Name = "leredmenyek";
            leredmenyek.Size = new Size(38, 15);
            leredmenyek.TabIndex = 2;
            leredmenyek.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(leredmenyek);
            Controls.Add(btnSorsolas);
            Controls.Add(panel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Button btnSorsolas;
        private Label leredmenyek;
    }
}