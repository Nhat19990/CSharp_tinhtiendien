namespace CSharp_tinhtiendien
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
            label1 = new Label();
            label2 = new Label();
            txtKwh = new TextBox();
            btnthanhtien = new Button();
            label3 = new Label();
            labelResult = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(335, 56);
            label1.Name = "label1";
            label1.Size = new Size(150, 28);
            label1.TabIndex = 0;
            label1.Text = "TÍNH TIỀN ĐIỆN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(58, 127);
            label2.Name = "label2";
            label2.Size = new Size(114, 13);
            label2.TabIndex = 1;
            label2.Text = "Nhập số KWH tiêu thụ";
            // 
            // txtKwh
            // 
            txtKwh.Location = new Point(218, 121);
            txtKwh.Name = "txtKwh";
            txtKwh.Size = new Size(215, 23);
            txtKwh.TabIndex = 2;
            // 
            // btnthanhtien
            // 
            btnthanhtien.Location = new Point(280, 176);
            btnthanhtien.Name = "btnthanhtien";
            btnthanhtien.Size = new Size(75, 23);
            btnthanhtien.TabIndex = 3;
            btnthanhtien.Text = "Thành Tiền";
            btnthanhtien.UseVisualStyleBackColor = true;
            btnthanhtien.Click += btnthanhtien_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 224);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 4;
            label3.Text = "Kết quả";
            // 
            // labelResult
            // 
            labelResult.Location = new Point(131, 221);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(193, 23);
            labelResult.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResult);
            Controls.Add(label3);
            Controls.Add(btnthanhtien);
            Controls.Add(txtKwh);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtKwh;
        private Button btnthanhtien;
        private Label label3;
        private TextBox labelResult;
    }
}
