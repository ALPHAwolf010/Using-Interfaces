using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Gen_App.Entities;
using CS_Gen_App.Hospital;
using CS_Gen_App.Account;
namespace CS_Gen_App.Logic
{
    public class DoctorLogic : StaffLogic<Doctor, int>
    {
        void StaffLogic<Doctor, int>.Create()
        {

            function_doc(1);
        }

        void StaffLogic<Doctor, int>.Delete(int id)
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
         void  StaffLogic<Doctor, int>.Get(int id)
        {
            display(String.Empty, id);
        }

        Dictionary<int,Doctor> StaffLogic<Doctor, int>.GetAll()
        {
            display("ALL",int.MinValue);
           return HospitalData.doc;
        }

       void  StaffLogic<Doctor, int>.Update(int id)
        {
            function_doc(2);
        }
        public static void RegisterStaff(Doctor d1)
        {
            HospitalData.doc.Add(d1.StaffId, d1);
            HospitalData.store.Add(d1.StaffId,"Doctor");
        }
        public void  function_doc(int val)
        {
            Doctor d3 = new Doctor();
            int id_val = 0;
            Console.Write("\n\nEnter ID : ");
            id_val = Convert.ToInt32(Console.ReadLine());
            if (val == 1)
            {
                d3.StaffId = id_val;
            }

            if (val==2)
            {
                if (HospitalData.store.ContainsKey(id_val))
                {
                    HospitalData.store.Remove(id_val);
                    HospitalData.AccData.Remove(id_val);
                    HospitalData.doc.Remove(id_val);
                    d3.StaffId = id_val;
                }
                else
                {
                    Console.WriteLine("Wrong ID \n");
                    return;
                }
            }
            Console.Write("Enter Name : ");
            d3.StaffName = Console.ReadLine();
            Console.Write("Enter Email : ");
            d3.Email = Console.ReadLine();
            Console.Write("Enter ContactNo : ");
            d3.ContactNo = Console.ReadLine();
            Console.Write("Enter ShiftStartTime : ");
            d3.ShiftStartTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter ShiftEndTime : ");
            d3.ShiftEndTime = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Specializaton : ");
            d3.Specilization = Console.ReadLine();
            Console.Write("Enter Education : ");
            d3.Education = Console.ReadLine();
            Console.Write("Enter Fees : ");
            d3.Fees = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter MaxPatientsPerDay : ");
            d3.MaxPatientsPerDay = Convert.ToInt32(Console.ReadLine());
            Account_ a1 = new doc_Ac();
            a1.ac_id = d3.StaffId;
            a1.income = a1.income_1(d3);
            a1.GST_Tax = a1.GST_1(d3);
            a1.TotalAmount = a1.TotalAmount_1(d3);
            Depart dp = new Depart();
            dp.ID = d3.StaffId;
            dp.staff_name = d3.StaffName;
            Console.Write("Enter Location : ");
            dp.dp_locat = Console.ReadLine();

            dp.dp_type = d3.Specilization;
            HospitalData.depart.Add(dp.ID, dp);
            HospitalData.store.Add(d3.StaffId, "Doctor");
            HospitalData.doc.Add(d3.StaffId, d3);
            AccountLogic.reg_account(d3.StaffId, a1);
            Console.WriteLine("\n\n SuccessFully Registered !!\n");
            

        }
        public  void display(string str,int id)
        {
            foreach(var item in HospitalData.doc.Values)
            {
                if (item.StaffId == id || str == "ALL")
                    display_1(item);

            }
        }
        public static void display_1(Doctor d1)
        {
            Console.Write($"ID :                {d1.StaffId}\n");
            Console.Write($"Name :              {d1.StaffName}\n");
            Console.Write($"Email :             {d1.Email}\n");
            Console.Write($"ContactNo :         {d1.ContactNo}\n");
            Console.Write($"ShiftStartTime :    {d1.ShiftStartTime} \n");
            Console.Write($"ShiftEndTime :      {d1.ShiftEndTime} \n");
            Console.Write($"Specializaton :     {d1.Specilization} \n");
            Console.Write($"Education :         {d1.Education} \n");
            Console.Write($"Fees :              {d1.Fees} \n");
            Console.Write($"MaxPatientsPerDay : {d1.MaxPatientsPerDay} \n");

        }
    }
}
