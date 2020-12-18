namespace VINDecoder
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
            this.cmboxManufacture = new System.Windows.Forms.ComboBox();
            this.cmboxYear = new System.Windows.Forms.ComboBox();
            this.cmboxVehicleType = new System.Windows.Forms.ComboBox();
            this.txtEngineNumber = new System.Windows.Forms.TextBox();
            this.cmboxPlant = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGetString = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtGet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmboxManufacture
            // 
            this.cmboxManufacture.FormattingEnabled = true;
            this.cmboxManufacture.Location = new System.Drawing.Point(45, 103);
            this.cmboxManufacture.Name = "cmboxManufacture";
            this.cmboxManufacture.Size = new System.Drawing.Size(155, 21);
            this.cmboxManufacture.TabIndex = 0;
            // 
            // cmboxYear
            // 
            this.cmboxYear.FormattingEnabled = true;
            this.cmboxYear.Location = new System.Drawing.Point(221, 102);
            this.cmboxYear.Name = "cmboxYear";
            this.cmboxYear.Size = new System.Drawing.Size(132, 21);
            this.cmboxYear.TabIndex = 1;
            // 
            // cmboxVehicleType
            // 
            this.cmboxVehicleType.FormattingEnabled = true;
            this.cmboxVehicleType.Location = new System.Drawing.Point(370, 103);
            this.cmboxVehicleType.Name = "cmboxVehicleType";
            this.cmboxVehicleType.Size = new System.Drawing.Size(132, 21);
            this.cmboxVehicleType.TabIndex = 2;
            // 
            // txtEngineNumber
            // 
            this.txtEngineNumber.Location = new System.Drawing.Point(519, 103);
            this.txtEngineNumber.Name = "txtEngineNumber";
            this.txtEngineNumber.Size = new System.Drawing.Size(150, 20);
            this.txtEngineNumber.TabIndex = 3;
            this.txtEngineNumber.TextChanged += new System.EventHandler(this.txtEngineNumber_TextChanged);
            this.txtEngineNumber.MouseLeave += new System.EventHandler(this.txtEngineNumber_MouseLeave);
            // 
            // cmboxPlant
            // 
            this.cmboxPlant.FormattingEnabled = true;
            this.cmboxPlant.Location = new System.Drawing.Point(688, 102);
            this.cmboxPlant.Name = "cmboxPlant";
            this.cmboxPlant.Size = new System.Drawing.Size(139, 21);
            this.cmboxPlant.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Manufacture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "YearOfMaking";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(367, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "VehicleType";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(516, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "EngineNumber";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(685, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Plant";
            // 
            // lblGetString
            // 
            this.lblGetString.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGetString.Location = new System.Drawing.Point(370, 198);
            this.lblGetString.Name = "lblGetString";
            this.lblGetString.Size = new System.Drawing.Size(182, 23);
            this.lblGetString.TabIndex = 10;
            this.lblGetString.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(370, 159);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(136, 23);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtGet
            // 
            this.txtGet.Location = new System.Drawing.Point(157, 201);
            this.txtGet.Name = "txtGet";
            this.txtGet.Size = new System.Drawing.Size(158, 20);
            this.txtGet.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 262);
            this.Controls.Add(this.txtGet);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.lblGetString);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboxPlant);
            this.Controls.Add(this.txtEngineNumber);
            this.Controls.Add(this.cmboxVehicleType);
            this.Controls.Add(this.cmboxYear);
            this.Controls.Add(this.cmboxManufacture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboxManufacture;
        private System.Windows.Forms.ComboBox cmboxYear;
        private System.Windows.Forms.ComboBox cmboxVehicleType;
        private System.Windows.Forms.TextBox txtEngineNumber;
        private System.Windows.Forms.ComboBox cmboxPlant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGetString;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtGet;
    }
}

