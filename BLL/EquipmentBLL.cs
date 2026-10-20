using DAL;
using LoanDesk.Models;
using System;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class EquipmentBLL
    {
        private enum eActions { Add, Update, Activate, Deactivate };
        static eActions Actions { get; set; }
        private static readonly  string EntityType="Equipments";
        private static void CheckEquipment(Equipment NewEquipment)
        {
            utilities.utilities.IsEmptyOrNullOrWhiteSpace(NewEquipment.Name, "Equipment Name");
            NewEquipment.Name = NewEquipment.Name?.Trim();
            utilities.utilities.ValidateLength(NewEquipment.Name, "Equipment Name", 5, 250);
            if (NewEquipment.TotalQuantity < 0)
                throw new Exceptions.BusinessRuleException("Total Quantity can't be less than 0.");
            if (NewEquipment.AvailableQuantity < 0)
                throw new Exceptions.BusinessRuleException("Available Quantity can't be less than 0.");
            if (NewEquipment.AvailableQuantity > NewEquipment.TotalQuantity)
                throw new Exceptions.BusinessRuleException("Available Quantity must be less than Total Quantity.");
            if (NewEquipment.DailyLateFee < 0)
                throw new Exceptions.BusinessRuleException("Daily Late Fee can't be less than 0.");
            if (NewEquipment.ReplacementCost < 0)
                throw new Exceptions.BusinessRuleException("Replacement Cost can't be less than 0.");
            if (NewEquipment.DailyLateFee > NewEquipment.ReplacementCost)
                throw new Exceptions.BusinessRuleException("Daily Late Fee can't be greater than Replacement Cost");
        }

        private static void IsEquipmentNameIsTaken(Equipment NewEquipment)
        {
            Equipment equipment_1 = EquipmentDAL.GetEquipmentByName(NewEquipment.Name);
            if (equipment_1 != null && equipment_1.ID != NewEquipment.ID)
                throw new Exceptions.BusinessRuleException("Duplicate equipment name.");
        }

        public static bool AddEquipment(Equipment NewEquipment)
        {
            UserBLL.RequireUser();
            NewEquipment.AvailableQuantity = NewEquipment.TotalQuantity;
            CheckEquipment(NewEquipment);
            IsEquipmentNameIsTaken(NewEquipment);

            bool IsAdded = false;
            IsAdded= EquipmentDAL.AddEquipment(NewEquipment);
            if (IsAdded)
            {
                AuditLog auditLog = new AuditLog();
                auditLog.UserID = Sessions.CurrentUser.ID;
                auditLog.ActionDate = DateTime.Now;
                Actions = eActions.Add;
                auditLog.Action = Actions.ToString();
                auditLog.EntityType = EntityType;
                auditLog.EntityID = NewEquipment.ID;
                auditLog.Details = "Add New Equipment.";
                AuditLogBLL.AddNewAuditLog(auditLog);

            }
            return IsAdded;
        }

        private static void CalculateAvailablQuantity(Equipment NewEquipment)
        {
            Equipment OrginalEquipment = EquipmentDAL.GetEquipmentByID(NewEquipment.ID);

            int def = OrginalEquipment.TotalQuantity - NewEquipment.TotalQuantity;

            if (def <= NewEquipment.AvailableQuantity)
                NewEquipment.AvailableQuantity -= def;
            else
                throw new Exceptions.BusinessRuleException("You can not do this operation.");
        }

        public static bool UpdateEquipment(Equipment NewEquipment)
        {
            UserBLL.RequireUser();

            CalculateAvailablQuantity(NewEquipment);
            CheckEquipment(NewEquipment);
            IsEquipmentNameIsTaken(NewEquipment);
            bool IsUpdated= EquipmentDAL.UdpateEquipment(NewEquipment);
            if (IsUpdated)
            {
                AuditLog auditLog = new AuditLog();
                auditLog.UserID = Sessions.CurrentUser.ID;
                auditLog.ActionDate = DateTime.Now;
                Actions = eActions.Update;
                auditLog.Action = Actions.ToString();
                auditLog.EntityType = EntityType;
                auditLog.EntityID = NewEquipment.ID;
                auditLog.Details = "Update Equipment.";
                AuditLogBLL.AddNewAuditLog(auditLog);
            }
            return IsUpdated;
        }

        public static Equipment GetEquipmentByID(int EquipmentID)
        {
            return EquipmentDAL.GetEquipmentByID(EquipmentID);
        }

        public static bool ActivateEquipment(int EquipmentID)
        {
            UserBLL.RequireUser();
            bool IsActivated= EquipmentDAL.ActivateEquipment(EquipmentID);
            if (IsActivated)
            {
                AuditLog auditLog = new AuditLog();
                auditLog.UserID = Sessions.CurrentUser.ID;
                auditLog.ActionDate = DateTime.Now;
                Actions = eActions.Activate;
                auditLog.Action = Actions.ToString();
                auditLog.EntityType = EntityType;
                auditLog.EntityID = EquipmentID;
                auditLog.Details = "Activate Equipment.";
                AuditLogBLL.AddNewAuditLog(auditLog);
            }
            return IsActivated;
        }

        public static bool DeactivateEquipment(int EquipmentID)
        {
            Equipment equipment = GetEquipmentByID(EquipmentID);
            if (equipment == null)
                throw new Exceptions.ValidationException("Please choose a valid Equipment");
            if (equipment.TotalQuantity != equipment.AvailableQuantity)
                throw new Exceptions.BusinessRuleException("There are borrowers who are using this equipment.");
            UserBLL.RequireUser();
            bool IsDeactivated= EquipmentDAL.DeactivateEquipment(EquipmentID);
            if (IsDeactivated)
            {
                AuditLog auditLog = new AuditLog();
                auditLog.UserID = Sessions.CurrentUser.ID;
                auditLog.ActionDate = DateTime.Now;
                Actions = eActions.Deactivate;
                auditLog.Action = Actions.ToString();
                auditLog.EntityType = EntityType;
                auditLog.EntityID = EquipmentID;
                auditLog.Details = "Deactivate Equipment.";
                AuditLogBLL.AddNewAuditLog(auditLog);
            }
            return IsDeactivated;
        }

        public static DataTable GetEquipments()
        {
            UserBLL.RequireUser();
            return EquipmentDAL.GetEquipments();
        }

        public static List<Equipment> GetEquipmentList()
        {
            UserBLL.RequireUser();
            return EquipmentDAL.GetEquipmentList();
        }

        public static bool IsActive(int ID)
        {
            return EquipmentDAL.IsActive(ID);
        }
    }
}