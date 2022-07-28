using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Gen_App.Entities;
using CS_Gen_App.Hospital;
namespace CS_Gen_App.Logic
{
    public class NurseLogic : StaffLogic<Nurse, int>
    {
       
            void StaffLogic<Nurse, int>.Create()
            {

                function_nur(1);
            }

            void StaffLogic<Nurse, int>.Delete(int id)
            {
                if (HospitalData.doc.ContainsKey(id))
                {
                    HospitalData.doc.Remove(id);
                    HospitalData.store.Remove(id);
                HospitalData.depart.Remove(id);
                HospitalData.AccData.Remove(id);
            }
                else
                {
                    Console.WriteLine("\nWrong ID !!\n");
                }

            }
        public static void RegisterStaff(Nurse d1)
        {
            HospitalData.nur.Add(d1.StaffId, d1);
            HospitalData.store.Add(d1.StaffId, "Nurse");
        }

        void StaffLogic<Nurse, int>.Get(int id)
            {

                display(String.Empty, id);
            }

            Dictionary<int, Nurse> StaffLogic<Nurse, int>.GetAll()
            {
                display("ALL", int.MinValue);
                return HospitalData.nur;
            }

            void StaffLogic<Nurse, int>.Update(int id)
            {
                function_nur(2);
            }
        public static void display_1(Nurse d1)
        {
            Console.Write($"ID :                {d1.StaffId}\n");
            Console.Write($"Name :              {d1.StaffName}\n");
            Console.Write($"Email :             {d1.Email}\n");
            Console.Write($"ContactNo :         {d1.ContactNo}\n");
            Console.Write($"ShiftStartTime :    {d1.ShiftStartTime} \n");
            Console.Write($"ShiftEndTime :      {d1.ShiftEndTime} \n");
            Console.Write($"AssignedRoom :      {d1.AssignRoomNumber}\n");
            Console.Write($"Experiance        : {d1.Experiance} \n");
            Console.Write($"MoniterDetails    : {d1.MoniterDetails}\n");
            Console.Write($"Base Income       : {d1.base_income}");

        }
        public void display(string str, int id)
        {
            foreach (var item in HospitalData.nur.Values)
            {
                if (item.StaffId == id || str == "ALL")
                    display_1(item);
            }
        }
        public static Nurse function_nur(int val)
        {
            Nurse d3 = new Nurse();
            int id_val = 0;

            Console.WriteLine("Enter ID :");
            id_val = Convert.ToInt32(Console.ReadLine());
            if (val == 1)
            {
                d3.StaffId = id_val;
            }
            if (val ==2)
            {
                if (HospitalData.store.ContainsKey(id_val))
                {
                    HospitalData.store.Remove(id_val);
                    HospitalData.nur.Remove(id_val);
                    d3.StaffId = id_val;
                }
                else
                {
                    Console.WriteLine("Wrong ID \n");
                    return null;
                }
            }
            Console.Write("Enter Name :");
            d3.StaffName = Console.ReadLine();
            Console.Write("Enter Email :");
            d3.Email = Console.ReadLine();
            Console.Write("Enter ContactNo :");
            d3.ContactNo = Console.ReadLine();
            Console.Write("Enter ShiftStartTime :");
            d3.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter ShiftEndTime :");
            d3.ShiftEndTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter AssignedRoom :");
            d3.AssignRoomNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Experience :");
            d3.Experiance = Convert.ToInt32(Console.ReadLine());
            Console.Write("MoniterDetils :");
            d3.MoniterDetails = Console.ReadLine();
            Account_ a1 = new nur_Ac();
            a1.ac_id = d3.StaffId;
            a1.income = a1.income_1(d3);
            a1.GST_Tax = a1.GST_1(d3);
            a1.TotalAmount = a1.TotalAmount_1(d3);
            AccountLogic.reg_account(d3.StaffId, a1);
            if (val == 1)
                Console.WriteLine("\n\n SuccessFully Registered !!\n");
            else
                Console.WriteLine("\n\n SuccessFully Updated !!\n");
            HospitalData.nur.Add(d3.StaffId, d3);
            HospitalData.store.Add(d3.StaffId, "Nurse");
            return d3;

        }
    }
    }
