namespace CreateAccess
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Inquiretb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Createtb = new System.Windows.Forms.TextBox();
            this.Time = new System.Windows.Forms.TextBox();
            this.Remark = new System.Windows.Forms.TextBox();
            this.Create = new System.Windows.Forms.Button();
            this.Modifytb = new System.Windows.Forms.ComboBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.cdtime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.modify = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.updatelist = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.Compar = new System.Windows.Forms.Button();
            this.ModifyData = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.RemoveData = new System.Windows.Forms.Button();
            this.ComparTable = new System.Windows.Forms.Button();
            this.ModifyTable = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "查詢Table名稱";
            // 
            // Inquiretb
            // 
            this.Inquiretb.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Inquiretb.FormattingEnabled = true;
            this.Inquiretb.Location = new System.Drawing.Point(150, 30);
            this.Inquiretb.Name = "Inquiretb";
            this.Inquiretb.Size = new System.Drawing.Size(234, 27);
            this.Inquiretb.TabIndex = 1;
            this.Inquiretb.SelectedIndexChanged += new System.EventHandler(this.Inquiretb_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 467);
            this.dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(481, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "創建修改Table名稱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(518, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "修改日期";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(538, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "備註";
            // 
            // Createtb
            // 
            this.Createtb.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Createtb.Location = new System.Drawing.Point(651, 112);
            this.Createtb.Name = "Createtb";
            this.Createtb.Size = new System.Drawing.Size(315, 30);
            this.Createtb.TabIndex = 6;
            // 
            // Time
            // 
            this.Time.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Time.Location = new System.Drawing.Point(651, 155);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(315, 30);
            this.Time.TabIndex = 7;
            this.Time.Text = "//";
            // 
            // Remark
            // 
            this.Remark.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Remark.Location = new System.Drawing.Point(651, 202);
            this.Remark.Name = "Remark";
            this.Remark.Size = new System.Drawing.Size(315, 30);
            this.Remark.TabIndex = 8;
            // 
            // Create
            // 
            this.Create.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Create.Location = new System.Drawing.Point(651, 238);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(155, 48);
            this.Create.TabIndex = 9;
            this.Create.Text = "創建修改Table";
            this.Create.UseVisualStyleBackColor = true;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // Modifytb
            // 
            this.Modifytb.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Modifytb.FormattingEnabled = true;
            this.Modifytb.Location = new System.Drawing.Point(651, 31);
            this.Modifytb.Name = "Modifytb";
            this.Modifytb.Size = new System.Drawing.Size(155, 27);
            this.Modifytb.TabIndex = 11;
            // 
            // Refresh
            // 
            this.Refresh.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Refresh.Location = new System.Drawing.Point(390, 20);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(85, 38);
            this.Refresh.TabIndex = 12;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // cdtime
            // 
            this.cdtime.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cdtime.Location = new System.Drawing.Point(812, 32);
            this.cdtime.Name = "cdtime";
            this.cdtime.Size = new System.Drawing.Size(154, 30);
            this.cdtime.TabIndex = 13;
            this.cdtime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cdtime_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(518, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "修改初值";
            // 
            // modify
            // 
            this.modify.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.modify.Location = new System.Drawing.Point(651, 64);
            this.modify.Name = "modify";
            this.modify.Size = new System.Drawing.Size(155, 42);
            this.modify.TabIndex = 15;
            this.modify.Text = "確認修改";
            this.modify.UseVisualStyleBackColor = true;
            this.modify.Click += new System.EventHandler(this.modify_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(511, 303);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(455, 184);
            this.listBox1.TabIndex = 16;
            // 
            // updatelist
            // 
            this.updatelist.Location = new System.Drawing.Point(892, 493);
            this.updatelist.Name = "updatelist";
            this.updatelist.Size = new System.Drawing.Size(74, 48);
            this.updatelist.TabIndex = 18;
            this.updatelist.Text = "更新";
            this.updatelist.UseVisualStyleBackColor = true;
            this.updatelist.Click += new System.EventHandler(this.updatelist_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(802, 493);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(74, 48);
            this.Remove.TabIndex = 19;
            this.Remove.Text = "移除";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Delete.Location = new System.Drawing.Point(812, 238);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(154, 48);
            this.Delete.TabIndex = 20;
            this.Delete.Text = "刪除Table及Tableinfo";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(712, 493);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(74, 48);
            this.add.TabIndex = 21;
            this.add.Text = "新增";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // Compar
            // 
            this.Compar.Location = new System.Drawing.Point(622, 493);
            this.Compar.Name = "Compar";
            this.Compar.Size = new System.Drawing.Size(74, 48);
            this.Compar.TabIndex = 22;
            this.Compar.Text = "比對";
            this.Compar.UseVisualStyleBackColor = true;
            // 
            // ModifyData
            // 
            this.ModifyData.Location = new System.Drawing.Point(119, 544);
            this.ModifyData.Name = "ModifyData";
            this.ModifyData.Size = new System.Drawing.Size(356, 22);
            this.ModifyData.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(18, 547);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "修改資料 :";
            // 
            // RemoveData
            // 
            this.RemoveData.Location = new System.Drawing.Point(43, 572);
            this.RemoveData.Name = "RemoveData";
            this.RemoveData.Size = new System.Drawing.Size(101, 45);
            this.RemoveData.TabIndex = 25;
            this.RemoveData.Text = "移除";
            this.RemoveData.UseVisualStyleBackColor = true;
            this.RemoveData.Click += new System.EventHandler(this.RemoveData_Click);
            // 
            // ComparTable
            // 
            this.ComparTable.Location = new System.Drawing.Point(150, 572);
            this.ComparTable.Name = "ComparTable";
            this.ComparTable.Size = new System.Drawing.Size(101, 45);
            this.ComparTable.TabIndex = 26;
            this.ComparTable.Text = "比對";
            this.ComparTable.UseVisualStyleBackColor = true;
            this.ComparTable.Click += new System.EventHandler(this.ComparTable_Click);
            // 
            // ModifyTable
            // 
            this.ModifyTable.Location = new System.Drawing.Point(257, 572);
            this.ModifyTable.Name = "ModifyTable";
            this.ModifyTable.Size = new System.Drawing.Size(101, 45);
            this.ModifyTable.TabIndex = 27;
            this.ModifyTable.Text = "修改";
            this.ModifyTable.UseVisualStyleBackColor = true;
            this.ModifyTable.Click += new System.EventHandler(this.ModifyTable_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(364, 572);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(101, 45);
            this.Save.TabIndex = 28;
            this.Save.Text = "儲存";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 629);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ModifyTable);
            this.Controls.Add(this.ComparTable);
            this.Controls.Add(this.RemoveData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ModifyData);
            this.Controls.Add(this.Compar);
            this.Controls.Add(this.add);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.updatelist);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.modify);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cdtime);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.Modifytb);
            this.Controls.Add(this.Create);
            this.Controls.Add(this.Remark);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Createtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Inquiretb);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Access";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Inquiretb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Createtb;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.TextBox Remark;
        private System.Windows.Forms.Button Create;
        private System.Windows.Forms.ComboBox Modifytb;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.TextBox cdtime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button modify;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button updatelist;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button Compar;
        private System.Windows.Forms.TextBox ModifyData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button RemoveData;
        private System.Windows.Forms.Button ComparTable;
        private System.Windows.Forms.Button ModifyTable;
        private System.Windows.Forms.Button Save;
    }
}

