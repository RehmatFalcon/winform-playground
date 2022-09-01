namespace Playground
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
            this.b1 = new System.Windows.Forms.ComboBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.hola = new System.Windows.Forms.Button();
            this.usernameElm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.b1.FormattingEnabled = true;
            this.b1.Location = new System.Drawing.Point(226, 86);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(151, 28);
            this.b1.TabIndex = 0;
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(258, 154);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(94, 29);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "button1";
            this.submitBtn.UseVisualStyleBackColor = true;
            // 
            // hola
            // 
            this.hola.Location = new System.Drawing.Point(330, 317);
            this.hola.Name = "hola";
            this.hola.Size = new System.Drawing.Size(94, 29);
            this.hola.TabIndex = 2;
            this.hola.Text = "button1";
            this.hola.UseVisualStyleBackColor = true;
            // 
            // usernameElm
            // 
            this.usernameElm.Location = new System.Drawing.Point(227, 30);
            this.usernameElm.Name = "usernameElm";
            this.usernameElm.Size = new System.Drawing.Size(125, 27);
            this.usernameElm.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usernameElm);
            this.Controls.Add(this.hola);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox b1;
        private Button submitBtn;
        private Button hola;
        private TextBox usernameElm;
    }
}