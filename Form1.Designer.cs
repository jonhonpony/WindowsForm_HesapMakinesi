namespace hesapmakinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.btn_topla = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.resultbox = new System.Windows.Forms.TextBox();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.lbl_islem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(13, 218);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 58);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.button_click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(108, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(204, 218);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 58);
            this.btn_3.TabIndex = 1;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.button_click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 282);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 58);
            this.button4.TabIndex = 1;
            this.button4.Text = "button2";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(108, 218);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 58);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.button_click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(13, 282);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 58);
            this.btn_4.TabIndex = 1;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.button_click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(108, 282);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 58);
            this.btn_5.TabIndex = 1;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.button_click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(204, 282);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 58);
            this.btn_6.TabIndex = 1;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.button_click);
            // 
            // btn_cikar
            // 
            this.btn_cikar.Location = new System.Drawing.Point(298, 334);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(93, 58);
            this.btn_cikar.TabIndex = 1;
            this.btn_cikar.Text = "-";
            this.btn_cikar.UseVisualStyleBackColor = true;
            this.btn_cikar.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_bol
            // 
            this.btn_bol.Location = new System.Drawing.Point(298, 398);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(93, 58);
            this.btn_bol.TabIndex = 1;
            this.btn_bol.Text = "/";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_equal
            // 
            this.btn_equal.Location = new System.Drawing.Point(298, 206);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(93, 58);
            this.btn_equal.TabIndex = 1;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = true;
            this.btn_equal.Click += new System.EventHandler(this.equal_click);
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(298, 270);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(93, 58);
            this.btn_topla.TabIndex = 1;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.operator_click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(13, 346);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 58);
            this.button13.TabIndex = 1;
            this.button13.Text = "button2";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(13, 346);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 58);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.button_click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(108, 346);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 58);
            this.btn_8.TabIndex = 1;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.button_click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(204, 346);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 58);
            this.btn_9.TabIndex = 1;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.button_click);
            // 
            // resultbox
            // 
            this.resultbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.resultbox.Location = new System.Drawing.Point(12, 87);
            this.resultbox.Multiline = true;
            this.resultbox.Name = "resultbox";
            this.resultbox.ReadOnly = true;
            this.resultbox.Size = new System.Drawing.Size(374, 74);
            this.resultbox.TabIndex = 2;
            this.resultbox.Text = "0";
            this.resultbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(298, 462);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(93, 58);
            this.btn_carp.TabIndex = 1;
            this.btn_carp.Text = "*";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.operator_click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(196, 411);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(83, 57);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_0.Location = new System.Drawing.Point(108, 410);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(75, 58);
            this.btn_0.TabIndex = 1;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.button_click);
            // 
            // btn_dot
            // 
            this.btn_dot.Location = new System.Drawing.Point(13, 411);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(75, 57);
            this.btn_dot.TabIndex = 3;
            this.btn_dot.Text = ".";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.button_click);
            // 
            // lbl_islem
            // 
            this.lbl_islem.AutoSize = true;
            this.lbl_islem.Location = new System.Drawing.Point(12, 68);
            this.lbl_islem.Name = "lbl_islem";
            this.lbl_islem.Size = new System.Drawing.Size(0, 16);
            this.lbl_islem.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 527);
            this.Controls.Add(this.lbl_islem);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.resultbox);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.btn_cikar);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.Button btn_topla;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.TextBox resultbox;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Label lbl_islem;
    }
}

