﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisterOfCatchingWorkSchedules
{
	public partial class RegisterRecordForm : Form
	{
		public RegisterRecordForm()
		{
			InitializeComponent();
		}

		private void btStatusHistory_Click(object sender, EventArgs e)
		{
			new StatusHistoryForm().ShowDialog();
		}
	}
}
