
namespace Kenner
{
    partial class load
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
            this.dtgLoad = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoad)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLoad
            // 
            this.dtgLoad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLoad.Location = new System.Drawing.Point(3, 2);
            this.dtgLoad.Name = "dtgLoad";
            this.dtgLoad.Size = new System.Drawing.Size(342, 540);
            this.dtgLoad.TabIndex = 0;
            this.dtgLoad.Click += new System.EventHandler(this.dtgLoad_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(297, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Logar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(361, 518);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "Logar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 641);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "load";
            this.Load += new System.EventHandler(this.load_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLoad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgLoad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}