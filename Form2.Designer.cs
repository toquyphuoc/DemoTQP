
namespace LTGD_Chuong2
{
    partial class Form2
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
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdcong = new System.Windows.Forms.RadioButton();
            this.rdtru = new System.Windows.Forms.RadioButton();
            this.rdnhan = new System.Windows.Forms.RadioButton();
            this.rdchia = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbketqua = new System.Windows.Forms.Label();
            this.bttinh = new System.Windows.Forms.Button();
            this.rdchiadu = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các phép tính";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(435, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số thứ 2";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(165, 66);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(120, 29);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(545, 66);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(120, 29);
            this.txt2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdchiadu);
            this.groupBox1.Controls.Add(this.rdchia);
            this.groupBox1.Controls.Add(this.rdnhan);
            this.groupBox1.Controls.Add(this.rdtru);
            this.groupBox1.Controls.Add(this.rdcong);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(115, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 172);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // rdcong
            // 
            this.rdcong.AutoSize = true;
            this.rdcong.Location = new System.Drawing.Point(18, 75);
            this.rdcong.Name = "rdcong";
            this.rdcong.Size = new System.Drawing.Size(39, 28);
            this.rdcong.TabIndex = 0;
            this.rdcong.TabStop = true;
            this.rdcong.Text = "+";
            this.rdcong.UseVisualStyleBackColor = true;
            // 
            // rdtru
            // 
            this.rdtru.AutoSize = true;
            this.rdtru.Location = new System.Drawing.Point(157, 75);
            this.rdtru.Name = "rdtru";
            this.rdtru.Size = new System.Drawing.Size(34, 28);
            this.rdtru.TabIndex = 0;
            this.rdtru.TabStop = true;
            this.rdtru.Text = "-";
            this.rdtru.UseVisualStyleBackColor = true;
            // 
            // rdnhan
            // 
            this.rdnhan.AutoSize = true;
            this.rdnhan.Location = new System.Drawing.Point(296, 75);
            this.rdnhan.Name = "rdnhan";
            this.rdnhan.Size = new System.Drawing.Size(38, 28);
            this.rdnhan.TabIndex = 0;
            this.rdnhan.TabStop = true;
            this.rdnhan.Text = "x";
            this.rdnhan.UseVisualStyleBackColor = true;
            // 
            // rdchia
            // 
            this.rdchia.AutoSize = true;
            this.rdchia.Location = new System.Drawing.Point(435, 75);
            this.rdchia.Name = "rdchia";
            this.rdchia.Size = new System.Drawing.Size(33, 28);
            this.rdchia.TabIndex = 0;
            this.rdchia.TabStop = true;
            this.rdchia.Text = "/";
            this.rdchia.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kết quả";
            // 
            // lbketqua
            // 
            this.lbketqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbketqua.Location = new System.Drawing.Point(159, 353);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(477, 31);
            this.lbketqua.TabIndex = 1;
            // 
            // bttinh
            // 
            this.bttinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttinh.Location = new System.Drawing.Point(659, 341);
            this.bttinh.Name = "bttinh";
            this.bttinh.Size = new System.Drawing.Size(113, 45);
            this.bttinh.TabIndex = 4;
            this.bttinh.Text = "Tính";
            this.bttinh.UseVisualStyleBackColor = true;
            this.bttinh.Click += new System.EventHandler(this.bttinh_Click);
            // 
            // rdchiadu
            // 
            this.rdchiadu.AutoSize = true;
            this.rdchiadu.Location = new System.Drawing.Point(550, 75);
            this.rdchiadu.Name = "rdchiadu";
            this.rdchiadu.Size = new System.Drawing.Size(43, 28);
            this.rdchiadu.TabIndex = 0;
            this.rdchiadu.TabStop = true;
            this.rdchiadu.Text = "%";
            this.rdchiadu.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttinh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Các phép tính đơn giản ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdchia;
        private System.Windows.Forms.RadioButton rdnhan;
        private System.Windows.Forms.RadioButton rdtru;
        private System.Windows.Forms.RadioButton rdcong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbketqua;
        private System.Windows.Forms.Button bttinh;
        private System.Windows.Forms.RadioButton rdchiadu;
    }
}