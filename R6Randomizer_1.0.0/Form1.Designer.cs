namespace R6Randomizer_1._0._0
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
            this.switchBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.selectOpBtn = new System.Windows.Forms.Button();
            this.presentIco = new System.Windows.Forms.PictureBox();
            this.presentName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.presentIco)).BeginInit();
            this.SuspendLayout();
            // 
            // switchBtn
            // 
            this.switchBtn.Location = new System.Drawing.Point(61, 824);
            this.switchBtn.Margin = new System.Windows.Forms.Padding(5);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(118, 38);
            this.switchBtn.TabIndex = 0;
            this.switchBtn.Text = "Attacker";
            this.switchBtn.UseVisualStyleBackColor = true;
            this.switchBtn.Click += new System.EventHandler(this.switchBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mainPanel.Location = new System.Drawing.Point(61, 53);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(684, 763);
            this.mainPanel.TabIndex = 2;
            // 
            // selectOpBtn
            // 
            this.selectOpBtn.Location = new System.Drawing.Point(61, 872);
            this.selectOpBtn.Margin = new System.Windows.Forms.Padding(5);
            this.selectOpBtn.Name = "selectOpBtn";
            this.selectOpBtn.Size = new System.Drawing.Size(184, 38);
            this.selectOpBtn.TabIndex = 3;
            this.selectOpBtn.Text = "Select Opperator";
            this.selectOpBtn.UseVisualStyleBackColor = true;
            this.selectOpBtn.Click += new System.EventHandler(this.selectOpBtn_Click);
            // 
            // presentIco
            // 
            this.presentIco.Location = new System.Drawing.Point(398, 860);
            this.presentIco.Name = "presentIco";
            this.presentIco.Size = new System.Drawing.Size(80, 73);
            this.presentIco.TabIndex = 4;
            this.presentIco.TabStop = false;
            // 
            // presentName
            // 
            this.presentName.Location = new System.Drawing.Point(398, 916);
            this.presentName.Name = "presentName";
            this.presentName.Size = new System.Drawing.Size(100, 33);
            this.presentName.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 918);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(815, 1013);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.presentName);
            this.Controls.Add(this.presentIco);
            this.Controls.Add(this.selectOpBtn);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.switchBtn);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.presentIco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button switchBtn;
        private Panel mainPanel;
        private Button selectOpBtn;
        private PictureBox presentIco;
        private TextBox presentName;
        private Button button1;
    }
}