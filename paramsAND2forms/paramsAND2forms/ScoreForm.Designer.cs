namespace paramsAND2forms
{
    partial class ScoreForm
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
            this.buttonSaveXml = new System.Windows.Forms.Button();
            this.labelBefoSave = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.labelAfterSave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSaveXml
            // 
            this.buttonSaveXml.Location = new System.Drawing.Point(29, 93);
            this.buttonSaveXml.Name = "buttonSaveXml";
            this.buttonSaveXml.Size = new System.Drawing.Size(232, 23);
            this.buttonSaveXml.TabIndex = 0;
            this.buttonSaveXml.Text = "Сохранить в xml";
            this.buttonSaveXml.UseVisualStyleBackColor = true;
            this.buttonSaveXml.Click += new System.EventHandler(this.buttonSaveXml_Click);
            // 
            // labelBefoSave
            // 
            this.labelBefoSave.AutoSize = true;
            this.labelBefoSave.Location = new System.Drawing.Point(26, 65);
            this.labelBefoSave.Name = "labelBefoSave";
            this.labelBefoSave.Size = new System.Drawing.Size(35, 13);
            this.labelBefoSave.TabIndex = 1;
            this.labelBefoSave.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(29, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Счиатать из xml";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelAfterSave
            // 
            this.labelAfterSave.AutoSize = true;
            this.labelAfterSave.Location = new System.Drawing.Point(26, 228);
            this.labelAfterSave.Name = "labelAfterSave";
            this.labelAfterSave.Size = new System.Drawing.Size(35, 13);
            this.labelAfterSave.TabIndex = 3;
            this.labelAfterSave.Text = "label1";
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelAfterSave);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelBefoSave);
            this.Controls.Add(this.buttonSaveXml);
            this.Name = "ScoreForm";
            this.Text = "ScoreForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveXml;
        private System.Windows.Forms.Label labelBefoSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelAfterSave;
    }
}