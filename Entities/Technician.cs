using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Gen_App.Entities
{
    public class Technician : Staff
    {
        private int _AssignRoomNumber = 0;
        public int AssignRoomNumber
        {
            get { return _AssignRoomNumber; }
            set
            {
                _AssignRoomNumber = value;

            }
        }

        private string _Tech_Type = String.Empty;
        public string Tech_Type
        {
            get { return _Tech_Type; }
            set
            {
                _Tech_Type = value;

            }
        }
        protected int _Experiance = 0;
        public int Experiance
        {
            get { return _Experiance; }
            set
            {
                _Experiance = value;

            }
        }
        public decimal base_income = 12000;
       

        
    }
}
