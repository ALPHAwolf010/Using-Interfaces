using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Logic
{
   
        public class TechLogic : StaffLogic<Technician, int>
        {

            void StaffLogic<Technician, int>.Create()
            {

                function_tec(1);
            }

            void StaffLogic<Technician, int>.Delete(int id)
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
            public static void RegisterStaff(Technician d1)
            {
                HospitalData.tech.Add(d1.StaffId, d1);
                HospitalData.store.Add(d1.StaffId, "Technician");
            }

            void StaffLogic<Technician, int>.Get(int id)
            {

                display(String.Empty, id);
            }

            Dictionary<int, Technician> StaffLogic<Technician, int>.GetAll()
            {
                display("ALL", int.MinValue);
                return HospitalData.tech;
            }

            void StaffLogic<Technician, int>.Update(int id)
            {
                function_tec(2);
            }


            public static void display_1(Technician d1)                                 // To display the given Doctor Object
            {
                Console.Write($"ID             :   {d1.StaffId}\n");
                Console.Write($"Name           :   {d1.StaffName}\n");
                Console.Write($"Email          :   {d1.Email}\n");
                Console.Write($"ContactNo      :   {d1.ContactNo}\n");
                Console.Write($"ShiftStartTime :   {d1.ShiftStartTime} \n");
                Console.Write($"ShiftEndTime   :   {d1.ShiftEndTime} \n");
                Console.Write($"AssignedRoom   :   {d1.AssignRoomNumber}\n");
                Console.Write($"Tech Type      :   {d1.Tech_Type}\n");
                Console.Write($"Experiance     :   {d1.Experiance} \n");
                
            }
        
            public void display(string str, int id)
            {
                foreach (var item in HospitalData.tech.Values)
                {
                    if (item.StaffId == id || str == "ALL")
                        display_1(item);
                }
            }
            public static Technician function_tec(int val)
            {
                Technician d3 = new Technician();
                int id_val = 0;

                Console.WriteLine("Enter ID :");
                id_val = Convert.ToInt32(Console.ReadLine());
                if (val == 1)
                {
                    d3.StaffId = id_val;
                }
                if (val == 2)
                {
                    if (HospitalData.store.ContainsKey(id_val))
                    {
                        HospitalData.store.Remove(id_val);
                        HospitalData.tech.Remove(id_val);
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
                Console.Write("Enter Tech Type :");
               d3.Tech_Type = (Console.ReadLine());
            Console.Write("Enter Experience :");
                d3.Experiance = Convert.ToInt32(Console.ReadLine());
                Account_ a1 = new tech_Ac();
                a1.ac_id = d3.StaffId;
                a1.income = a1.income_1(d3);
                a1.GST_Tax = a1.GST_1(d3);
                a1.TotalAmount = a1.TotalAmount_1(d3);
                AccountLogic.reg_account(d3.StaffId, a1);
                if (val == 1)
                    Console.WriteLine("\n\n SuccessFully Registered !!\n");
                else
                    Console.WriteLine("\n\n SuccessFully Updated !!\n");
                HospitalData.tech.Add(d3.StaffId, d3);
                HospitalData.store.Add(d3.StaffId, "Technician");
                return d3;

            }
        }
    }

