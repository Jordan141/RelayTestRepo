namespace frmInsurance
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpPolicyStart = new System.Windows.Forms.DateTimePicker();
            this.lblPolicyStart = new System.Windows.Forms.Label();
            this.gbAddDriver = new System.Windows.Forms.GroupBox();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.gbClaim = new System.Windows.Forms.GroupBox();
            this.btnAddClaim = new System.Windows.Forms.Button();
            this.dpDateOfClaim = new System.Windows.Forms.DateTimePicker();
            this.lblDateOfClaim = new System.Windows.Forms.Label();
            this.dpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDob = new System.Windows.Forms.Label();
            this.cbOccupation = new System.Windows.Forms.ComboBox();
            this.lblOccupation = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.ep1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnProccess = new System.Windows.Forms.Button();
            this.rtbDriverInfo = new System.Windows.Forms.RichTextBox();
            this.rtbCalculation = new System.Windows.Forms.RichTextBox();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblTip = new System.Windows.Forms.Label();
            this.lblTip2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbAddDriver.SuspendLayout();
            this.gbClaim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(231, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(386, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Holmes Car Insurance Calculations";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpPolicyStart
            // 
            this.dtpPolicyStart.Location = new System.Drawing.Point(150, 95);
            this.dtpPolicyStart.Name = "dtpPolicyStart";
            this.dtpPolicyStart.Size = new System.Drawing.Size(200, 23);
            this.dtpPolicyStart.TabIndex = 1;
            this.toolTip1.SetToolTip(this.dtpPolicyStart, "Choose a start date for your policy");
            this.dtpPolicyStart.ValueChanged += new System.EventHandler(this.dtpPolicyStart_ValueChanged);
            // 
            // lblPolicyStart
            // 
            this.lblPolicyStart.AutoSize = true;
            this.lblPolicyStart.Location = new System.Drawing.Point(15, 101);
            this.lblPolicyStart.Name = "lblPolicyStart";
            this.lblPolicyStart.Size = new System.Drawing.Size(106, 15);
            this.lblPolicyStart.TabIndex = 2;
            this.lblPolicyStart.Text = "Policy Start Date";
            // 
            // gbAddDriver
            // 
            this.gbAddDriver.Controls.Add(this.btnAddDriver);
            this.gbAddDriver.Controls.Add(this.gbClaim);
            this.gbAddDriver.Controls.Add(this.dpDateOfBirth);
            this.gbAddDriver.Controls.Add(this.lblDob);
            this.gbAddDriver.Controls.Add(this.cbOccupation);
            this.gbAddDriver.Controls.Add(this.lblOccupation);
            this.gbAddDriver.Controls.Add(this.txtName);
            this.gbAddDriver.Controls.Add(this.lblName);
            this.gbAddDriver.Enabled = false;
            this.gbAddDriver.Location = new System.Drawing.Point(490, 309);
            this.gbAddDriver.Name = "gbAddDriver";
            this.gbAddDriver.Size = new System.Drawing.Size(320, 285);
            this.gbAddDriver.TabIndex = 3;
            this.gbAddDriver.TabStop = false;
            this.gbAddDriver.Text = "Add Driver";
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(115, 253);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(85, 23);
            this.btnAddDriver.TabIndex = 8;
            this.btnAddDriver.Text = "Add Driver";
            this.toolTip1.SetToolTip(this.btnAddDriver, "Please enter the claims before adding driver. Select date then click add driver.");
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // gbClaim
            // 
            this.gbClaim.Controls.Add(this.btnAddClaim);
            this.gbClaim.Controls.Add(this.dpDateOfClaim);
            this.gbClaim.Controls.Add(this.lblDateOfClaim);
            this.gbClaim.Location = new System.Drawing.Point(13, 157);
            this.gbClaim.Name = "gbClaim";
            this.gbClaim.Size = new System.Drawing.Size(285, 90);
            this.gbClaim.TabIndex = 6;
            this.gbClaim.TabStop = false;
            this.gbClaim.Text = "Add Claim";
            this.toolTip1.SetToolTip(this.gbClaim, "Please enter the claims before adding driver. Select date then click add driver.");
            // 
            // btnAddClaim
            // 
            this.btnAddClaim.Location = new System.Drawing.Point(102, 61);
            this.btnAddClaim.Name = "btnAddClaim";
            this.btnAddClaim.Size = new System.Drawing.Size(85, 23);
            this.btnAddClaim.TabIndex = 7;
            this.btnAddClaim.Text = "Add Claim";
            this.toolTip1.SetToolTip(this.btnAddClaim, "Please enter the claims before adding driver. Select date then click add driver.");
            this.btnAddClaim.UseVisualStyleBackColor = true;
            this.btnAddClaim.Click += new System.EventHandler(this.btnAddClaim_Click);
            // 
            // dpDateOfClaim
            // 
            this.dpDateOfClaim.Location = new System.Drawing.Point(102, 32);
            this.dpDateOfClaim.Name = "dpDateOfClaim";
            this.dpDateOfClaim.Size = new System.Drawing.Size(157, 23);
            this.dpDateOfClaim.TabIndex = 6;
            this.toolTip1.SetToolTip(this.dpDateOfClaim, "Please enter the claims before adding driver. Select date then click add driver.");
            // 
            // lblDateOfClaim
            // 
            this.lblDateOfClaim.AutoSize = true;
            this.lblDateOfClaim.Location = new System.Drawing.Point(7, 38);
            this.lblDateOfClaim.Name = "lblDateOfClaim";
            this.lblDateOfClaim.Size = new System.Drawing.Size(89, 15);
            this.lblDateOfClaim.TabIndex = 0;
            this.lblDateOfClaim.Text = "Date Of Claim";
            this.toolTip1.SetToolTip(this.lblDateOfClaim, "Please enter the claims before adding driver. Select date then click add driver.");
            this.lblDateOfClaim.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dpDateOfBirth
            // 
            this.dpDateOfBirth.Enabled = false;
            this.dpDateOfBirth.Location = new System.Drawing.Point(98, 110);
            this.dpDateOfBirth.Name = "dpDateOfBirth";
            this.dpDateOfBirth.Size = new System.Drawing.Size(200, 23);
            this.dpDateOfBirth.TabIndex = 5;
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Location = new System.Drawing.Point(10, 116);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(82, 15);
            this.lblDob.TabIndex = 4;
            this.lblDob.Text = "Date of Birth";
            // 
            // cbOccupation
            // 
            this.cbOccupation.Enabled = false;
            this.cbOccupation.FormattingEnabled = true;
            this.cbOccupation.Items.AddRange(new object[] {
            "Accountant",
            "Chauffeur"});
            this.cbOccupation.Location = new System.Drawing.Point(98, 76);
            this.cbOccupation.Name = "cbOccupation";
            this.cbOccupation.Size = new System.Drawing.Size(200, 23);
            this.cbOccupation.TabIndex = 3;
            this.cbOccupation.SelectedIndexChanged += new System.EventHandler(this.cbOccupation_SelectedIndexChanged);
            // 
            // lblOccupation
            // 
            this.lblOccupation.AutoSize = true;
            this.lblOccupation.Location = new System.Drawing.Point(7, 79);
            this.lblOccupation.Name = "lblOccupation";
            this.lblOccupation.Size = new System.Drawing.Size(74, 15);
            this.lblOccupation.TabIndex = 2;
            this.lblOccupation.Text = "Occupation";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(98, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 23);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // ep1
            // 
            this.ep1.ContainerControl = this;
            // 
            // btnProccess
            // 
            this.btnProccess.Location = new System.Drawing.Point(16, 567);
            this.btnProccess.Name = "btnProccess";
            this.btnProccess.Size = new System.Drawing.Size(192, 25);
            this.btnProccess.TabIndex = 4;
            this.btnProccess.Text = "Calculate Claim";
            this.btnProccess.UseVisualStyleBackColor = true;
            this.btnProccess.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbDriverInfo
            // 
            this.rtbDriverInfo.Location = new System.Drawing.Point(490, 95);
            this.rtbDriverInfo.Name = "rtbDriverInfo";
            this.rtbDriverInfo.Size = new System.Drawing.Size(317, 197);
            this.rtbDriverInfo.TabIndex = 5;
            this.rtbDriverInfo.Text = "";
            // 
            // rtbCalculation
            // 
            this.rtbCalculation.Location = new System.Drawing.Point(16, 232);
            this.rtbCalculation.Name = "rtbCalculation";
            this.rtbCalculation.ReadOnly = true;
            this.rtbCalculation.Size = new System.Drawing.Size(444, 329);
            this.rtbCalculation.TabIndex = 6;
            this.rtbCalculation.Text = "";
            // 
            // lblDriver
            // 
            this.lblDriver.AutoSize = true;
            this.lblDriver.Location = new System.Drawing.Point(487, 64);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(135, 15);
            this.lblDriver.TabIndex = 7;
            this.lblDriver.Text = "Information on drivers";
            // 
            // lblTitle2
            // 
            this.lblTitle2.AutoSize = true;
            this.lblTitle2.Location = new System.Drawing.Point(13, 200);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(108, 15);
            this.lblTitle2.TabIndex = 8;
            this.lblTitle2.Text = "Policy calculation";
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(15, 139);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(314, 15);
            this.lblTip.TabIndex = 9;
            this.lblTip.Text = "Please enter in at least one driver and no more that 5.";
            // 
            // lblTip2
            // 
            this.lblTip2.AutoSize = true;
            this.lblTip2.Location = new System.Drawing.Point(15, 154);
            this.lblTip2.Name = "lblTip2";
            this.lblTip2.Size = new System.Drawing.Size(195, 15);
            this.lblTip2.TabIndex = 10;
            this.lblTip2.Text = "Each with no more that 5 claims.";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(369, 567);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 27);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save Policy";
            this.toolTip1.SetToolTip(this.btnSave, "Save the data to XML");
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(281, 567);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(82, 27);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load Policy";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(849, 602);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblTip2);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.rtbCalculation);
            this.Controls.Add(this.rtbDriverInfo);
            this.Controls.Add(this.btnProccess);
            this.Controls.Add(this.gbAddDriver);
            this.Controls.Add(this.lblPolicyStart);
            this.Controls.Add(this.dtpPolicyStart);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("NeueHaasGroteskText Pro", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Text = "Holmes Car Insurance";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbAddDriver.ResumeLayout(false);
            this.gbAddDriver.PerformLayout();
            this.gbClaim.ResumeLayout(false);
            this.gbClaim.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpPolicyStart;
        private System.Windows.Forms.Label lblPolicyStart;
        private System.Windows.Forms.GroupBox gbAddDriver;
        private System.Windows.Forms.DateTimePicker dpDateOfBirth;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.ComboBox cbOccupation;
        private System.Windows.Forms.Label lblOccupation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbClaim;
        private System.Windows.Forms.DateTimePicker dpDateOfClaim;
        private System.Windows.Forms.Label lblDateOfClaim;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddClaim;
        private System.Windows.Forms.ErrorProvider ep1;
        private System.Windows.Forms.Button btnProccess;
        private System.Windows.Forms.Label lblTip2;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.RichTextBox rtbCalculation;
        private System.Windows.Forms.RichTextBox rtbDriverInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}

