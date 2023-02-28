namespace IvyESD
{
    partial class Scan
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
            this.gbScan = new System.Windows.Forms.GroupBox();
            this.txtInputCode = new System.Windows.Forms.TextBox();
            this.lblScan = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radbtnCalcanheira = new System.Windows.Forms.RadioButton();
            this.txtTest = new System.Windows.Forms.TextBox();
            this.lblExpectedTest = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbInfo = new System.Windows.Forms.GroupBox();
            this.lblSelect = new System.Windows.Forms.Label();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.gbScan.SuspendLayout();
            this.gbInfo.SuspendLayout();
            this.gbSelect.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbScan
            // 
            this.gbScan.Controls.Add(this.txtInputCode);
            this.gbScan.Controls.Add(this.lblScan);
            this.gbScan.Location = new System.Drawing.Point(12, 9);
            this.gbScan.Margin = new System.Windows.Forms.Padding(0);
            this.gbScan.Name = "gbScan";
            this.gbScan.Padding = new System.Windows.Forms.Padding(0);
            this.gbScan.Size = new System.Drawing.Size(467, 111);
            this.gbScan.TabIndex = 0;
            this.gbScan.TabStop = false;
            // 
            // txtInputCode
            // 
            this.txtInputCode.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInputCode.Location = new System.Drawing.Point(8, 60);
            this.txtInputCode.Name = "txtInputCode";
            this.txtInputCode.Size = new System.Drawing.Size(446, 38);
            this.txtInputCode.TabIndex = 1;
            this.txtInputCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputCode_KeyDown);
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScan.Location = new System.Drawing.Point(1, 22);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(453, 33);
            this.lblScan.TabIndex = 0;
            this.lblScan.Text = "Por favor, aproxime seu código do scanner.";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton1.Location = new System.Drawing.Point(14, 89);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(201, 31);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Calcanheira/Pulseira";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radbtnCalcanheira
            // 
            this.radbtnCalcanheira.AutoSize = true;
            this.radbtnCalcanheira.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radbtnCalcanheira.Location = new System.Drawing.Point(14, 52);
            this.radbtnCalcanheira.Name = "radbtnCalcanheira";
            this.radbtnCalcanheira.Size = new System.Drawing.Size(130, 31);
            this.radbtnCalcanheira.TabIndex = 5;
            this.radbtnCalcanheira.TabStop = true;
            this.radbtnCalcanheira.Text = "Calcanheira";
            this.radbtnCalcanheira.UseVisualStyleBackColor = true;
            // 
            // txtTest
            // 
            this.txtTest.Enabled = false;
            this.txtTest.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTest.Location = new System.Drawing.Point(15, 213);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(362, 34);
            this.txtTest.TabIndex = 11;
            // 
            // lblExpectedTest
            // 
            this.lblExpectedTest.AutoSize = true;
            this.lblExpectedTest.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpectedTest.Location = new System.Drawing.Point(8, 183);
            this.lblExpectedTest.Name = "lblExpectedTest";
            this.lblExpectedTest.Size = new System.Drawing.Size(150, 27);
            this.lblExpectedTest.TabIndex = 10;
            this.lblExpectedTest.Text = "Teste necessário";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(15, 126);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(362, 34);
            this.txtName.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(8, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 27);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nome";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblSelect);
            this.gbInfo.Controls.Add(this.radbtnCalcanheira);
            this.gbInfo.Controls.Add(this.radioButton1);
            this.gbInfo.Location = new System.Drawing.Point(12, 135);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(0);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(0);
            this.gbInfo.Size = new System.Drawing.Size(467, 138);
            this.gbInfo.TabIndex = 12;
            this.gbInfo.TabStop = false;
            this.gbInfo.Visible = false;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelect.Location = new System.Drawing.Point(8, 20);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(324, 33);
            this.lblSelect.TabIndex = 7;
            this.lblSelect.Text = "Quais testes foram realizados?";
            // 
            // gbSelect
            // 
            this.gbSelect.Controls.Add(this.txtCode);
            this.gbSelect.Controls.Add(this.lblCode);
            this.gbSelect.Controls.Add(this.txtName);
            this.gbSelect.Controls.Add(this.txtTest);
            this.gbSelect.Controls.Add(this.lblName);
            this.gbSelect.Controls.Add(this.lblExpectedTest);
            this.gbSelect.Location = new System.Drawing.Point(487, 9);
            this.gbSelect.Margin = new System.Windows.Forms.Padding(0);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Padding = new System.Windows.Forms.Padding(0);
            this.gbSelect.Size = new System.Drawing.Size(402, 264);
            this.gbSelect.TabIndex = 13;
            this.gbSelect.TabStop = false;
            this.gbSelect.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(15, 48);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(362, 34);
            this.txtCode.TabIndex = 13;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCode.Location = new System.Drawing.Point(8, 18);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(70, 27);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Código";
            // 
            // Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 284);
            this.ControlBox = false;
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbScan);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Scan";
            this.Text = "Scan";
            this.gbScan.ResumeLayout(false);
            this.gbScan.PerformLayout();
            this.gbInfo.ResumeLayout(false);
            this.gbInfo.PerformLayout();
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox gbScan;
        private TextBox txtInputCode;
        private Label lblScan;
        private RadioButton radioButton1;
        private RadioButton radbtnCalcanheira;
        private TextBox txtTest;
        private Label lblExpectedTest;
        private TextBox txtName;
        private Label lblName;
        private GroupBox gbInfo;
        private GroupBox gbSelect;
        private Label lblSelect;
        private TextBox txtCode;
        private Label lblCode;
    }
}