namespace _732_1Reverser
{
    partial class MainForm
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
            InputTextBox = new TextBox();
            ProcessButton = new Button();
            Output = new Label();
            helpProvider1 = new HelpProvider();
            SuspendLayout();
            // 
            // InputTextBox
            // 
            InputTextBox.Location = new Point(72, 91);
            InputTextBox.Margin = new Padding(4);
            InputTextBox.Name = "InputTextBox";
            InputTextBox.Size = new Size(612, 39);
            InputTextBox.TabIndex = 0;
            InputTextBox.TextChanged += textBox1_TextChanged;
            // 
            // ProcessButton
            // 
            ProcessButton.Location = new Point(70, 314);
            ProcessButton.Margin = new Padding(4);
            ProcessButton.Name = "ProcessButton";
            ProcessButton.Size = new Size(614, 150);
            ProcessButton.TabIndex = 1;
            ProcessButton.Text = "Развернуть";
            ProcessButton.UseVisualStyleBackColor = true;
            ProcessButton.Click += ProcessButton_Click;
            // 
            // Output
            // 
            Output.AutoSize = true;
            Output.Location = new Point(238, 233);
            Output.Margin = new Padding(4, 0, 4, 0);
            Output.Name = "Output";
            Output.Size = new Size(259, 32);
            Output.TabIndex = 2;
            Output.Text = "Здесь будет результат";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 568);
            Controls.Add(Output);
            Controls.Add(ProcessButton);
            Controls.Add(InputTextBox);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "732-1 Reverser";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox InputTextBox;
        private Button ProcessButton;
        private Label Output;
        private HelpProvider helpProvider1;
    }
}