namespace Fermat
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
            this.Solve = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.TextBox();
            this.K = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(164, 191);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(88, 41);
            this.Solve.TabIndex = 0;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(83, 46);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(277, 20);
            this.input.TabIndex = 1;
            this.input.Text = "Input";
            this.input.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(83, 93);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(277, 20);
            this.K.TabIndex = 2;
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(83, 140);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(277, 20);
            this.Output.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 261);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.K);
            this.Controls.Add(this.input);
            this.Controls.Add(this.Solve);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.TextBox input;
        private System.Windows.Forms.TextBox K;
        private System.Windows.Forms.TextBox Output;
    }
}

