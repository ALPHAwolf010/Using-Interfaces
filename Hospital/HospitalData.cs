using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CS_Gen_App.Entities;
using CS_Gen_App.Logic;
using CS_Gen_App.Models;
namespace CS_Gen_App.Hospital
{
    public  class HospitalData
    {
        public static Dictionary<int,Doctor>doc=new Dictionary<int,Doctor>();
        public static Dictionary<int, Nurse>nur = new Dictionary<int, Nurse>();
        public static Dictionary<int, Technician>tech= new Dictionary<int, Technician>();
        public static Dictionary<int, Object>AccData = new Dictionary<int, Object>();
         public static Dictionary<int,string>store =new Dictionary<int,string>();
        public static Dictionary<int, Depart> depart = new Dictionary<int, Depart>();

    }
}
