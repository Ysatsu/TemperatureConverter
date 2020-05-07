namespace TemperatureConverter
{
    partial class FormTemp
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
            this.groupBoxScale = new System.Windows.Forms.GroupBox();
            this.radBtnUnseen = new System.Windows.Forms.RadioButton();
            this.radBtnKelvin = new System.Windows.Forms.RadioButton();
            this.radBtnCelsius = new System.Windows.Forms.RadioButton();
            this.radBtnFahrenheit = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxTemp = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.rchTxtBoxTemp = new System.Windows.Forms.RichTextBox();
            this.groupBoxScale.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxScale
            // 
            this.groupBoxScale.Controls.Add(this.radBtnUnseen);
            this.groupBoxScale.Controls.Add(this.radBtnKelvin);
            this.groupBoxScale.Controls.Add(this.radBtnCelsius);
            this.groupBoxScale.Controls.Add(this.radBtnFahrenheit);
            this.groupBoxScale.Location = new System.Drawing.Point(26, 30);
            this.groupBoxScale.Name = "groupBoxScale";
            this.groupBoxScale.Size = new System.Drawing.Size(162, 129);
            this.groupBoxScale.TabIndex = 0;
            this.groupBoxScale.TabStop = false;
            this.groupBoxScale.Text = "Scale";
            // 
            // radBtnUnseen
            // 
            this.radBtnUnseen.AutoSize = true;
            this.radBtnUnseen.Checked = true;
            this.radBtnUnseen.Location = new System.Drawing.Point(71, 7);
            this.radBtnUnseen.Name = "radBtnUnseen";
            this.radBtnUnseen.Size = new System.Drawing.Size(62, 17);
            this.radBtnUnseen.TabIndex = 0;
            this.radBtnUnseen.TabStop = true;
            this.radBtnUnseen.Text = "Unseen";
            this.radBtnUnseen.UseVisualStyleBackColor = true;
            this.radBtnUnseen.Visible = false;
            // 
            // radBtnKelvin
            // 
            this.radBtnKelvin.AutoSize = true;
            this.radBtnKelvin.Location = new System.Drawing.Point(22, 97);
            this.radBtnKelvin.Name = "radBtnKelvin";
            this.radBtnKelvin.Size = new System.Drawing.Size(54, 17);
            this.radBtnKelvin.TabIndex = 3;
            this.radBtnKelvin.Text = "&Kelvin";
            this.radBtnKelvin.UseVisualStyleBackColor = true;
            this.radBtnKelvin.CheckedChanged += new System.EventHandler(this.radBtnKelvin_CheckedChanged);
            // 
            // radBtnCelsius
            // 
            this.radBtnCelsius.AutoSize = true;
            this.radBtnCelsius.Location = new System.Drawing.Point(22, 64);
            this.radBtnCelsius.Name = "radBtnCelsius";
            this.radBtnCelsius.Size = new System.Drawing.Size(58, 17);
            this.radBtnCelsius.TabIndex = 2;
            this.radBtnCelsius.Text = "Ce&lsius";
            this.radBtnCelsius.UseVisualStyleBackColor = true;
            this.radBtnCelsius.CheckedChanged += new System.EventHandler(this.radBtnCelsius_CheckedChanged);
            // 
            // radBtnFahrenheit
            // 
            this.radBtnFahrenheit.AutoSize = true;
            this.radBtnFahrenheit.Location = new System.Drawing.Point(22, 30);
            this.radBtnFahrenheit.Name = "radBtnFahrenheit";
            this.radBtnFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.radBtnFahrenheit.TabIndex = 1;
            this.radBtnFahrenheit.Text = "&Fahrenheit";
            this.radBtnFahrenheit.UseVisualStyleBackColor = true;
            this.radBtnFahrenheit.CheckedChanged += new System.EventHandler(this.radBtnFahrenheit_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Enter the Temperature:";
            // 
            // txtBxTemp
            // 
            this.txtBxTemp.Location = new System.Drawing.Point(167, 192);
            this.txtBxTemp.Name = "txtBxTemp";
            this.txtBxTemp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBxTemp.Size = new System.Drawing.Size(80, 20);
            this.txtBxTemp.TabIndex = 2;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(49, 242);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(82, 22);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(177, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 22);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(305, 242);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 22);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rchTxtBoxTemp
            // 
            this.rchTxtBoxTemp.Location = new System.Drawing.Point(29, 298);
            this.rchTxtBoxTemp.Name = "rchTxtBoxTemp";
            this.rchTxtBoxTemp.Size = new System.Drawing.Size(384, 139);
            this.rchTxtBoxTemp.TabIndex = 6;
            this.rchTxtBoxTemp.Text = "";
            // 
            // FormTemp
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(443, 470);
            this.Controls.Add(this.rchTxtBoxTemp);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtBxTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxScale);
            this.Name = "FormTemp";
            this.Text = "Temperature Converter";
            this.groupBoxScale.ResumeLayout(false);
            this.groupBoxScale.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxScale;
        private System.Windows.Forms.RadioButton radBtnKelvin;
        private System.Windows.Forms.RadioButton radBtnCelsius;
        private System.Windows.Forms.RadioButton radBtnFahrenheit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxTemp;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox rchTxtBoxTemp;
        private System.Windows.Forms.RadioButton radBtnUnseen;
    }
}

