﻿namespace Spreadsheet_Document_Api_Part_3
{
    partial class Form1
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
            this.verticalSplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.horisontalSplitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.richEditControlCS = new DevExpress.XtraRichEdit.RichEditControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.richEditControlVB = new DevExpress.XtraRichEdit.RichEditControl();
            this.codeExampleNameLbl = new DevExpress.XtraEditors.LabelControl();
            this.btnOpenExcel = new DevExpress.XtraEditors.SimpleButton();
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitContainerControl1)).BeginInit();
            this.verticalSplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.horisontalSplitContainerControl1)).BeginInit();
            this.horisontalSplitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            this.SuspendLayout();
            // 
            // verticalSplitContainerControl1
            // 
            this.verticalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.verticalSplitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.verticalSplitContainerControl1.Margin = new System.Windows.Forms.Padding(6);
            this.verticalSplitContainerControl1.Name = "verticalSplitContainerControl1";
            this.verticalSplitContainerControl1.Panel1.Controls.Add(this.horisontalSplitContainerControl1);
            this.verticalSplitContainerControl1.Panel1.Text = "Panel1";
            this.verticalSplitContainerControl1.Panel2.Controls.Add(this.treeList1);
            this.verticalSplitContainerControl1.Panel2.Text = "Panel2";
            this.verticalSplitContainerControl1.Size = new System.Drawing.Size(2424, 1260);
            this.verticalSplitContainerControl1.SplitterPosition = 1898;
            this.verticalSplitContainerControl1.TabIndex = 0;
            this.verticalSplitContainerControl1.Text = "splitContainerControl1";
            // 
            // horisontalSplitContainerControl1
            // 
            this.horisontalSplitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.horisontalSplitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.horisontalSplitContainerControl1.Horizontal = false;
            this.horisontalSplitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.horisontalSplitContainerControl1.Margin = new System.Windows.Forms.Padding(6);
            this.horisontalSplitContainerControl1.Name = "horisontalSplitContainerControl1";
            this.horisontalSplitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.horisontalSplitContainerControl1.Panel1.Controls.Add(this.codeExampleNameLbl);
            this.horisontalSplitContainerControl1.Panel1.Text = "Panel1";
            this.horisontalSplitContainerControl1.Panel2.Controls.Add(this.btnOpenExcel);
            this.horisontalSplitContainerControl1.Panel2.Text = "Panel2";
            this.horisontalSplitContainerControl1.Size = new System.Drawing.Size(1898, 1260);
            this.horisontalSplitContainerControl1.SplitterPosition = 137;
            this.horisontalSplitContainerControl1.TabIndex = 0;
            this.horisontalSplitContainerControl1.Text = "splitContainerControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.AppearancePage.PageClient.BackColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.AppearancePage.PageClient.BackColor2 = System.Drawing.Color.Transparent;
            this.xtraTabControl1.AppearancePage.PageClient.BorderColor = System.Drawing.Color.Transparent;
            this.xtraTabControl1.AppearancePage.PageClient.Options.UseBackColor = true;
            this.xtraTabControl1.AppearancePage.PageClient.Options.UseBorderColor = true;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 84);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1898, 1019);
            this.xtraTabControl1.TabIndex = 1;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage1.Appearance.HeaderActive.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.richEditControlCS);
            this.xtraTabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1894, 968);
            this.xtraTabPage1.Text = "C#";
            // 
            // richEditControlCS
            // 
            this.richEditControlCS.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.richEditControlCS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControlCS.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.richEditControlCS.Location = new System.Drawing.Point(0, 0);
            this.richEditControlCS.Margin = new System.Windows.Forms.Padding(6);
            this.richEditControlCS.Name = "richEditControlCS";
            this.richEditControlCS.Options.Annotations.ShowAllAuthors = false;
            this.richEditControlCS.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richEditControlCS.Size = new System.Drawing.Size(1894, 968);
            this.richEditControlCS.TabIndex = 0;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Appearance.HeaderActive.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xtraTabPage2.Appearance.HeaderActive.Options.UseFont = true;
            this.xtraTabPage2.Controls.Add(this.richEditControlVB);
            this.xtraTabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1894, 968);
            this.xtraTabPage2.Text = "VB";
            // 
            // richEditControlVB
            // 
            this.richEditControlVB.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Draft;
            this.richEditControlVB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControlVB.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.richEditControlVB.Location = new System.Drawing.Point(0, 0);
            this.richEditControlVB.Margin = new System.Windows.Forms.Padding(6);
            this.richEditControlVB.Name = "richEditControlVB";
            this.richEditControlVB.Options.Annotations.ShowAllAuthors = false;
            this.richEditControlVB.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richEditControlVB.Size = new System.Drawing.Size(1894, 968);
            this.richEditControlVB.TabIndex = 0;
            // 
            // codeExampleNameLbl
            // 
            this.codeExampleNameLbl.Appearance.Font = new System.Drawing.Font("Arial", 20.25F);
            this.codeExampleNameLbl.Appearance.Options.UseFont = true;
            this.codeExampleNameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.codeExampleNameLbl.Location = new System.Drawing.Point(0, 0);
            this.codeExampleNameLbl.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.codeExampleNameLbl.Name = "codeExampleNameLbl";
            this.codeExampleNameLbl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 23);
            this.codeExampleNameLbl.Size = new System.Drawing.Size(146, 84);
            this.codeExampleNameLbl.TabIndex = 0;
            this.codeExampleNameLbl.Text = "label1";
            // 
            // btnOpenExcel
            // 
            this.btnOpenExcel.Location = new System.Drawing.Point(24, 15);
            this.btnOpenExcel.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenExcel.Name = "btnOpenExcel";
            this.btnOpenExcel.Size = new System.Drawing.Size(364, 87);
            this.btnOpenExcel.TabIndex = 0;
            this.btnOpenExcel.Text = "Open in Microsoft Excel";
            this.btnOpenExcel.Click += new System.EventHandler(this.btnOpenExcel_Click);
            // 
            // treeList1
            // 
            this.treeList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList1.Location = new System.Drawing.Point(0, 0);
            this.treeList1.Margin = new System.Windows.Forms.Padding(6);
            this.treeList1.Name = "treeList1";
            this.treeList1.Size = new System.Drawing.Size(506, 1260);
            this.treeList1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2424, 1260);
            this.Controls.Add(this.verticalSplitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.verticalSplitContainerControl1)).EndInit();
            this.verticalSplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.horisontalSplitContainerControl1)).EndInit();
            this.horisontalSplitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl verticalSplitContainerControl1;
        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraEditors.SplitContainerControl horisontalSplitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.LabelControl codeExampleNameLbl;
        private DevExpress.XtraRichEdit.RichEditControl richEditControlCS;
        private DevExpress.XtraRichEdit.RichEditControl richEditControlVB;
        private DevExpress.XtraEditors.SimpleButton btnOpenExcel;
    }
}

