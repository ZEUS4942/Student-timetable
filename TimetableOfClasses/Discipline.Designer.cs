﻿namespace TimetableOfClasses
{
    partial class Discipline
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
			this.DG_Disc = new System.Windows.Forms.DataGridView();
			this.Delete = new System.Windows.Forms.Button();
			this.btCreateDiscipline = new System.Windows.Forms.Button();
			this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Shortname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CycleofDis = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.DG_Disc)).BeginInit();
			this.SuspendLayout();
			// 
			// DG_Disc
			// 
			this.DG_Disc.AllowUserToAddRows = false;
			this.DG_Disc.AllowUserToDeleteRows = false;
			this.DG_Disc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DG_Disc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DG_Disc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.FullName,
            this.Shortname,
            this.CycleofDis});
			this.DG_Disc.Location = new System.Drawing.Point(12, 12);
			this.DG_Disc.Name = "DG_Disc";
			this.DG_Disc.ReadOnly = true;
			this.DG_Disc.RowHeadersVisible = false;
			this.DG_Disc.Size = new System.Drawing.Size(394, 156);
			this.DG_Disc.TabIndex = 0;
			this.DG_Disc.SelectionChanged += new System.EventHandler(this.DG_Disc_SelectionChanged);
			// 
			// Delete
			// 
			this.Delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.Delete.Enabled = false;
			this.Delete.Location = new System.Drawing.Point(167, 175);
			this.Delete.Name = "Delete";
			this.Delete.Size = new System.Drawing.Size(75, 23);
			this.Delete.TabIndex = 1;
			this.Delete.Text = "Удалить";
			this.Delete.UseVisualStyleBackColor = true;
			this.Delete.Click += new System.EventHandler(this.Delete_Click);
			// 
			// btCreateDiscipline
			// 
			this.btCreateDiscipline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btCreateDiscipline.Location = new System.Drawing.Point(331, 175);
			this.btCreateDiscipline.Name = "btCreateDiscipline";
			this.btCreateDiscipline.Size = new System.Drawing.Size(75, 23);
			this.btCreateDiscipline.TabIndex = 2;
			this.btCreateDiscipline.Text = "Создать";
			this.btCreateDiscipline.UseVisualStyleBackColor = true;
			this.btCreateDiscipline.Click += new System.EventHandler(this.btCreateDiscipline_Click);
			// 
			// Number
			// 
			this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.Number.HeaderText = "";
			this.Number.Name = "Number";
			this.Number.ReadOnly = true;
			this.Number.Width = 19;
			// 
			// FullName
			// 
			this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.FullName.DataPropertyName = "Fullname";
			this.FullName.HeaderText = "Полное название дисциплины";
			this.FullName.Name = "FullName";
			this.FullName.ReadOnly = true;
			// 
			// Shortname
			// 
			this.Shortname.DataPropertyName = "Shortname";
			this.Shortname.HeaderText = "Краткое название дисциплины";
			this.Shortname.Name = "Shortname";
			this.Shortname.ReadOnly = true;
			// 
			// CycleofDis
			// 
			this.CycleofDis.DataPropertyName = "CycleofDiscipline";
			this.CycleofDis.HeaderText = "Цикл дисциплин";
			this.CycleofDis.Name = "CycleofDis";
			this.CycleofDis.ReadOnly = true;
			// 
			// Discipline
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(417, 203);
			this.Controls.Add(this.btCreateDiscipline);
			this.Controls.Add(this.Delete);
			this.Controls.Add(this.DG_Disc);
			this.Name = "Discipline";
			this.Text = "Дисциплины";
			((System.ComponentModel.ISupportInitialize)(this.DG_Disc)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_Disc;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button btCreateDiscipline;
		private System.Windows.Forms.DataGridViewTextBoxColumn Number;
		private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Shortname;
		private System.Windows.Forms.DataGridViewTextBoxColumn CycleofDis;
	}
}