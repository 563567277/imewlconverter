﻿namespace Studyzy.IMEWLConverter
{
    partial class FilterConfigForm
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
            this.btnOK = new System.Windows.Forms.Button();
            this.numWordLengthFrom = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numWordLengthTo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numWordRankFrom = new System.Windows.Forms.NumericUpDown();
            this.numWordRankTo = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxFilterEnglish = new System.Windows.Forms.CheckBox();
            this.cbxFilterSpace = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numWordLengthFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWordLengthTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWordRankFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWordRankTo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(189, 174);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // numWordLengthFrom
            // 
            this.numWordLengthFrom.Location = new System.Drawing.Point(97, 21);
            this.numWordLengthFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWordLengthFrom.Name = "numWordLengthFrom";
            this.numWordLengthFrom.Size = new System.Drawing.Size(65, 21);
            this.numWordLengthFrom.TabIndex = 1;
            this.numWordLengthFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "保留字数： 从";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "保留词频： 从";
            // 
            // numWordLengthTo
            // 
            this.numWordLengthTo.Location = new System.Drawing.Point(199, 21);
            this.numWordLengthTo.Name = "numWordLengthTo";
            this.numWordLengthTo.Size = new System.Drawing.Size(65, 21);
            this.numWordLengthTo.TabIndex = 1;
            this.numWordLengthTo.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "到";
            // 
            // numWordRankFrom
            // 
            this.numWordRankFrom.Location = new System.Drawing.Point(97, 57);
            this.numWordRankFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numWordRankFrom.Name = "numWordRankFrom";
            this.numWordRankFrom.Size = new System.Drawing.Size(65, 21);
            this.numWordRankFrom.TabIndex = 1;
            this.numWordRankFrom.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numWordRankTo
            // 
            this.numWordRankTo.Location = new System.Drawing.Point(199, 57);
            this.numWordRankTo.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numWordRankTo.Name = "numWordRankTo";
            this.numWordRankTo.Size = new System.Drawing.Size(65, 21);
            this.numWordRankTo.TabIndex = 1;
            this.numWordRankTo.Value = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "到";
            // 
            // cbxFilterEnglish
            // 
            this.cbxFilterEnglish.AutoSize = true;
            this.cbxFilterEnglish.Checked = true;
            this.cbxFilterEnglish.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFilterEnglish.Location = new System.Drawing.Point(14, 100);
            this.cbxFilterEnglish.Name = "cbxFilterEnglish";
            this.cbxFilterEnglish.Size = new System.Drawing.Size(120, 16);
            this.cbxFilterEnglish.TabIndex = 5;
            this.cbxFilterEnglish.Text = "过滤包含英文的词";
            this.cbxFilterEnglish.UseVisualStyleBackColor = true;
            // 
            // cbxFilterSpace
            // 
            this.cbxFilterSpace.AutoSize = true;
            this.cbxFilterSpace.Checked = true;
            this.cbxFilterSpace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxFilterSpace.Location = new System.Drawing.Point(14, 138);
            this.cbxFilterSpace.Name = "cbxFilterSpace";
            this.cbxFilterSpace.Size = new System.Drawing.Size(120, 16);
            this.cbxFilterSpace.TabIndex = 6;
            this.cbxFilterSpace.Text = "过滤包含空格的词";
            this.cbxFilterSpace.UseVisualStyleBackColor = true;
            // 
            // FilterConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 215);
            this.Controls.Add(this.cbxFilterSpace);
            this.Controls.Add(this.cbxFilterEnglish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numWordRankTo);
            this.Controls.Add(this.numWordRankFrom);
            this.Controls.Add(this.numWordLengthTo);
            this.Controls.Add(this.numWordLengthFrom);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FilterConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "词条过滤设置";
            this.Load += new System.EventHandler(this.FilterConfigForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numWordLengthFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWordLengthTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWordRankFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWordRankTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown numWordLengthFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numWordLengthTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numWordRankFrom;
        private System.Windows.Forms.NumericUpDown numWordRankTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbxFilterEnglish;
        private System.Windows.Forms.CheckBox cbxFilterSpace;
    }
}