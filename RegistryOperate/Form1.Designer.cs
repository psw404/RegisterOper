namespace RegistryOperate
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbxRegName = new System.Windows.Forms.TextBox();
            this.tbxRegDesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxRegPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tbxDllPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入注册项的名称";
            // 
            // tbxRegName
            // 
            this.tbxRegName.Location = new System.Drawing.Point(167, 27);
            this.tbxRegName.Name = "tbxRegName";
            this.tbxRegName.Size = new System.Drawing.Size(135, 21);
            this.tbxRegName.TabIndex = 1;
            // 
            // tbxRegDesc
            // 
            this.tbxRegDesc.Location = new System.Drawing.Point(167, 70);
            this.tbxRegDesc.Multiline = true;
            this.tbxRegDesc.Name = "tbxRegDesc";
            this.tbxRegDesc.Size = new System.Drawing.Size(135, 21);
            this.tbxRegDesc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入注册项的描述";
            // 
            // tbxRegPath
            // 
            this.tbxRegPath.Location = new System.Drawing.Point(241, 119);
            this.tbxRegPath.Name = "tbxRegPath";
            this.tbxRegPath.Size = new System.Drawing.Size(421, 21);
            this.tbxRegPath.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "请输入增加或删除的注册项的路径";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(713, 155);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "注册";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(713, 217);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 23);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "删除注册";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(31, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(631, 340);
            this.listBox1.TabIndex = 9;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(713, 472);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 10;
            this.btnCopy.Text = "注册表备份";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // tbxDllPath
            // 
            this.tbxDllPath.Location = new System.Drawing.Point(527, 27);
            this.tbxDllPath.Name = "tbxDllPath";
            this.tbxDllPath.Size = new System.Drawing.Size(135, 21);
            this.tbxDllPath.TabIndex = 12;
            this.tbxDllPath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxDllPath_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "请输入插件路径";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 507);
            this.Controls.Add(this.tbxDllPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxRegPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxRegDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxRegName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoCAD插件注册表注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxRegName;
        private System.Windows.Forms.TextBox tbxRegDesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxRegPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox tbxDllPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

