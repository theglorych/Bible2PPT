﻿namespace Bible2PPT
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cmbShortTitle = new System.Windows.Forms.ComboBox();
            this.cmbLongTitle = new System.Windows.Forms.ComboBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.radEasy = new System.Windows.Forms.RadioButton();
            this.radRevision = new System.Windows.Forms.RadioButton();
            this.cmbChapNum = new System.Windows.Forms.ComboBox();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.btnTemplate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chkFragment = new System.Windows.Forms.CheckBox();
            this.lstBible = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbShortTitle
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmbShortTitle, 2);
            this.cmbShortTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbShortTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShortTitle.Items.AddRange(new object[] {
            "짧은 제목 표시",
            "각 장의 첫 절에만 표시"});
            this.cmbShortTitle.Location = new System.Drawing.Point(10, 74);
            this.cmbShortTitle.Margin = new System.Windows.Forms.Padding(0);
            this.cmbShortTitle.Name = "cmbShortTitle";
            this.cmbShortTitle.Size = new System.Drawing.Size(156, 20);
            this.cmbShortTitle.TabIndex = 3;
            this.cmbShortTitle.SelectedIndexChanged += new System.EventHandler(this.cmbShortTitle_SelectedIndexChanged);
            // 
            // cmbLongTitle
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmbLongTitle, 2);
            this.cmbLongTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbLongTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLongTitle.Items.AddRange(new object[] {
            "긴 제목 표시",
            "각 장의 첫 절에만 표시"});
            this.cmbLongTitle.Location = new System.Drawing.Point(10, 49);
            this.cmbLongTitle.Margin = new System.Windows.Forms.Padding(0);
            this.cmbLongTitle.Name = "cmbLongTitle";
            this.cmbLongTitle.Size = new System.Drawing.Size(156, 20);
            this.cmbLongTitle.TabIndex = 2;
            this.cmbLongTitle.SelectedIndexChanged += new System.EventHandler(this.cmbLongTitle_SelectedIndexChanged);
            // 
            // btnMake
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnMake, 2);
            this.btnMake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMake.Enabled = false;
            this.btnMake.Location = new System.Drawing.Point(10, 203);
            this.btnMake.Margin = new System.Windows.Forms.Padding(0);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(156, 29);
            this.btnMake.TabIndex = 8;
            this.btnMake.Text = "PPT 만들기";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // radEasy
            // 
            this.radEasy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radEasy.Location = new System.Drawing.Point(91, 123);
            this.radEasy.Name = "radEasy";
            this.radEasy.Size = new System.Drawing.Size(72, 16);
            this.radEasy.TabIndex = 5;
            this.radEasy.Text = "쉬운성경";
            this.radEasy.UseVisualStyleBackColor = true;
            this.radEasy.CheckedChanged += new System.EventHandler(this.radEasy_CheckedChanged);
            // 
            // radRevision
            // 
            this.radRevision.Checked = true;
            this.radRevision.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radRevision.Location = new System.Drawing.Point(13, 123);
            this.radRevision.Name = "radRevision";
            this.radRevision.Size = new System.Drawing.Size(72, 16);
            this.radRevision.TabIndex = 5;
            this.radRevision.TabStop = true;
            this.radRevision.Text = "개역개정";
            this.radRevision.UseVisualStyleBackColor = true;
            // 
            // cmbChapNum
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmbChapNum, 2);
            this.cmbChapNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbChapNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChapNum.Items.AddRange(new object[] {
            "장 번호 표시",
            "각 장의 첫 절에만 표시"});
            this.cmbChapNum.Location = new System.Drawing.Point(10, 99);
            this.cmbChapNum.Margin = new System.Windows.Forms.Padding(0);
            this.cmbChapNum.Name = "cmbChapNum";
            this.cmbChapNum.Size = new System.Drawing.Size(156, 20);
            this.cmbChapNum.TabIndex = 4;
            this.cmbChapNum.SelectedIndexChanged += new System.EventHandler(this.cmbChapNum_SelectedIndexChanged);
            // 
            // txtKeyword
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtKeyword, 2);
            this.txtKeyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeyword.Enabled = false;
            this.txtKeyword.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtKeyword.Location = new System.Drawing.Point(10, 142);
            this.txtKeyword.Margin = new System.Windows.Forms.Padding(0);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(156, 29);
            this.txtKeyword.TabIndex = 6;
            this.txtKeyword.Text = "목록 초기화 중...";
            this.txtKeyword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKeyword_KeyPress);
            this.txtKeyword.MouseHover += new System.EventHandler(this.txtKeyword_MouseHover);
            // 
            // btnTemplate
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnTemplate, 2);
            this.btnTemplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTemplate.Location = new System.Drawing.Point(10, 10);
            this.btnTemplate.Margin = new System.Windows.Forms.Padding(0);
            this.btnTemplate.Name = "btnTemplate";
            this.btnTemplate.Size = new System.Drawing.Size(156, 29);
            this.btnTemplate.TabIndex = 1;
            this.btnTemplate.Text = "템플릿 열기";
            this.btnTemplate.UseVisualStyleBackColor = true;
            this.btnTemplate.Click += new System.EventHandler(this.btnTemplate_Click);
            this.btnTemplate.MouseHover += new System.EventHandler(this.btnTemplate_MouseHover);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel1.Controls.Add(this.btnTemplate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtKeyword, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.cmbChapNum, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.radRevision, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.radEasy, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.btnMake, 1, 12);
            this.tableLayoutPanel1.Controls.Add(this.cmbLongTitle, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbShortTitle, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.chkFragment, 1, 11);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(155, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(179, 249);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chkFragment
            // 
            this.chkFragment.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.chkFragment, 2);
            this.chkFragment.Location = new System.Drawing.Point(13, 184);
            this.chkFragment.Name = "chkFragment";
            this.chkFragment.Size = new System.Drawing.Size(128, 16);
            this.chkFragment.TabIndex = 7;
            this.chkFragment.Text = "파일 장별로 나누기";
            this.chkFragment.UseVisualStyleBackColor = true;
            this.chkFragment.CheckedChanged += new System.EventHandler(this.chkFragment_CheckedChanged);
            // 
            // lstBible
            // 
            this.lstBible.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstBible.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBible.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.title,
            this.length});
            this.lstBible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstBible.Enabled = false;
            this.lstBible.FullRowSelect = true;
            this.lstBible.GridLines = true;
            this.lstBible.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstBible.HideSelection = false;
            this.lstBible.Location = new System.Drawing.Point(0, 23);
            this.lstBible.Margin = new System.Windows.Forms.Padding(0);
            this.lstBible.Name = "lstBible";
            this.lstBible.Size = new System.Drawing.Size(155, 226);
            this.lstBible.TabIndex = 0;
            this.lstBible.TabStop = false;
            this.lstBible.UseCompatibleStateImageBehavior = false;
            this.lstBible.View = System.Windows.Forms.View.Details;
            this.lstBible.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstBible_MouseClick);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 0;
            // 
            // title
            // 
            this.title.Text = "제목";
            this.title.Width = 98;
            // 
            // length
            // 
            this.length.Text = "장 수";
            this.length.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.length.Width = 40;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Gulim", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(0);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(155, 22);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "검색...";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.lstBible, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(155, 249);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 249);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "성경2PPT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox cmbShortTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnTemplate;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox cmbChapNum;
        private System.Windows.Forms.RadioButton radRevision;
        private System.Windows.Forms.RadioButton radEasy;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.ComboBox cmbLongTitle;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader length;
        private System.Windows.Forms.ListView lstBible;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckBox chkFragment;
    }
}

