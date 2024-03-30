namespace FisicaApp_2._0_Top
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
            rbVm = new RadioButton();
            rbAcel = new RadioButton();
            rbTo = new RadioButton();
            rbMu = new RadioButton();
            flOpt = new FlowLayoutPanel();
            lbVel = new Label();
            lbEsp = new Label();
            lbTemp = new Label();
            btCalc = new Button();
            nmVel = new NumericUpDown();
            nmEsp = new NumericUpDown();
            nmTemp = new NumericUpDown();
            pnCalc = new Panel();
            flCalc = new FlowLayoutPanel();
            lbRes = new Label();
            res = new Label();
            flOpt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmVel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmEsp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmTemp).BeginInit();
            pnCalc.SuspendLayout();
            flCalc.SuspendLayout();
            SuspendLayout();
            // 
            // rbVm
            // 
            rbVm.AutoSize = true;
            rbVm.Font = new Font("Arial", 12F);
            rbVm.Location = new Point(115, 3);
            rbVm.Name = "rbVm";
            rbVm.Size = new Size(153, 22);
            rbVm.TabIndex = 0;
            rbVm.TabStop = true;
            rbVm.Text = "Velocidade Média";
            rbVm.UseVisualStyleBackColor = true;
            rbVm.CheckedChanged += rbVm_CheckedChanged;
            // 
            // rbAcel
            // 
            rbAcel.AutoSize = true;
            rbAcel.Font = new Font("Arial", 12F);
            rbAcel.Location = new Point(3, 3);
            rbAcel.Name = "rbAcel";
            rbAcel.Size = new Size(106, 22);
            rbAcel.TabIndex = 1;
            rbAcel.TabStop = true;
            rbAcel.Text = "Aceleração";
            rbAcel.UseVisualStyleBackColor = true;
            rbAcel.CheckedChanged += rbAcel_CheckedChanged;
            // 
            // rbTo
            // 
            rbTo.AutoSize = true;
            rbTo.Font = new Font("Arial", 12F);
            rbTo.Location = new Point(274, 3);
            rbTo.Name = "rbTo";
            rbTo.Size = new Size(83, 22);
            rbTo.TabIndex = 2;
            rbTo.TabStop = true;
            rbTo.Text = "Torricelli";
            rbTo.UseVisualStyleBackColor = true;
            rbTo.CheckedChanged += rbTo_CheckedChanged;
            // 
            // rbMu
            // 
            rbMu.AutoSize = true;
            rbMu.Font = new Font("Arial", 12F);
            rbMu.Location = new Point(363, 3);
            rbMu.Name = "rbMu";
            rbMu.Size = new Size(125, 22);
            rbMu.TabIndex = 3;
            rbMu.TabStop = true;
            rbMu.Text = "Mov. Uniforme";
            rbMu.UseVisualStyleBackColor = true;
            rbMu.CheckedChanged += tbMuv_CheckedChanged;
            // 
            // flOpt
            // 
            flOpt.BorderStyle = BorderStyle.FixedSingle;
            flOpt.Controls.Add(rbAcel);
            flOpt.Controls.Add(rbVm);
            flOpt.Controls.Add(rbTo);
            flOpt.Controls.Add(rbMu);
            flOpt.Font = new Font("Arial", 12F);
            flOpt.Location = new Point(12, 12);
            flOpt.Name = "flOpt";
            flOpt.Size = new Size(502, 30);
            flOpt.TabIndex = 4;
            // 
            // lbVel
            // 
            lbVel.AutoSize = true;
            lbVel.Font = new Font("Arial", 11.25F);
            lbVel.Location = new Point(13, 46);
            lbVel.Name = "lbVel";
            lbVel.Padding = new Padding(0, 5, 0, 0);
            lbVel.Size = new Size(78, 22);
            lbVel.TabIndex = 6;
            lbVel.Text = "Velocidade";
            // 
            // lbEsp
            // 
            lbEsp.AutoSize = true;
            lbEsp.Font = new Font("Arial", 11.25F);
            lbEsp.Location = new Point(13, 14);
            lbEsp.Name = "lbEsp";
            lbEsp.Padding = new Padding(0, 5, 0, 0);
            lbEsp.Size = new Size(74, 22);
            lbEsp.TabIndex = 7;
            lbEsp.Text = "V. Espaço";
            // 
            // lbTemp
            // 
            lbTemp.AutoSize = true;
            lbTemp.Font = new Font("Arial", 11.25F);
            lbTemp.Location = new Point(13, 77);
            lbTemp.Name = "lbTemp";
            lbTemp.Padding = new Padding(0, 5, 0, 0);
            lbTemp.Size = new Size(52, 22);
            lbTemp.TabIndex = 8;
            lbTemp.Text = "Tempo";
            // 
            // btCalc
            // 
            btCalc.Enabled = false;
            btCalc.Location = new Point(42, 111);
            btCalc.Name = "btCalc";
            btCalc.Size = new Size(89, 26);
            btCalc.TabIndex = 10;
            btCalc.Text = "Calcular";
            btCalc.UseVisualStyleBackColor = true;
            btCalc.Click += btCalc_Click;
            // 
            // nmVel
            // 
            nmVel.Location = new Point(93, 46);
            nmVel.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmVel.Name = "nmVel";
            nmVel.Size = new Size(66, 23);
            nmVel.TabIndex = 11;
            // 
            // nmEsp
            // 
            nmEsp.Location = new Point(93, 17);
            nmEsp.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmEsp.Name = "nmEsp";
            nmEsp.Size = new Size(66, 23);
            nmEsp.TabIndex = 12;
            // 
            // nmTemp
            // 
            nmTemp.Location = new Point(93, 77);
            nmTemp.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nmTemp.Name = "nmTemp";
            nmTemp.Size = new Size(66, 23);
            nmTemp.TabIndex = 13;
            nmTemp.ValueChanged += nmTemp_ValueChanged;
            // 
            // pnCalc
            // 
            pnCalc.Controls.Add(lbEsp);
            pnCalc.Controls.Add(nmVel);
            pnCalc.Controls.Add(btCalc);
            pnCalc.Controls.Add(nmEsp);
            pnCalc.Controls.Add(nmTemp);
            pnCalc.Controls.Add(lbVel);
            pnCalc.Controls.Add(lbTemp);
            pnCalc.Location = new Point(174, 61);
            pnCalc.Name = "pnCalc";
            pnCalc.Padding = new Padding(10);
            pnCalc.Size = new Size(179, 150);
            pnCalc.TabIndex = 14;
            // 
            // flCalc
            // 
            flCalc.Controls.Add(lbRes);
            flCalc.Controls.Add(res);
            flCalc.Location = new Point(174, 217);
            flCalc.Name = "flCalc";
            flCalc.Size = new Size(179, 19);
            flCalc.TabIndex = 15;
            // 
            // lbRes
            // 
            lbRes.AutoSize = true;
            lbRes.Font = new Font("Arial", 11F);
            lbRes.Location = new Point(3, 0);
            lbRes.Name = "lbRes";
            lbRes.Size = new Size(78, 17);
            lbRes.TabIndex = 1;
            lbRes.Text = "Resultado:";
            // 
            // res
            // 
            res.AutoSize = true;
            res.Font = new Font("Arial", 11F);
            res.Location = new Point(87, 0);
            res.Name = "res";
            res.Size = new Size(0, 17);
            res.TabIndex = 0;
            // 
            // Form1
            // 
            AcceptButton = btCalc;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 273);
            Controls.Add(flCalc);
            Controls.Add(pnCalc);
            Controls.Add(flOpt);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            Text = "FisicaApp 2.0 - Top";
            Load += Form1_Load;
            flOpt.ResumeLayout(false);
            flOpt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmVel).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmEsp).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmTemp).EndInit();
            pnCalc.ResumeLayout(false);
            pnCalc.PerformLayout();
            flCalc.ResumeLayout(false);
            flCalc.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rbVm;
        private RadioButton rbAcel;
        private RadioButton rbTo;
        private RadioButton rbMu;
        private FlowLayoutPanel flOpt;
        private Label lbEsp;
        private NumericUpDown nmVel;
        private Label lbVel;
        private Label lbTemp;
        private Button btCalc;
        private NumericUpDown nmEsp;
        private NumericUpDown nmTemp;
        private Panel pnCalc;
        private FlowLayoutPanel flCalc;
        private Label lbRes;
        private Label res;
    }
}
