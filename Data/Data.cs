using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Gen_App.Logic;
using CS_Gen_App.Models;
using CS_Gen_App.Department;
using CS_Gen_App.Search;
using CS_Gen_App.Data;
namespace CS_Gen_App.Data
{
    public class Data
    {
        public Data()
        {
            StaffLogic<Doctor, int> logic = new DoctorLogic();
            StaffLogic<Nurse, int> ob2 = new NurseLogic();

            Doctor d1 = new Doctor()
            {
                StaffId = 1012,
                StaffName = "Dr. No",
                Email = "adsf@gmail.com",
                ContactNo = "234345",
                ShiftStartTime = 3,
                ShiftEndTime = 5,
                Education = "M.B.B.S",
                Specilization = "Eye",
                Fees = 340,
                MaxPatientsPerDay = 23,

            };
            DoctorLogic.RegisterStaff(d1);Account_ a1 = new doc_Ac();a1.ac_id = d1.StaffId;a1.income = a1.income_1(d1);a1.GST_Tax = a1.GST_1(d1);a1.TotalAmount = a1.TotalAmount_1(d1);Depart dp = new Depart();
            dp.ID = d1.StaffId;dp.staff_name = d1.StaffName;dp.dp_locat = "Pune";dp.dp_type = d1.Specilization;HospitalData.depart.Add(dp.ID, dp);AccountLogic.reg_account(d1.StaffId, a1);
            
            d1 = new Doctor()
            {
                StaffId = 1212,
                StaffName = "Alpha",
                Email = "adeee@gmail.com",
                ContactNo = "924345",
                ShiftStartTime = 4,
                ShiftEndTime = 8,
                Education = "M.B.B.S",
                Specilization = "Heart",
                Fees = 340,
                MaxPatientsPerDay = 27,
            };
            DoctorLogic.RegisterStaff(d1);  a1 = new doc_Ac(); a1.ac_id = d1.StaffId; a1.income = a1.income_1(d1); a1.GST_Tax = a1.GST_1(d1); a1.TotalAmount = a1.TotalAmount_1(d1);  dp = new Depart();
            dp.ID = d1.StaffId; dp.staff_name = d1.StaffName; dp.dp_locat = "Pune"; dp.dp_type = d1.Specilization; HospitalData.depart.Add(dp.ID, dp); AccountLogic.reg_account(d1.StaffId, a1); 


            ob2 = new NurseLogic();
            Nurse n1 = new Nurse()
            {
                StaffId = 1524,
                StaffName = "DoLittle",
                Email = "sddddf@gmail.com",
                ContactNo = "924345",
                ShiftStartTime = 3,
                ShiftEndTime = 9,
                AssignRoomNumber = 45,
                Experiance = 3,
                MoniterDetails = "Normal",
            };

NurseLogic.RegisterStaff(n1);a1 = new nur_Ac();a1.ac_id = n1.StaffId;a1.income = a1.income_1(n1);a1.GST_Tax = a1.GST_1(n1);a1.TotalAmount = a1.TotalAmount_1(n1);AccountLogic.reg_account(n1.StaffId, a1);

            Technician t1 = new Technician()
            {
                StaffId = 1026,
                StaffName = "Beta",
                Email = "sddddf@gmail.com",
                ContactNo = "924345",
                ShiftStartTime = 3,
                ShiftEndTime = 9,
                AssignRoomNumber = 45,
                Experiance = 3,
               Tech_Type="Water",
            };

            TechLogic.RegisterStaff(t1); a1 = new tech_Ac(); a1.ac_id = t1.StaffId; a1.income = a1.income_1(t1); a1.GST_Tax = a1.GST_1(t1); a1.TotalAmount = a1.TotalAmount_1(t1); AccountLogic.reg_account(t1.StaffId, t1);

            t1 = new Technician()
            {
                StaffId = 1538,
                StaffName = "Beta",
                Email = "sddddf@gmail.com",
                ContactNo = "924345",
                ShiftStartTime = 3,
                ShiftEndTime = 9,
                AssignRoomNumber = 45,
                Experiance = 3,
                Tech_Type="Water",
            };

            TechLogic.RegisterStaff(t1); a1 = new tech_Ac(); a1.ac_id = t1.StaffId; a1.income = a1.income_1(t1); a1.GST_Tax = a1.GST_1(t1); a1.TotalAmount = a1.TotalAmount_1(t1); AccountLogic.reg_account(t1.StaffId, t1);

             n1 = new Nurse()
            {
                StaffId = 3277,
                StaffName = "Meena",
                Email = "sqwef@gmail.com",
                ContactNo = "92234345",
                ShiftStartTime = 1,
                ShiftEndTime = 7,
                AssignRoomNumber = 43,
                Experiance = 5,
                MoniterDetails = "Normal",
            };

            NurseLogic.RegisterStaff(n1); a1 = new nur_Ac(); a1.ac_id = n1.StaffId; a1.income = a1.income_1(n1); a1.GST_Tax = a1.GST_1(n1); a1.TotalAmount = a1.TotalAmount_1(n1); AccountLogic.reg_account(n1.StaffId, a1);



            n1 = new Nurse()
            {
                StaffId = 9099,
                StaffName = "Alex",
                Email = "qwer@gmail.com",
                ContactNo = "92234345",
                ShiftStartTime = 1,
                ShiftEndTime = 9,
                AssignRoomNumber = 07,
                Experiance = 5,
                MoniterDetails = "Fever",
            };

            NurseLogic.RegisterStaff(n1); a1 = new nur_Ac(); a1.ac_id = n1.StaffId; a1.income = a1.income_1(n1); a1.GST_Tax = a1.GST_1(n1); a1.TotalAmount = a1.TotalAmount_1(n1); AccountLogic.reg_account(n1.StaffId, a1);


            n1 = new Nurse()
            {
                StaffId = 9011,
                StaffName = "Shruti",
                Email = "qwerrty@gmail.com",
                ContactNo = "922223566",
                ShiftStartTime = 1,
                ShiftEndTime = 10,
                AssignRoomNumber = 07,
                Experiance = 2,
                MoniterDetails = "Fever",
            };

            NurseLogic.RegisterStaff(n1); a1 = new nur_Ac(); a1.ac_id = n1.StaffId; a1.income = a1.income_1(n1); a1.GST_Tax = a1.GST_1(n1); a1.TotalAmount = a1.TotalAmount_1(n1); AccountLogic.reg_account(n1.StaffId, a1);


            n1 = new Nurse()
            {
                StaffId = 1903,
                StaffName = "Rose",
                Email = "qwrio@gmail.com",
                ContactNo = "23234345",
                ShiftStartTime = 3,
                ShiftEndTime = 9,
                AssignRoomNumber = 07,
                Experiance = 1,
                MoniterDetails = "Normal",
            };

            NurseLogic.RegisterStaff(n1); a1 = new nur_Ac(); a1.ac_id = n1.StaffId; a1.income = a1.income_1(n1); a1.GST_Tax = a1.GST_1(n1); a1.TotalAmount = a1.TotalAmount_1(n1); AccountLogic.reg_account(n1.StaffId, a1);

            d1 = new Doctor()
            {
                StaffId = 1092,
                StaffName = "Dr.Mayank",
                Email = "adeeer@gmail.com",
                ContactNo = "924345",
                ShiftStartTime = 4,
                ShiftEndTime = 9,
                Education = "M.B.B.S",
                Specilization = "Cancer",
                Fees = 300,
                MaxPatientsPerDay = 17,
            };
            DoctorLogic.RegisterStaff(d1); a1 = new doc_Ac(); a1.ac_id = d1.StaffId; a1.income = a1.income_1(d1); a1.GST_Tax = a1.GST_1(d1); a1.TotalAmount = a1.TotalAmount_1(d1); dp = new Depart();
            dp.ID = d1.StaffId; dp.staff_name = d1.StaffName; dp.dp_locat = "Mumbai"; dp.dp_type = d1.Specilization; HospitalData.depart.Add(dp.ID, dp); AccountLogic.reg_account(d1.StaffId, a1);
           
            d1 = new Doctor()
            {
                StaffId = 1197,
                StaffName = "Dr.Peter",
                Email = "dhfghj@gmail.com",
                ContactNo = "924345",
                ShiftStartTime = 3,
                ShiftEndTime = 9,
                Education = "M.B.B.S",
                Specilization = "Eye",
                Fees = 250,
                MaxPatientsPerDay = 28,
            };
            DoctorLogic.RegisterStaff(d1); a1 = new doc_Ac(); a1.ac_id = d1.StaffId; a1.income = a1.income_1(d1); a1.GST_Tax = a1.GST_1(d1); a1.TotalAmount = a1.TotalAmount_1(d1); dp = new Depart();
            dp.ID = d1.StaffId; dp.staff_name = d1.StaffName; dp.dp_locat = "Nagpur"; dp.dp_type = d1.Specilization; HospitalData.depart.Add(dp.ID, dp); AccountLogic.reg_account(d1.StaffId, a1);
           
            d1 = new Doctor()
            {
                StaffId = 1139,
                StaffName = "Dr. Mohit",
                Email = "dhfghrtj@gmail.com",
                ContactNo = "924345",
                ShiftStartTime = 3,
                ShiftEndTime = 5,
                Education = "M.B.B.S",
                Specilization = "Heart",
                Fees = 250,
                MaxPatientsPerDay = 28,
            };
            DoctorLogic.RegisterStaff(d1); a1 = new doc_Ac(); a1.ac_id = d1.StaffId; a1.income = a1.income_1(d1); a1.GST_Tax = a1.GST_1(d1); a1.TotalAmount = a1.TotalAmount_1(d1); dp = new Depart();
            dp.ID = d1.StaffId; dp.staff_name = d1.StaffName; dp.dp_locat = "Nagpur"; dp.dp_type = d1.Specilization; HospitalData.depart.Add(dp.ID, dp); AccountLogic.reg_account(d1.StaffId, a1);

            d1 = new Doctor()
            {
                StaffId = 1731,
                StaffName = "Dr. Komal",
                Email = "dhfghrtj@gmail.com",
                ContactNo = "924345",
                ShiftStartTime = 3,
                ShiftEndTime = 5,
                Education = "M.B.B.S",
                Specilization = "Dental",
                Fees = 250,
                MaxPatientsPerDay = 28,
            };
            DoctorLogic.RegisterStaff(d1); a1 = new doc_Ac(); a1.ac_id = d1.StaffId; a1.income = a1.income_1(d1); a1.GST_Tax = a1.GST_1(d1); a1.TotalAmount = a1.TotalAmount_1(d1); dp = new Depart();
            dp.ID = d1.StaffId; dp.staff_name = d1.StaffName; dp.dp_locat = "Nagpur"; dp.dp_type = d1.Specilization; HospitalData.depart.Add(dp.ID, dp); AccountLogic.reg_account(d1.StaffId, a1);

            d1 = new Doctor()
            {
                StaffId = 1933,
                StaffName = "Dr. Komal",
                Email = "dhfghrtj@gmail.com",
                ContactNo = "924345",
                ShiftStartTime = 3,
                ShiftEndTime = 5,
                Education = "M.B.B.S",
                Specilization = "Orthopeic",
                Fees = 380,
                MaxPatientsPerDay = 31,
            };
            DoctorLogic.RegisterStaff(d1); a1 = new doc_Ac(); a1.ac_id = d1.StaffId; a1.income = a1.income_1(d1); a1.GST_Tax = a1.GST_1(d1); a1.TotalAmount = a1.TotalAmount_1(d1); dp = new Depart();
            dp.ID = d1.StaffId; dp.staff_name = d1.StaffName; dp.dp_locat = "Bhopal"; dp.dp_type = d1.Specilization; HospitalData.depart.Add(dp.ID, dp); AccountLogic.reg_account(d1.StaffId, a1);
           
            d1 = new Doctor()
            {
                StaffId = 1363,
                StaffName = "Dr. Ankur",
                Email = "dhfghrtjer@gmail.com",
                ContactNo = "92434557",
                ShiftStartTime = 1,
                ShiftEndTime = 6,
                Education = "M.B.B.S",
                Specilization = "Radiology",
                Fees = 350,
                MaxPatientsPerDay = 29,
            };
            DoctorLogic.RegisterStaff(d1); a1 = new doc_Ac(); a1.ac_id = d1.StaffId; a1.income = a1.income_1(d1); a1.GST_Tax = a1.GST_1(d1); a1.TotalAmount = a1.TotalAmount_1(d1); dp = new Depart();
            dp.ID = d1.StaffId; dp.staff_name = d1.StaffName; dp.dp_locat = "Pune"; dp.dp_type = d1.Specilization; HospitalData.depart.Add(dp.ID, dp); AccountLogic.reg_account(d1.StaffId, a1);

            d1 = new Doctor()
            {
                StaffId = 1288,
                StaffName = "Dr. Ankur",
                Email = "dhfghrtjer@gmail.com",
                ContactNo = "92434557",
                ShiftStartTime = 1,
                ShiftEndTime = 6,
                Education = "M.B.B.S",
                Specilization = "Orthopeic",
                Fees = 390,
                MaxPatientsPerDay = 24,
            };
            DoctorLogic.RegisterStaff(d1); a1 = new doc_Ac(); a1.ac_id = d1.StaffId; a1.income = a1.income_1(d1); a1.GST_Tax = a1.GST_1(d1); a1.TotalAmount = a1.TotalAmount_1(d1); dp = new Depart();
            dp.ID = d1.StaffId; dp.staff_name = d1.StaffName; dp.dp_locat = "Pune"; dp.dp_type = d1.Specilization; HospitalData.depart.Add(dp.ID, dp); AccountLogic.reg_account(d1.StaffId, a1);


            t1 = new Technician()
            {
                StaffId = 1514,
                StaffName = "Beta",
                Email = "sddddf@gmail.com",
                ContactNo = "924345",
                ShiftStartTime = 3,
                ShiftEndTime = 9,
                AssignRoomNumber = 45,
                Experiance = 3,
                Tech_Type="Electricity"
            };

            TechLogic.RegisterStaff(t1); a1 = new tech_Ac(); a1.ac_id = t1.StaffId; a1.income = a1.income_1(t1); a1.GST_Tax = a1.GST_1(t1); a1.TotalAmount = a1.TotalAmount_1(t1); AccountLogic.reg_account(t1.StaffId, t1);

            t1 = new Technician()
            {
                StaffId = 1527,
                StaffName = "Beta",
                Email = "sdddf@gmail.com",
                ContactNo = "924345",
                ShiftStartTime = 3,
                ShiftEndTime = 9,
                AssignRoomNumber = 21,
                Experiance = 3,
                Tech_Type = "Water"
            };

            TechLogic.RegisterStaff(t1); a1 = new tech_Ac(); a1.ac_id = t1.StaffId; a1.income = a1.income_1(t1); a1.GST_Tax = a1.GST_1(t1); a1.TotalAmount = a1.TotalAmount_1(t1); AccountLogic.reg_account(t1.StaffId, t1);


            t1 = new Technician()
            {
                StaffId = 1024,
                StaffName = "Mohit",
                Email = "sddddf@gmail.com",
                ContactNo = "924345",
                ShiftStartTime = 3,
                ShiftEndTime = 9,
                AssignRoomNumber = 09,
                Experiance = 3,
                Tech_Type = "Building",
            };

            TechLogic.RegisterStaff(t1); a1 = new tech_Ac(); a1.ac_id = t1.StaffId; a1.income = a1.income_1(t1); a1.GST_Tax = a1.GST_1(t1); a1.TotalAmount = a1.TotalAmount_1(t1); AccountLogic.reg_account(t1.StaffId, t1);

        }
    }
}

