namespace EjercicioColisionInf1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Objeto1 = new System.Windows.Forms.Button();
            this.Objeto2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click Me!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Objeto1
            // 
            this.Objeto1.Location = new System.Drawing.Point(8, 7);
            this.Objeto1.Name = "Objeto1";
            this.Objeto1.Size = new System.Drawing.Size(75, 23);
            this.Objeto1.TabIndex = 4;
            this.Objeto1.Text = "Objeto1";
            this.Objeto1.UseVisualStyleBackColor = true;
            // 
            // Objeto2
            // 
            this.Objeto2.Location = new System.Drawing.Point(325, 316);
            this.Objeto2.Name = "Objeto2";
            this.Objeto2.Size = new System.Drawing.Size(75, 23);
            this.Objeto2.TabIndex = 5;
            this.Objeto2.Text = "Objeto2";
            this.Objeto2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 344);
            this.Controls.Add(this.Objeto2);
            this.Controls.Add(this.Objeto1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Objeto1;
        private System.Windows.Forms.Button Objeto2;
    }
}

