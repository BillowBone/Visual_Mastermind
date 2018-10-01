namespace Mastermind
{
    partial class ChooseMode
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.HardMode = new DevExpress.XtraEditors.SimpleButton();
            this.BasicMode = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(227, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(189, 45);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mastermind";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(167, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(310, 33);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Please choose you mode :";
            // 
            // HardMode
            // 
            this.HardMode.Location = new System.Drawing.Point(390, 153);
            this.HardMode.Name = "HardMode";
            this.HardMode.Size = new System.Drawing.Size(209, 101);
            this.HardMode.TabIndex = 3;
            this.HardMode.Text = "Hard mode (No correction)";
            this.HardMode.Click += new System.EventHandler(this.HardMode_Click);
            // 
            // BasicMode
            // 
            this.BasicMode.Location = new System.Drawing.Point(64, 153);
            this.BasicMode.Name = "BasicMode";
            this.BasicMode.Size = new System.Drawing.Size(209, 101);
            this.BasicMode.TabIndex = 4;
            this.BasicMode.Text = "Basic mode (Correction at each turn)";
            this.BasicMode.Click += new System.EventHandler(this.BasicMode_Click_1);
            // 
            // ChooseMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 311);
            this.Controls.Add(this.BasicMode);
            this.Controls.Add(this.HardMode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "ChooseMode";
            this.Text = "ChooseMode";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton HardMode;
        private DevExpress.XtraEditors.SimpleButton BasicMode;
    }
}