
namespace LTGD_Chuong2
{
    partial class Form4
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
            this.lbso1 = new System.Windows.Forms.Label();
            this.lbso2 = new System.Windows.Forms.Label();
            this.lbso3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTai = new System.Windows.Forms.RadioButton();
            this.rdXiu = new System.Windows.Forms.RadioButton();
            this.btQuayso = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbKetqua = new System.Windows.Forms.Label();
            this.lbDiem = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình quay số ngẫu nhiên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbso1
            // 
            this.lbso1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbso1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbso1.Location = new System.Drawing.Point(110, 59);
            this.lbso1.Name = "lbso1";
            this.lbso1.Size = new System.Drawing.Size(100, 139);
            this.lbso1.TabIndex = 1;
            this.lbso1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbso2
            // 
            this.lbso2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbso2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbso2.Location = new System.Drawing.Point(359, 59);
            this.lbso2.Name = "lbso2";
            this.lbso2.Size = new System.Drawing.Size(100, 139);
            this.lbso2.TabIndex = 1;
            this.lbso2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbso3
            // 
            this.lbso3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbso3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbso3.Location = new System.Drawing.Point(608, 59);
            this.lbso3.Name = "lbso3";
            this.lbso3.Size = new System.Drawing.Size(100, 139);
            this.lbso3.TabIndex = 1;
            this.lbso3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTai);
            this.groupBox1.Controls.Add(this.rdXiu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(183, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(443, 109);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn";
            // 
            // rdTai
            // 
            this.rdTai.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdTai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rdTai.Location = new System.Drawing.Point(291, 55);
            this.rdTai.Name = "rdTai";
            this.rdTai.Size = new System.Drawing.Size(95, 40);
            this.rdTai.TabIndex = 0;
            this.rdTai.TabStop = true;
            this.rdTai.Text = "(11-18)";
            this.rdTai.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdTai.UseVisualStyleBackColor = false;
            // 
            // rdXiu
            // 
            this.rdXiu.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdXiu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.rdXiu.Location = new System.Drawing.Point(53, 55);
            this.rdXiu.Name = "rdXiu";
            this.rdXiu.Size = new System.Drawing.Size(95, 40);
            this.rdXiu.TabIndex = 0;
            this.rdXiu.TabStop = true;
            this.rdXiu.Text = "(3-10)";
            this.rdXiu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdXiu.UseVisualStyleBackColor = false;
            // 
            // btQuayso
            // 
            this.btQuayso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btQuayso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuayso.ForeColor = System.Drawing.Color.Purple;
            this.btQuayso.Location = new System.Drawing.Point(645, 283);
            this.btQuayso.Name = "btQuayso";
            this.btQuayso.Size = new System.Drawing.Size(111, 42);
            this.btQuayso.TabIndex = 3;
            this.btQuayso.Text = "Quay số";
            this.btQuayso.UseVisualStyleBackColor = false;
            this.btQuayso.Click += new System.EventHandler(this.btQuayso_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 35);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kết quả :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 34);
            this.label5.TabIndex = 4;
            this.label5.Text = "Điểm :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbKetqua
            // 
            this.lbKetqua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbKetqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKetqua.Location = new System.Drawing.Point(163, 370);
            this.lbKetqua.Name = "lbKetqua";
            this.lbKetqua.Size = new System.Drawing.Size(324, 34);
            this.lbKetqua.TabIndex = 5;
            this.lbKetqua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbDiem
            // 
            this.lbDiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDiem.Location = new System.Drawing.Point(598, 369);
            this.lbDiem.Name = "lbDiem";
            this.lbDiem.Size = new System.Drawing.Size(190, 34);
            this.lbDiem.TabIndex = 5;
            this.lbDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbDiem);
            this.Controls.Add(this.lbKetqua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btQuayso);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbso3);
            this.Controls.Add(this.lbso2);
            this.Controls.Add(this.lbso1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Random Number";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbso1;
        private System.Windows.Forms.Label lbso2;
        private System.Windows.Forms.Label lbso3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdXiu;
        private System.Windows.Forms.RadioButton rdTai;
        private System.Windows.Forms.Button btQuayso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbKetqua;
        private System.Windows.Forms.Label lbDiem;
    }
}