namespace GeoLib.Client
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
            this.lblGetZipInfo = new System.Windows.Forms.Label();
            this.txtGetZipInfo = new System.Windows.Forms.TextBox();
            this.btnGetZipInfo = new System.Windows.Forms.Button();
            this.lblState = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.btnGetZips = new System.Windows.Forms.Button();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStateInfo = new System.Windows.Forms.Label();
            this.lstZips = new System.Windows.Forms.ListView();
            this.btnMakeCall = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblGetZipInfo
            // 
            this.lblGetZipInfo.AutoSize = true;
            this.lblGetZipInfo.Location = new System.Drawing.Point(46, 46);
            this.lblGetZipInfo.Name = "lblGetZipInfo";
            this.lblGetZipInfo.Size = new System.Drawing.Size(63, 13);
            this.lblGetZipInfo.TabIndex = 0;
            this.lblGetZipInfo.Text = "Get Zip Info";
            // 
            // txtGetZipInfo
            // 
            this.txtGetZipInfo.Location = new System.Drawing.Point(145, 46);
            this.txtGetZipInfo.Name = "txtGetZipInfo";
            this.txtGetZipInfo.Size = new System.Drawing.Size(100, 20);
            this.txtGetZipInfo.TabIndex = 1;
            // 
            // btnGetZipInfo
            // 
            this.btnGetZipInfo.Location = new System.Drawing.Point(155, 90);
            this.btnGetZipInfo.Name = "btnGetZipInfo";
            this.btnGetZipInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetZipInfo.TabIndex = 2;
            this.btnGetZipInfo.Text = "Get Zip Info";
            this.btnGetZipInfo.UseVisualStyleBackColor = true;
            this.btnGetZipInfo.Click += new System.EventHandler(this.btnGetZipInfo_Click);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(334, 46);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(32, 13);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State";
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(459, 49);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 4;
            // 
            // btnGetZips
            // 
            this.btnGetZips.Location = new System.Drawing.Point(472, 90);
            this.btnGetZips.Name = "btnGetZips";
            this.btnGetZips.Size = new System.Drawing.Size(75, 23);
            this.btnGetZips.TabIndex = 5;
            this.btnGetZips.Text = "Get Zip Codes";
            this.btnGetZips.UseVisualStyleBackColor = true;
            this.btnGetZips.Click += new System.EventHandler(this.btnGetZips_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(152, 135);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(0, 13);
            this.lblCity.TabIndex = 6;
            // 
            // lblStateInfo
            // 
            this.lblStateInfo.AutoSize = true;
            this.lblStateInfo.Location = new System.Drawing.Point(152, 166);
            this.lblStateInfo.Name = "lblStateInfo";
            this.lblStateInfo.Size = new System.Drawing.Size(0, 13);
            this.lblStateInfo.TabIndex = 7;
            // 
            // lstZips
            // 
            this.lstZips.Location = new System.Drawing.Point(459, 135);
            this.lstZips.Name = "lstZips";
            this.lstZips.Size = new System.Drawing.Size(207, 228);
            this.lstZips.TabIndex = 8;
            this.lstZips.UseCompatibleStateImageBehavior = false;
            // 
            // btnMakeCall
            // 
            this.btnMakeCall.Location = new System.Drawing.Point(155, 267);
            this.btnMakeCall.Name = "btnMakeCall";
            this.btnMakeCall.Size = new System.Drawing.Size(75, 23);
            this.btnMakeCall.TabIndex = 9;
            this.btnMakeCall.Text = "Make a Call";
            this.btnMakeCall.UseVisualStyleBackColor = true;
            this.btnMakeCall.Click += new System.EventHandler(this.btnMakeCall_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(145, 216);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(100, 20);
            this.txtMessage.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 508);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnMakeCall);
            this.Controls.Add(this.lstZips);
            this.Controls.Add(this.lblStateInfo);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.btnGetZips);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.btnGetZipInfo);
            this.Controls.Add(this.txtGetZipInfo);
            this.Controls.Add(this.lblGetZipInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetZipInfo;
        private System.Windows.Forms.TextBox txtGetZipInfo;
        private System.Windows.Forms.Button btnGetZipInfo;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Button btnGetZips;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStateInfo;
        private System.Windows.Forms.ListView lstZips;
        private System.Windows.Forms.Button btnMakeCall;
        private System.Windows.Forms.TextBox txtMessage;
    }
}

