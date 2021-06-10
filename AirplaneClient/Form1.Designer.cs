
namespace AirplaneClient
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxReg = new System.Windows.Forms.TextBox();
            this.tbxCallSign = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblConnected = new System.Windows.Forms.Label();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(51, 26);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(124, 57);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(374, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Regestration";
            // 
            // tbxReg
            // 
            this.tbxReg.Location = new System.Drawing.Point(364, 155);
            this.tbxReg.Name = "tbxReg";
            this.tbxReg.Size = new System.Drawing.Size(109, 20);
            this.tbxReg.TabIndex = 2;
            // 
            // tbxCallSign
            // 
            this.tbxCallSign.Location = new System.Drawing.Point(553, 155);
            this.tbxCallSign.Name = "tbxCallSign";
            this.tbxCallSign.Size = new System.Drawing.Size(109, 20);
            this.tbxCallSign.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(567, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Call Sign";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(690, 136);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(124, 57);
            this.btnSet.TabIndex = 6;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblConnected.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnected.Location = new System.Drawing.Point(231, 42);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(86, 31);
            this.lblConnected.TabIndex = 7;
            this.lblConnected.Text = "label1";
            this.lblConnected.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(64, 89);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(96, 28);
            this.BtnDisconnect.TabIndex = 8;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 469);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.lblConnected);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.tbxCallSign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxReg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxReg;
        private System.Windows.Forms.TextBox tbxCallSign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Button BtnDisconnect;
    }
}

