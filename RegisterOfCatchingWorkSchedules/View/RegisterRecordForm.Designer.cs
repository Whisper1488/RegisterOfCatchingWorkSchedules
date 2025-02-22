﻿namespace RegisterOfCatchingWorkSchedules.View
{
	partial class RegisterRecordForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.cbStatus = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpDate = new System.Windows.Forms.DateTimePicker();
			this.btStatusHistory = new System.Windows.Forms.Button();
			this.dgvPlan = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.tbMunicipality = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(567, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Статус";
			// 
			// cbStatus
			// 
			this.cbStatus.FormattingEnabled = true;
			this.cbStatus.Location = new System.Drawing.Point(570, 40);
			this.cbStatus.Name = "cbStatus";
			this.cbStatus.Size = new System.Drawing.Size(258, 21);
			this.cbStatus.TabIndex = 2;
			this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.OnStatusChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(33, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Дата";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(257, 24);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(102, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "Населённый пункт";
			// 
			// dtpDate
			// 
			this.dtpDate.CustomFormat = "MMMMyyyy";
			this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dtpDate.Location = new System.Drawing.Point(30, 40);
			this.dtpDate.Name = "dtpDate";
			this.dtpDate.Size = new System.Drawing.Size(200, 20);
			this.dtpDate.TabIndex = 11;
			this.dtpDate.ValueChanged += new System.EventHandler(this.OnDateChanged);
			// 
			// btStatusHistory
			// 
			this.btStatusHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btStatusHistory.Location = new System.Drawing.Point(967, 38);
			this.btStatusHistory.Name = "btStatusHistory";
			this.btStatusHistory.Size = new System.Drawing.Size(162, 23);
			this.btStatusHistory.TabIndex = 13;
			this.btStatusHistory.Text = "Показать историю статусов";
			this.btStatusHistory.UseVisualStyleBackColor = true;
			this.btStatusHistory.Click += new System.EventHandler(this.OpenPlanHistory);
			// 
			// dgvPlan
			// 
			this.dgvPlan.AllowUserToAddRows = false;
			this.dgvPlan.AllowUserToDeleteRows = false;
			this.dgvPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPlan.Enabled = false;
			this.dgvPlan.Location = new System.Drawing.Point(30, 89);
			this.dgvPlan.Name = "dgvPlan";
			this.dgvPlan.Size = new System.Drawing.Size(1099, 377);
			this.dgvPlan.TabIndex = 14;
			this.dgvPlan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnDataGridCellClick);
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Location = new System.Drawing.Point(1039, 481);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(90, 23);
			this.button1.TabIndex = 15;
			this.button1.Text = "Сохранить";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// tbMunicipality
			// 
			this.tbMunicipality.Enabled = false;
			this.tbMunicipality.Location = new System.Drawing.Point(260, 40);
			this.tbMunicipality.Name = "tbMunicipality";
			this.tbMunicipality.Size = new System.Drawing.Size(274, 20);
			this.tbMunicipality.TabIndex = 16;
			// 
			// RegisterRecordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1162, 510);
			this.Controls.Add(this.tbMunicipality);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgvPlan);
			this.Controls.Add(this.btStatusHistory);
			this.Controls.Add(this.dtpDate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cbStatus);
			this.Controls.Add(this.label1);
			this.Name = "RegisterRecordForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "План-график работ по отлову";
			((System.ComponentModel.ISupportInitialize)(this.dgvPlan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbStatus;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpDate;
		private System.Windows.Forms.Button btStatusHistory;
		private System.Windows.Forms.DataGridView dgvPlan;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tbMunicipality;
	}
}