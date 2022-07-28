using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Search
{
    public class Search
    {

        public bool search_valid(int id)
        {

            bool flag = (HospitalData.store.ContainsKey(id)) ? true : false;
            return flag;
        }
        public void fun_all(string str)
        {
            int count = 0;
            Console.WriteLine("\n---------DOCTOR DATA ---------\n");
            foreach (var item in HospitalData.doc.Values)
            {
                if (item.StaffName == str || str == "ALL")
                {
                    count++;
                    Console.WriteLine("\n");
                    DoctorLogic.display_1(item);
                }
            }
            if (count == 0)
            { Console.WriteLine("NO DATA FOUND \n"); }
            count = 0;
            Console.WriteLine("\n---------NURSE DATA ---------\n");
            foreach (var item in HospitalData.nur.Values)
            {
                if (item.StaffName == str || str == "ALL")
                {
                    count++;
                    Console.WriteLine("\n");
                    NurseLogic.display_1(item);
                }
            }
            if (count == 0)
                Console.WriteLine("NO DATA FOUND \n");
            count = 0;
            Console.WriteLine("\n---------TECHNICIAN DATA ---------\n");
            foreach (var item in HospitalData.tech.Values)
            {
                if (item.StaffName == str || str == "ALL")
                {
                    count++;
                    Console.WriteLine("\n");
                    TechLogic.display_1(item);
                }
            }
            if (count == 0)
                Console.WriteLine("NO DATA FOUND \n");
            Console.WriteLine("\n\n");
        }
                


            
            
        
        public void search_city(string str)
        {
            int count = 0;
            foreach (var item in HospitalData.depart.Values)
            {


                if(item.dp_locat==str)
                {
                    if (count == 0)
                    { Console.WriteLine($"\n Doctors From {str} :-\n"); count++; }
                    Console.WriteLine("\n");
                    DoctorLogic.display_1(HospitalData.doc[item.ID]);
                }

            }
            if (count == 0)
                Console.WriteLine("\nNo Data Found !!\n");
        }
        public void function_doc(int val_1, string str, int ID_val)
        {
            string str_ALL = String.Empty;
            string str_Edu = String.Empty;
            string str_Sp = String.Empty;
            int count = 0;
            if (ID_val == int.MinValue)
            {
                if (val_1 == 3)
                    str_ALL = "ALL";
                else if (val_1 == 4)
                {
                    Console.Write("Enter Search Eduction : ");
                    str_Edu = Console.ReadLine();
                }
                else if (val_1 == 5)
                {
                    Console.Write("Enter Search Specilization : ");
                    str_Sp = Console.ReadLine();
                }

                foreach (var item in HospitalData.doc.Values)
                {
                    
                      if (item.Education == str_Edu || item.Specilization == str_Sp || item.StaffName == str || item.StaffId == ID_val)
                        {
                            DoctorLogic.display_1(item); count++;
                            Console.WriteLine("\n\n");
                        }
                }
                if(str!=String.Empty)
                {
                   foreach (var item in HospitalData.nur.Values)
                    {

                        if (item.StaffName == str)
                        {
                            NurseLogic.display_1(item); count++;
                            Console.WriteLine("\n\n");
                        }
                    }

                }

                }
            }


        
        public void search_op()                 /// Search Operation 
        {
            char ch = 'y';
            do
            {
                Console.WriteLine("\n\nSearch ID                       : Enter  1");
                Console.WriteLine("Search By Name                  : Enter  2");
                Console.WriteLine("Search All Doctor               : Enter  3");
                Console.WriteLine("Search Doctor By Education      : Enter  4");
                Console.WriteLine("Search Doctor by Specialization : Enter  5");
                Console.WriteLine("Show ALL Data                   : Enter  6");
                Console.WriteLine("Search Doctor By Location       : Enter  7");
                Console.Write("\n\nEnter  : ");
                var val_1 = Convert.ToInt32(Console.ReadLine());


                if (val_1 <= 0 || val_1 > 7)
                {
                    Console.WriteLine("Wrong Input !!\n");
                }
                else
                {
                    if (val_1 == 1)
                    {
                        Console.WriteLine("Enter Search ID :");
                        var s_ID = Convert.ToInt32(Console.ReadLine());
                        if (search_valid(s_ID))
                        {
                            Console.WriteLine($"ID Belongs to : {HospitalData.store[s_ID]}\n");
                            function_doc(1, String.Empty, s_ID);
                        }
                        else
                            Console.WriteLine("\nWrong Input !!\n");
                    }
                    else if (val_1 == 3 || val_1 == 4 || val_1 == 5)
                    {
                        string str = String.Empty;
                        function_doc(val_1, str, int.MinValue);
                    }
                    else if (val_1 == 2)
                    {
                        Console.Write("Enter Search Name : ");
                        string str_s = Console.ReadLine();

                        fun_all(str_s);
                    }
                    else if (val_1 == 6)
                    {
                        fun_all("ALL");
                    }
                    else if (val_1 == 7)
                    {
                        Console.Write("\nEnter the Location :");
                        string str = Console.ReadLine();
                        search_city(str);
                    }
                }

                Console.WriteLine("\nTo Continue Press Y or y !!\n");
                ch = Console.ReadLine()[0];
            } while (ch == 'y' || ch == 'Y');
        }
    }
}
