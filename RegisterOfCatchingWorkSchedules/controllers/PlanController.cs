﻿using RegisterOfCatchingWorkSchedules.Services;
using System;
using System.Collections.Generic;

namespace RegisterOfCatchingWorkSchedules.Coltrollers
{
	public static class PlanController
	{
		public static List<Plans> GetAllPlans(Filter filter, int page) => PlansManagementService.GetAllowedPlans(filter, page);

		public static Plans GetPlan(int planID) => PlansManagementService.GetById(planID);

		public static Plans CreatePlan(DateTime date) => PlansManagementService.CreatePlan(date);

		public static void SetPlanDate(int planID, DateTime date) => PlansManagementService.ChangePlanPropertiy(planID, "PlanDate", date);

		public static void SetPlanStatus(int planID, Statuses status) => PlansManagementService.SetPlanStatus(planID, status.ID);

		public static void AddRecord(int planID, int placeID, int day) => RecordManagementService.CreateRecord(planID, placeID, day);

		public static void RemoveRecord(int planID, int placeID, int day) => RecordManagementService.RemoveRecord(planID, placeID, day);

		public static StatusHistory[] GetStatusHistory(int planID) => StatusHistoryService.GetHistory(planID);

		public static void RemovePlan(int planID) => PlansManagementService.DeletePlan(planID);

		public static void RemoveAllRecords(int planID) => PlansManagementService.RemovePlanRecords(planID);
	}
}
