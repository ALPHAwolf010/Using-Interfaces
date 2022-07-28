using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Gen_App.Account;
using CS_Gen_App.Hospital;
using CS_Gen_App.Logic;
using CS_Gen_App.Entities;
namespace CS_Gen_App.Models
{
    public class AccountLogic
    {
        public static void reg_account(int id, object s1)
        {

            HospitalData.AccData.Add(id,s1);
        }
        public void display()
        {
            Console.WriteLine("\n\n----------------Account Department-------------- \n");
            Console.Write("\nEnter the ID  :");
            var val_ID = Convert.ToInt32(Console.ReadLine());

            if (HospitalData.AccData.ContainsKey(val_ID))
            {

                if (HospitalData.store[val_ID] == "Doctor")
                {
                    var ob = (doc_Ac)HospitalData.AccData[val_ID];
                    Console.WriteLine($"\nAccount ID    :  {ob.ac_id}");
                    Console.WriteLine($"GST Deduction : Rs.{ob.GST_Tax}");
                    Console.WriteLine($"Income        : Rs.{ob.income}");
                    Console.WriteLine($"Total Income  : Rs.{ob.TotalAmount}");
                }
               else if (HospitalData.store[val_ID] == "Nurse")
                {
                    var ob = (nur_Ac)HospitalData.AccData[val_ID];
                    Console.WriteLine($"\nAccount ID    : {ob.ac_id}");
                    Console.WriteLine($"GST Deduction : Rs.{ob.GST_Tax}");
                    Console.WriteLine($"Income        : Rs.{ob.income}");
                    Console.WriteLine($"Total Income  : Rs.{ob.TotalAmount}\n");
                }
               else if (HospitalData.store[val_ID] == "Technician")
                {
                    var ob = (tech_Ac)HospitalData.AccData[val_ID];
                    Console.WriteLine($"\nAccount ID    : {ob.ac_id}");
                    Console.WriteLine($"GST Deduction : Rs.{ob.GST_Tax}");
                    Console.WriteLine($"Income        : Rs.{ob.income}");
                    Console.WriteLine($"Total Income  : Rs.{ob.TotalAmount}\n");
                }

            }
            else
                Console.WriteLine("\nWrong ID ...!!\n\n");

            return;
        }
    }
}
