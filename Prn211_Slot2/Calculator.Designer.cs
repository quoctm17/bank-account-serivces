namespace Prn211_Slot2
{
    partial class Calculator
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
            lbNum1 = new Label();
            lbNum2 = new Label();
            txtNum1 = new TextBox();
            txtNum2 = new TextBox();
            btnPlus = new Button();
            btnSub = new Button();
            mul = new Button();
            div = new Button();
            SuspendLayout();
            // 
            // lbNum1
            // 
            lbNum1.AutoSize = true;
            lbNum1.Location = new Point(245, 134);
            lbNum1.Name = "lbNum1";
            lbNum1.Size = new Size(60, 15);
            lbNum1.TabIndex = 0;
            lbNum1.Text = "Number 1";
            // 
            // lbNum2
            // 
            lbNum2.AutoSize = true;
            lbNum2.Location = new Point(245, 169);
            lbNum2.Name = "lbNum2";
            lbNum2.Size = new Size(60, 15);
            lbNum2.TabIndex = 1;
            lbNum2.Text = "Number 2";
            // 
            // txtNum1
            // 
            txtNum1.Location = new Point(311, 131);
            txtNum1.Name = "txtNum1";
            txtNum1.Size = new Size(332, 23);
            txtNum1.TabIndex = 2;
            // 
            // txtNum2
            // 
            txtNum2.Location = new Point(311, 166);
            txtNum2.Name = "txtNum2";
            txtNum2.Size = new Size(332, 23);
            txtNum2.TabIndex = 3;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(311, 208);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(75, 23);
            btnPlus.TabIndex = 4;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new Point(392, 208);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(75, 23);
            btnSub.TabIndex = 5;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // mul
            // 
            mul.Location = new Point(473, 208);
            mul.Name = "mul";
            mul.Size = new Size(75, 23);
            mul.TabIndex = 6;
            mul.Text = "x";
            mul.UseVisualStyleBackColor = true;
            mul.Click += mul_Click;
            // 
            // div
            // 
            div.Location = new Point(554, 208);
            div.Name = "div";
            div.Size = new Size(75, 23);
            div.TabIndex = 7;
            div.Text = "/";
            div.UseVisualStyleBackColor = true;
            div.Click += div_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 560);
            Controls.Add(div);
            Controls.Add(mul);
            Controls.Add(btnSub);
            Controls.Add(btnPlus);
            Controls.Add(txtNum2);
            Controls.Add(txtNum1);
            Controls.Add(lbNum2);
            Controls.Add(lbNum1);
            Name = "Calculator";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNum1;
        private Label lbNum2;
        private TextBox txtNum1;
        private TextBox txtNum2;
        private Button btnPlus;
        private Button btnSub;
        private Button mul;
        private Button div;
    }
}