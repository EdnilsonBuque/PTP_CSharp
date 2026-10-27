namespace Aula_1_CSharp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button btnCumprimentar;

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
            btnCumprimentar = new Button();
            SuspendLayout();
            // 
            // btnCumprimentar
            // 
            btnCumprimentar.Location = new Point(303, 170);
            btnCumprimentar.Name = "btnCumprimentar";
            btnCumprimentar.Size = new Size(140, 60);
            btnCumprimentar.TabIndex = 0;
            btnCumprimentar.Text = "Clica em mim";
            btnCumprimentar.UseVisualStyleBackColor = true;
            btnCumprimentar.Click += btnCumprimentar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCumprimentar);
            Name = "Form1";
            Text = "Aula 1 - CSharp";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
    }
}
