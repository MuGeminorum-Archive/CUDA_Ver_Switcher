namespace CUDA_Ver_Switcher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.switch_btn = new System.Windows.Forms.Button();
            this.ver_option_combox = new System.Windows.Forms.ComboBox();
            this.curr_ver_label = new System.Windows.Forms.Label();
            this.curr_verval_label = new System.Windows.Forms.Label();
            this.cmd_textbox = new System.Windows.Forms.TextBox();
            this.ver_option_label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // switch_btn
            // 
            this.switch_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.switch_btn.Enabled = false;
            this.switch_btn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.switch_btn.Location = new System.Drawing.Point(4, 196);
            this.switch_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.switch_btn.Name = "switch_btn";
            this.switch_btn.Size = new System.Drawing.Size(181, 89);
            this.switch_btn.TabIndex = 0;
            this.switch_btn.Text = "Switch";
            this.switch_btn.UseVisualStyleBackColor = true;
            this.switch_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ver_option_combox
            // 
            this.ver_option_combox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ver_option_combox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ver_option_combox.FormattingEnabled = true;
            this.ver_option_combox.Location = new System.Drawing.Point(193, 130);
            this.ver_option_combox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ver_option_combox.Name = "ver_option_combox";
            this.ver_option_combox.Size = new System.Drawing.Size(182, 28);
            this.ver_option_combox.TabIndex = 1;
            this.ver_option_combox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // curr_ver_label
            // 
            this.curr_ver_label.AutoSize = true;
            this.curr_ver_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curr_ver_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.curr_ver_label.Location = new System.Drawing.Point(4, 0);
            this.curr_ver_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curr_ver_label.Name = "curr_ver_label";
            this.curr_ver_label.Size = new System.Drawing.Size(181, 96);
            this.curr_ver_label.TabIndex = 2;
            this.curr_ver_label.Text = "Current Version";
            this.curr_ver_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curr_verval_label
            // 
            this.curr_verval_label.AutoSize = true;
            this.curr_verval_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.curr_verval_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.curr_verval_label.Location = new System.Drawing.Point(193, 0);
            this.curr_verval_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.curr_verval_label.Name = "curr_verval_label";
            this.curr_verval_label.Size = new System.Drawing.Size(182, 96);
            this.curr_verval_label.TabIndex = 2;
            this.curr_verval_label.Text = "--";
            this.curr_verval_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_textbox
            // 
            this.cmd_textbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmd_textbox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmd_textbox.Location = new System.Drawing.Point(193, 196);
            this.cmd_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmd_textbox.Multiline = true;
            this.cmd_textbox.Name = "cmd_textbox";
            this.cmd_textbox.ReadOnly = true;
            this.cmd_textbox.Size = new System.Drawing.Size(182, 89);
            this.cmd_textbox.TabIndex = 3;
            // 
            // ver_option_label
            // 
            this.ver_option_label.AutoSize = true;
            this.ver_option_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ver_option_label.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ver_option_label.Location = new System.Drawing.Point(4, 96);
            this.ver_option_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ver_option_label.Name = "ver_option_label";
            this.ver_option_label.Size = new System.Drawing.Size(181, 96);
            this.ver_option_label.TabIndex = 2;
            this.ver_option_label.Text = "PATH Option";
            this.ver_option_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.curr_ver_label, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmd_textbox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.curr_verval_label, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.switch_btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.ver_option_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ver_option_combox, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 289);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 289);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CUDA Version Switcher";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button switch_btn;
        private System.Windows.Forms.ComboBox ver_option_combox;
        private System.Windows.Forms.Label curr_ver_label;
        private System.Windows.Forms.Label curr_verval_label;
        private System.Windows.Forms.TextBox cmd_textbox;
        private System.Windows.Forms.Label ver_option_label;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

