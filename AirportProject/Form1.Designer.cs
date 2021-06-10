
namespace AirportProject
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
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.allPlanes = new System.Windows.Forms.TabPage();
            this.Info = new System.Windows.Forms.TabPage();
            this.airplaneListBox = new System.Windows.Forms.ListBox();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxReg = new System.Windows.Forms.TextBox();
            this.tbxCall = new System.Windows.Forms.TextBox();
            this.btnModel = new System.Windows.Forms.Button();
            this.btnEngine = new System.Windows.Forms.Button();
            this.callSignSet = new System.Windows.Forms.Button();
            this.mainTabControl.SuspendLayout();
            this.allPlanes.SuspendLayout();
            this.Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.allPlanes);
            this.mainTabControl.Controls.Add(this.Info);
            this.mainTabControl.Location = new System.Drawing.Point(27, 35);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1090, 492);
            this.mainTabControl.TabIndex = 0;
            // 
            // allPlanes
            // 
            this.allPlanes.Controls.Add(this.BtnInfo);
            this.allPlanes.Controls.Add(this.airplaneListBox);
            this.allPlanes.Location = new System.Drawing.Point(4, 22);
            this.allPlanes.Name = "allPlanes";
            this.allPlanes.Padding = new System.Windows.Forms.Padding(3);
            this.allPlanes.Size = new System.Drawing.Size(1082, 466);
            this.allPlanes.TabIndex = 0;
            this.allPlanes.Text = "All Planes";
            this.allPlanes.UseVisualStyleBackColor = true;
            // 
            // Info
            // 
            this.Info.Controls.Add(this.callSignSet);
            this.Info.Controls.Add(this.btnEngine);
            this.Info.Controls.Add(this.btnModel);
            this.Info.Controls.Add(this.tbxCall);
            this.Info.Controls.Add(this.tbxReg);
            this.Info.Controls.Add(this.label4);
            this.Info.Controls.Add(this.label3);
            this.Info.Controls.Add(this.label2);
            this.Info.Controls.Add(this.label1);
            this.Info.Location = new System.Drawing.Point(4, 22);
            this.Info.Name = "Info";
            this.Info.Padding = new System.Windows.Forms.Padding(3);
            this.Info.Size = new System.Drawing.Size(1082, 466);
            this.Info.TabIndex = 1;
            this.Info.Text = "Info";
            this.Info.UseVisualStyleBackColor = true;
            // 
            // airplaneListBox
            // 
            this.airplaneListBox.FormattingEnabled = true;
            this.airplaneListBox.Location = new System.Drawing.Point(109, 94);
            this.airplaneListBox.Name = "airplaneListBox";
            this.airplaneListBox.Size = new System.Drawing.Size(476, 251);
            this.airplaneListBox.TabIndex = 0;
            // 
            // BtnInfo
            // 
            this.BtnInfo.Location = new System.Drawing.Point(108, 38);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(105, 42);
            this.BtnInfo.TabIndex = 1;
            this.BtnInfo.Text = "Info";
            this.BtnInfo.UseVisualStyleBackColor = true;
            this.BtnInfo.Click += new System.EventHandler(this.BtnInfo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Regestration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "CallSign";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Engine";
            // 
            // tbxReg
            // 
            this.tbxReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxReg.Location = new System.Drawing.Point(196, 40);
            this.tbxReg.Name = "tbxReg";
            this.tbxReg.Size = new System.Drawing.Size(100, 26);
            this.tbxReg.TabIndex = 4;
            this.tbxReg.TextChanged += new System.EventHandler(this.tbxReg_TextChanged);
            // 
            // tbxCall
            // 
            this.tbxCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCall.Location = new System.Drawing.Point(196, 72);
            this.tbxCall.Name = "tbxCall";
            this.tbxCall.Size = new System.Drawing.Size(100, 26);
            this.tbxCall.TabIndex = 5;
            // 
            // btnModel
            // 
            this.btnModel.Location = new System.Drawing.Point(196, 104);
            this.btnModel.Name = "btnModel";
            this.btnModel.Size = new System.Drawing.Size(97, 28);
            this.btnModel.TabIndex = 6;
            this.btnModel.Text = "button1";
            this.btnModel.UseVisualStyleBackColor = true;
            this.btnModel.Click += new System.EventHandler(this.btnModel_Click);
            // 
            // btnEngine
            // 
            this.btnEngine.Location = new System.Drawing.Point(196, 143);
            this.btnEngine.Name = "btnEngine";
            this.btnEngine.Size = new System.Drawing.Size(97, 28);
            this.btnEngine.TabIndex = 7;
            this.btnEngine.Text = "button2";
            this.btnEngine.UseVisualStyleBackColor = true;
            // 
            // callSignSet
            // 
            this.callSignSet.Location = new System.Drawing.Point(316, 70);
            this.callSignSet.Name = "callSignSet";
            this.callSignSet.Size = new System.Drawing.Size(97, 28);
            this.callSignSet.TabIndex = 8;
            this.callSignSet.Text = "Set";
            this.callSignSet.UseVisualStyleBackColor = true;
            this.callSignSet.Click += new System.EventHandler(this.callSignSet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 539);
            this.Controls.Add(this.mainTabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainTabControl.ResumeLayout(false);
            this.allPlanes.ResumeLayout(false);
            this.Info.ResumeLayout(false);
            this.Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage allPlanes;
        private System.Windows.Forms.TabPage Info;
        private System.Windows.Forms.ListBox airplaneListBox;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.TextBox tbxCall;
        private System.Windows.Forms.TextBox tbxReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEngine;
        private System.Windows.Forms.Button btnModel;
        private System.Windows.Forms.Button callSignSet;
    }
}

