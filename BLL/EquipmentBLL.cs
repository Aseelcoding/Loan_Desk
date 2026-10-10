using DAL;
using LoanDesk.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilities;

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
            if (equipment_1!=null&&equipment_1.ID != NewEquipment.ID)
                throw new Exceptions.BusinessRuleException("Duplicate equipment name.");

        }
        public static bool AddEquipment(Equipment NewEquipment)
        {
            IsEquipmentNameIsTaken(NewEquipment);
            CheckEquipment(NewEquipment);



            return EquipmentDAL.AddEquipment(NewEquipment);
        }

        public static Equipment GetEquipmentByID(int EquipmentID)
        {
            return EquipmentDAL.GetEquipmentByID(EquipmentID);
        }

        public static DataTable GetEquipments()
        {
            return EquipmentDAL.GetEquipments();
        }
    }
}