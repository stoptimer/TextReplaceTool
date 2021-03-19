
namespace TextReplaceTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_source = new System.Windows.Forms.TextBox();
            this.tb_dest = new System.Windows.Forms.TextBox();
            this.btn_handle = new System.Windows.Forms.Button();
            this.tb_middle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_source
            // 
            this.tb_source.Location = new System.Drawing.Point(13, 30);
            this.tb_source.Multiline = true;
            this.tb_source.Name = "tb_source";
            this.tb_source.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_source.Size = new System.Drawing.Size(869, 297);
            this.tb_source.TabIndex = 0;
            // 
            // tb_dest
            // 
            this.tb_dest.Location = new System.Drawing.Point(12, 524);
            this.tb_dest.Multiline = true;
            this.tb_dest.Name = "tb_dest";
            this.tb_dest.ReadOnly = true;
            this.tb_dest.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_dest.Size = new System.Drawing.Size(869, 236);
            this.tb_dest.TabIndex = 1;
            // 
            // btn_handle
            // 
            this.btn_handle.Location = new System.Drawing.Point(806, 477);
            this.btn_handle.Name = "btn_handle";
            this.btn_handle.Size = new System.Drawing.Size(75, 23);
            this.btn_handle.TabIndex = 2;
            this.btn_handle.Text = "处理";
            this.btn_handle.UseVisualStyleBackColor = true;
            this.btn_handle.Click += new System.EventHandler(this.btn_handle_Click);
            // 
            // tb_middle
            // 
            this.tb_middle.Location = new System.Drawing.Point(12, 374);
            this.tb_middle.Multiline = true;
            this.tb_middle.Name = "tb_middle";
            this.tb_middle.Size = new System.Drawing.Size(869, 81);
            this.tb_middle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 504);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "结果";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "替换文字";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "需要替换数据";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 785);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_middle);
            this.Controls.Add(this.btn_handle);
            this.Controls.Add(this.tb_dest);
            this.Controls.Add(this.tb_source);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "文本替换工具";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_source;
        private System.Windows.Forms.TextBox tb_dest;
        private System.Windows.Forms.Button btn_handle;
        private System.Windows.Forms.TextBox tb_middle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

