namespace BasicCalculator
{
    partial class frmCalculator
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
            txtBox = new TextBox();
            btnClear = new Button();
            btnBack = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnDivide = new Button();
            btnNine = new Button();
            btnSquare = new Button();
            btnReciprocal = new Button();
            btnMultiply = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnMinus = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnEquals = new Button();
            btnPlus = new Button();
            btnDecimal = new Button();
            btnNegate = new Button();
            btnZero = new Button();
            lblM = new Label();
            btnMC = new Button();
            btnMR = new Button();
            btnMS = new Button();
            btnMplus = new Button();
            SuspendLayout();
            // 
            // txtBox
            // 
            txtBox.BackColor = SystemColors.Control;
            txtBox.BorderStyle = BorderStyle.FixedSingle;
            txtBox.ForeColor = SystemColors.Desktop;
            txtBox.Location = new Point(22, 21);
            txtBox.Name = "txtBox";
            txtBox.RightToLeft = RightToLeft.No;
            txtBox.Size = new Size(331, 27);
            txtBox.TabIndex = 0;
            txtBox.TextChanged += txtBox_TextChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.FromArgb(255, 50, 0);
            btnClear.Location = new Point(203, 60);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(144, 35);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = SystemColors.ControlLight;
            btnBack.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.FromArgb(255, 50, 0);
            btnBack.Location = new Point(97, 60);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(85, 35);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = SystemColors.ControlLight;
            btnSeven.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSeven.ForeColor = Color.DodgerBlue;
            btnSeven.Location = new Point(97, 107);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(35, 35);
            btnSeven.TabIndex = 3;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = SystemColors.ControlLight;
            btnEight.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEight.ForeColor = Color.DodgerBlue;
            btnEight.Location = new Point(147, 107);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(35, 35);
            btnEight.TabIndex = 4;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnEight_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = SystemColors.ControlLight;
            btnDivide.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnDivide.FlatStyle = FlatStyle.Flat;
            btnDivide.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDivide.ForeColor = Color.FromArgb(255, 50, 0);
            btnDivide.Location = new Point(257, 107);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(35, 35);
            btnDivide.TabIndex = 6;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += btnDivide_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = SystemColors.ControlLight;
            btnNine.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnNine.ForeColor = Color.DodgerBlue;
            btnNine.Location = new Point(203, 107);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(35, 35);
            btnNine.TabIndex = 5;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNine_Click;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = SystemColors.ControlLight;
            btnSquare.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnSquare.FlatStyle = FlatStyle.Flat;
            btnSquare.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold);
            btnSquare.ForeColor = Color.DodgerBlue;
            btnSquare.Location = new Point(307, 107);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(35, 35);
            btnSquare.TabIndex = 7;
            btnSquare.Text = "sqr";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += btnSquare_Click;
            // 
            // btnReciprocal
            // 
            btnReciprocal.BackColor = SystemColors.ControlLight;
            btnReciprocal.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnReciprocal.FlatStyle = FlatStyle.Flat;
            btnReciprocal.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold);
            btnReciprocal.ForeColor = Color.DodgerBlue;
            btnReciprocal.Location = new Point(307, 156);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(35, 35);
            btnReciprocal.TabIndex = 12;
            btnReciprocal.Text = "1/X";
            btnReciprocal.UseVisualStyleBackColor = false;
            btnReciprocal.Click += btnReciprocal_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = SystemColors.ControlLight;
            btnMultiply.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnMultiply.FlatStyle = FlatStyle.Flat;
            btnMultiply.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMultiply.ForeColor = Color.FromArgb(255, 50, 0);
            btnMultiply.Location = new Point(257, 156);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(35, 35);
            btnMultiply.TabIndex = 11;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = SystemColors.ControlLight;
            btnSix.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnSix.ForeColor = Color.DodgerBlue;
            btnSix.Location = new Point(203, 156);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(35, 35);
            btnSix.TabIndex = 10;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = SystemColors.ControlLight;
            btnFive.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFive.ForeColor = Color.DodgerBlue;
            btnFive.Location = new Point(147, 156);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(35, 35);
            btnFive.TabIndex = 9;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = SystemColors.ControlLight;
            btnFour.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnFour.ForeColor = Color.DodgerBlue;
            btnFour.Location = new Point(97, 156);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(35, 35);
            btnFour.TabIndex = 8;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnFour_Click;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = SystemColors.ControlLight;
            btnMinus.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnMinus.FlatStyle = FlatStyle.Flat;
            btnMinus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMinus.ForeColor = Color.FromArgb(255, 50, 0);
            btnMinus.Location = new Point(257, 207);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(35, 35);
            btnMinus.TabIndex = 16;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = SystemColors.ControlLight;
            btnThree.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnThree.ForeColor = Color.DodgerBlue;
            btnThree.Location = new Point(203, 207);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(35, 35);
            btnThree.TabIndex = 15;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = SystemColors.ControlLight;
            btnTwo.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnTwo.ForeColor = Color.DodgerBlue;
            btnTwo.Location = new Point(147, 207);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(35, 35);
            btnTwo.TabIndex = 14;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = SystemColors.ControlLight;
            btnOne.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnOne.ForeColor = Color.DodgerBlue;
            btnOne.Location = new Point(97, 207);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(35, 35);
            btnOne.TabIndex = 13;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOne_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.ControlLight;
            btnEquals.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnEquals.FlatStyle = FlatStyle.Flat;
            btnEquals.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnEquals.ForeColor = Color.FromArgb(255, 50, 0);
            btnEquals.Location = new Point(307, 197);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(35, 96);
            btnEquals.TabIndex = 22;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = SystemColors.ControlLight;
            btnPlus.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnPlus.FlatStyle = FlatStyle.Flat;
            btnPlus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnPlus.ForeColor = Color.FromArgb(255, 50, 0);
            btnPlus.Location = new Point(257, 258);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(35, 35);
            btnPlus.TabIndex = 21;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = SystemColors.ControlLight;
            btnDecimal.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnDecimal.FlatStyle = FlatStyle.Flat;
            btnDecimal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnDecimal.ForeColor = Color.DodgerBlue;
            btnDecimal.Location = new Point(203, 258);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(35, 35);
            btnDecimal.TabIndex = 20;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // btnNegate
            // 
            btnNegate.BackColor = SystemColors.ControlLight;
            btnNegate.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnNegate.FlatStyle = FlatStyle.Flat;
            btnNegate.Font = new Font("Segoe UI Semibold", 7F, FontStyle.Bold);
            btnNegate.ForeColor = Color.DodgerBlue;
            btnNegate.Location = new Point(147, 258);
            btnNegate.Name = "btnNegate";
            btnNegate.Size = new Size(35, 35);
            btnNegate.TabIndex = 19;
            btnNegate.Text = "+/-";
            btnNegate.UseVisualStyleBackColor = false;
            btnNegate.Click += btnNegate_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.ControlLight;
            btnZero.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnZero.ForeColor = Color.DodgerBlue;
            btnZero.Location = new Point(97, 258);
            btnZero.Margin = new Padding(6);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(35, 35);
            btnZero.TabIndex = 18;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // lblM
            // 
            lblM.BorderStyle = BorderStyle.Fixed3D;
            lblM.Location = new Point(22, 60);
            lblM.Name = "lblM";
            lblM.Size = new Size(62, 35);
            lblM.TabIndex = 23;
            lblM.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMC
            // 
            btnMC.BackColor = SystemColors.ControlLight;
            btnMC.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnMC.FlatStyle = FlatStyle.Flat;
            btnMC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMC.ForeColor = Color.FromArgb(255, 50, 0);
            btnMC.Location = new Point(22, 107);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(62, 35);
            btnMC.TabIndex = 24;
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = false;
            btnMC.Click += btnMC_Click;
            // 
            // btnMR
            // 
            btnMR.BackColor = SystemColors.ControlLight;
            btnMR.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnMR.FlatStyle = FlatStyle.Flat;
            btnMR.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMR.ForeColor = Color.FromArgb(255, 50, 0);
            btnMR.Location = new Point(22, 155);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(62, 35);
            btnMR.TabIndex = 25;
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = false;
            btnMR.Click += btnMR_Click;
            // 
            // btnMS
            // 
            btnMS.BackColor = SystemColors.ControlLight;
            btnMS.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnMS.FlatStyle = FlatStyle.Flat;
            btnMS.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMS.ForeColor = Color.FromArgb(255, 50, 0);
            btnMS.Location = new Point(22, 207);
            btnMS.Name = "btnMS";
            btnMS.Size = new Size(62, 35);
            btnMS.TabIndex = 26;
            btnMS.Text = "MS";
            btnMS.UseVisualStyleBackColor = false;
            btnMS.Click += btnMS_Click;
            // 
            // btnMplus
            // 
            btnMplus.BackColor = SystemColors.ControlLight;
            btnMplus.FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            btnMplus.FlatStyle = FlatStyle.Flat;
            btnMplus.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnMplus.ForeColor = Color.FromArgb(255, 50, 0);
            btnMplus.Location = new Point(22, 258);
            btnMplus.Name = "btnMplus";
            btnMplus.Size = new Size(62, 35);
            btnMplus.TabIndex = 27;
            btnMplus.Text = "M+";
            btnMplus.UseVisualStyleBackColor = false;
            btnMplus.Click += btnMplus_Click;
            // 
            // frmCalculator
            // 
            AcceptButton = btnEquals;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            CancelButton = btnClear;
            ClientSize = new Size(370, 328);
            Controls.Add(btnMplus);
            Controls.Add(btnMS);
            Controls.Add(btnMR);
            Controls.Add(btnMC);
            Controls.Add(lblM);
            Controls.Add(btnEquals);
            Controls.Add(btnPlus);
            Controls.Add(btnDecimal);
            Controls.Add(btnNegate);
            Controls.Add(btnZero);
            Controls.Add(btnMinus);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(btnReciprocal);
            Controls.Add(btnMultiply);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnSquare);
            Controls.Add(btnDivide);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnBack);
            Controls.Add(btnClear);
            Controls.Add(txtBox);
            ForeColor = Color.Black;
            Name = "frmCalculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox;
        private Button btnClear;
        private Button btnBack;
        private Button btnSeven;
        private Button btnEight;
        private Button btnDivide;
        private Button btnNine;
        private Button btnSquare;
        private Button btnReciprocal;
        private Button btnMultiply;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnMinus;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnEquals;
        private Button btnPlus;
        private Button btnDecimal;
        private Button btnNegate;
        private Button btnZero;
        private Label lblM;
        private Button btnMC;
        private Button btnMR;
        private Button btnMS;
        private Button btnMplus;
    }
}
