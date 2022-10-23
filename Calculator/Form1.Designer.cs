namespace Calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btcong = new System.Windows.Forms.Button();
            this.bttru = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(52, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "so A";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(52, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "ket qua";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(52, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "so b";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(128, 45);
            this.txtA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(163, 20);
            this.txtA.TabIndex = 3;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(128, 146);
            this.txtketqua.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(163, 20);
            this.txtketqua.TabIndex = 4;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(128, 101);
            this.txtB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(163, 20);
            this.txtB.TabIndex = 5;
            // 
            // btcong
            // 
            this.btcong.Location = new System.Drawing.Point(194, 215);
            this.btcong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btcong.Name = "btcong";
            this.btcong.Size = new System.Drawing.Size(82, 36);
            this.btcong.TabIndex = 6;
            this.btcong.Text = "cong";
            this.btcong.UseVisualStyleBackColor = true;
            this.btcong.Click += new System.EventHandler(this.btcong_Click);
            // 
            // bttru
            // 
            this.bttru.Location = new System.Drawing.Point(78, 215);
            this.bttru.Margin = new System.Windows.Forms.Padding(2);
            this.bttru.Name = "bttru";
            this.bttru.Size = new System.Drawing.Size(82, 36);
            this.bttru.TabIndex = 7;
            this.bttru.Text = "tru";
            this.bttru.UseVisualStyleBackColor = true;
            this.bttru.Click += new System.EventHandler(this.bttru_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 323);
            this.Controls.Add(this.bttru);
            this.Controls.Add(this.btcong);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtketqua;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btcong;
        private System.Windows.Forms.Button bttru;
    }
}

