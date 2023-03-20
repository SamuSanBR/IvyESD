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
            this.radbtnCalcanheiraPulseira = new System.Windows.Forms.RadioButton();
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
            this.gbScan.Location = new System.Drawing.Point(26, 18);
            this.gbScan.Margin = new System.Windows.Forms.Padding(0);
            this.gbScan.Name = "gbScan";
            this.gbScan.Padding = new System.Windows.Forms.Padding(0);
            this.gbScan.Size = new System.Drawing.Size(992, 228);
            this.gbScan.TabIndex = 0;
            this.gbScan.TabStop = false;
            // 
            // txtInputCode
            // 
            this.txtInputCode.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInputCode.Location = new System.Drawing.Point(17, 123);
            this.txtInputCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtInputCode.Name = "txtInputCode";
            this.txtInputCode.Size = new System.Drawing.Size(943, 69);
            this.txtInputCode.TabIndex = 1;
            this.txtInputCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInputCode_KeyDown);
            // 
            // lblScan
            // 
            this.lblScan.AutoSize = true;
            this.lblScan.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScan.Location = new System.Drawing.Point(2, 45);
            this.lblScan.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblScan.Name = "lblScan";
            this.lblScan.Size = new System.Drawing.Size(906, 65);
            this.lblScan.TabIndex = 0;
            this.lblScan.Text = "Por favor, aproxime seu código do scanner.";
            // 
            // radbtnCalcanheiraPulseira
            // 
            this.radbtnCalcanheiraPulseira.AutoSize = true;
            this.radbtnCalcanheiraPulseira.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radbtnCalcanheiraPulseira.Location = new System.Drawing.Point(30, 182);
            this.radbtnCalcanheiraPulseira.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radbtnCalcanheiraPulseira.Name = "radbtnCalcanheiraPulseira";
            this.radbtnCalcanheiraPulseira.Size = new System.Drawing.Size(408, 59);
            this.radbtnCalcanheiraPulseira.TabIndex = 6;
            this.radbtnCalcanheiraPulseira.TabStop = true;
            this.radbtnCalcanheiraPulseira.Text = "Calcanheira/Pulseira";
            this.radbtnCalcanheiraPulseira.UseVisualStyleBackColor = true;
            this.radbtnCalcanheiraPulseira.Click += new System.EventHandler(this.radbtnCalcanheiraPulseira_Click);
            // 
            // radbtnCalcanheira
            // 
            this.radbtnCalcanheira.AutoSize = true;
            this.radbtnCalcanheira.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radbtnCalcanheira.Location = new System.Drawing.Point(30, 107);
            this.radbtnCalcanheira.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.radbtnCalcanheira.Name = "radbtnCalcanheira";
            this.radbtnCalcanheira.Size = new System.Drawing.Size(262, 59);
            this.radbtnCalcanheira.TabIndex = 5;
            this.radbtnCalcanheira.TabStop = true;
            this.radbtnCalcanheira.Text = "Calcanheira";
            this.radbtnCalcanheira.UseVisualStyleBackColor = true;
            this.radbtnCalcanheira.Click += new System.EventHandler(this.radbtnCalcanheira_Click);
            // 
            // txtTest
            // 
            this.txtTest.Enabled = false;
            this.txtTest.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTest.Location = new System.Drawing.Point(32, 437);
            this.txtTest.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtTest.Name = "txtTest";
            this.txtTest.Size = new System.Drawing.Size(765, 60);
            this.txtTest.TabIndex = 11;
            // 
            // lblExpectedTest
            // 
            this.lblExpectedTest.AutoSize = true;
            this.lblExpectedTest.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExpectedTest.Location = new System.Drawing.Point(17, 375);
            this.lblExpectedTest.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExpectedTest.Name = "lblExpectedTest";
            this.lblExpectedTest.Size = new System.Drawing.Size(311, 55);
            this.lblExpectedTest.TabIndex = 10;
            this.lblExpectedTest.Text = "Teste necessário";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(32, 258);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(765, 60);
            this.txtName.TabIndex = 9;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(17, 197);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(124, 55);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Nome";
            // 
            // gbInfo
            // 
            this.gbInfo.Controls.Add(this.lblSelect);
            this.gbInfo.Controls.Add(this.radbtnCalcanheira);
            this.gbInfo.Controls.Add(this.radbtnCalcanheiraPulseira);
            this.gbInfo.Location = new System.Drawing.Point(26, 277);
            this.gbInfo.Margin = new System.Windows.Forms.Padding(0);
            this.gbInfo.Name = "gbInfo";
            this.gbInfo.Padding = new System.Windows.Forms.Padding(0);
            this.gbInfo.Size = new System.Drawing.Size(992, 283);
            this.gbInfo.TabIndex = 12;
            this.gbInfo.TabStop = false;
            this.gbInfo.Visible = false;
            // 
            // lblSelect
            // 
            this.lblSelect.AutoSize = true;
            this.lblSelect.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSelect.Location = new System.Drawing.Point(17, 41);
            this.lblSelect.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSelect.Name = "lblSelect";
            this.lblSelect.Size = new System.Drawing.Size(654, 65);
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
            this.gbSelect.Location = new System.Drawing.Point(1035, 18);
            this.gbSelect.Margin = new System.Windows.Forms.Padding(0);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Padding = new System.Windows.Forms.Padding(0);
            this.gbSelect.Size = new System.Drawing.Size(854, 541);
            this.gbSelect.TabIndex = 13;
            this.gbSelect.TabStop = false;
            this.gbSelect.Visible = false;
            // 
            // txtCode
            // 
            this.txtCode.Enabled = false;
            this.txtCode.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(32, 98);
            this.txtCode.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(765, 60);
            this.txtCode.TabIndex = 13;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCode.Location = new System.Drawing.Point(17, 37);
            this.lblCode.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(143, 55);
            this.lblCode.TabIndex = 12;
            this.lblCode.Text = "Código";
            // 
            // Scan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 582);
            this.ControlBox = false;
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.gbInfo);
            this.Controls.Add(this.gbScan);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
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
        private RadioButton radbtnCalcanheiraPulseira;
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