namespace project.My_Project
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(288, 0);
            label1.Name = "label1";
            label1.Size = new Size(372, 47);
            label1.TabIndex = 0;
            label1.Text = "Dashboard Information";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(56, 69);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 265);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(14, 50);
            panel2.Name = "panel2";
            panel2.Size = new Size(883, 474);
            panel2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Sitka Heading", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkSlateBlue;
            button1.Location = new Point(10, 10);
            button1.Name = "button1";
            button1.Size = new Size(86, 43);
            button1.TabIndex = 2;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 529);
            Controls.Add(panel2);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
    }
}