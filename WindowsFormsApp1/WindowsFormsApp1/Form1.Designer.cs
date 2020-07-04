namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textboxop1 = new System.Windows.Forms.TextBox();
            this.textboxop2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labelresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textboxop1
            // 
            this.textboxop1.Location = new System.Drawing.Point(69, 23);
            this.textboxop1.Name = "textboxop1";
            this.textboxop1.Size = new System.Drawing.Size(100, 21);
            this.textboxop1.TabIndex = 0;
            // 
            // textboxop2
            // 
            this.textboxop2.Location = new System.Drawing.Point(69, 127);
            this.textboxop2.Name = "textboxop2";
            this.textboxop2.Size = new System.Drawing.Size(100, 21);
            this.textboxop2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(29, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 39);
            this.button1.TabIndex = 2;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelresult.Location = new System.Drawing.Point(29, 177);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(164, 48);
            this.labelresult.TabIndex = 3;
            this.labelresult.Text = "result";
            this.labelresult.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 238);
            this.Controls.Add(this.labelresult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textboxop2);
            this.Controls.Add(this.textboxop1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxop1;
        private System.Windows.Forms.TextBox textboxop2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelresult;
    }
}

