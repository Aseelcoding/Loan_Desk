using DAL;
using LoanDesk.Models;
using System.Collections.Generic;
using System.Data;

namespace BLL
{
    public class EquipmentBLL
    {
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

            return EquipmentDAL.AddEquipment(NewEquipment);
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
            return EquipmentDAL.UdpateEquipment(NewEquipment);
        }

        public static Equipment GetEquipmentByID(int EquipmentID)
        {
            return EquipmentDAL.GetEquipmentByID(EquipmentID);
        }

        public static bool ActivateEquipment(int EquipmentID)
        {
            UserBLL.RequireUser();
            return EquipmentDAL.ActivateEquipment(EquipmentID);
        }

        public static bool DeactivateEquipment(int EquipmentID)
        {
            Equipment equipment = GetEquipmentByID(EquipmentID);
            if (equipment == null)
                throw new Exceptions.ValidationException("Please choose a valid Equipment");
            if (equipment.TotalQuantity != equipment.AvailableQuantity)
                throw new Exceptions.BusinessRuleException("There are borrowers who are using this equipment.");
            UserBLL.RequireUser();
            return EquipmentDAL.DeactivateEquipment(EquipmentID);
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