﻿using System;
using System.Windows.Forms;

namespace RegisterOfCatchingWorkSchedules
{
	public class PlanController
	{
		public Plan[] GetAllPlans() { throw new NotImplementedException(); }

		public Plan OpenPlan(int id) { throw new NotImplementedException(); }

		public void CreatePlan(Plan plan) { }

		public bool TryRemovePlan(int id) { throw new NotImplementedException(); }

		public void SetPlanStatus(Statuses status) { }

		public void AddLocation(Location location) { }

		public void ToggleTask(Location location, DateTime day) { }

		public StatusHistory[] GetStatusHistory(int planID) { throw new NotImplementedException(); }

		public void Save() { }
	}
}
