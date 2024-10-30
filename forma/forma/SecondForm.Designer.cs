namespace forma
{
    partial class SecondForm
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
            this.lblGreetingText = new System.Windows.Forms.Label();
            this.btnDialogResultYes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGreetingText
            // 
            this.lblGreetingText.AutoSize = true;
            this.lblGreetingText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGreetingText.Location = new System.Drawing.Point(57, 35);
            this.lblGreetingText.Name = "lblGreetingText";
            this.lblGreetingText.Size = new System.Drawing.Size(64, 22);
            this.lblGreetingText.TabIndex = 0;
            this.lblGreetingText.Text = "neshto";
            // 
            // btnDialogResultYes
            // 
            this.btnDialogResultYes.Location = new System.Drawing.Point(61, 173);
            this.btnDialogResultYes.Name = "btnDialogResultYes";
            this.btnDialogResultYes.Size = new System.Drawing.Size(75, 23);
            this.btnDialogResultYes.TabIndex = 1;
            this.btnDialogResultYes.Text = "result";
            this.btnDialogResultYes.UseVisualStyleBackColor = true;
            this.btnDialogResultYes.Click += new System.EventHandler(this.btnDialogResultYes_Click);
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 258);
            this.Controls.Add(this.btnDialogResultYes);
            this.Controls.Add(this.lblGreetingText);
            this.Name = "SecondForm";
            this.Text = "SecondForm";
            this.Load += new System.EventHandler(this.SecondForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreetingText;
        private System.Windows.Forms.Button btnDialogResultYes;
    }
}