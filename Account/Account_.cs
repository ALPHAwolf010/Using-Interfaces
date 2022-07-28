using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Gen_App.Entities;
using CS_Gen_App.Hospital;
namespace CS_Gen_App.Account
{
    public abstract class Account_
    {
        public static Dictionary<int, object> Account_data = new Dictionary<int, object>();
        public int ac_id = 0;
        public double income = 0;
        public double GST_Tax = 0;
        public decimal TotalAmount = 0;
        public abstract double income_1(object val);
        public abstract double GST_1(object val);
        public abstract decimal TotalAmount_1(object val);

    }

    public class doc_Ac : Account_
    {
        public override double income_1(object s1)
        {
            var s2 = (Doctor)s1;
            double val = s2.Fees * s2.MaxPatientsPerDay * 30;
            double tax = val * (0.18);
            double tot = val - tax;
            return tot;
        }
        public override double GST_1(object s1)
        {
            var s2 = (Doctor)s1;
            double val = s2.Fees * s2.MaxPatientsPerDay * 30;
            double tax = val * (0.18);
            return tax;
        }
        public override decimal TotalAmount_1(object s1)
        {
            var s2 = (Doctor)s1;
            decimal val = s2.Fees * s2.MaxPatientsPerDay * 30;
            return val;
        }
    }
    public class nur_Ac : Account_
    {

        public override double income_1(object s1)
        {
            var s2 = (Nurse)s1;
            var bonas = (s2.Experiance < 2) ? 5000 : 10000;
            var val = s2.base_income + bonas;
            double tax = (double)val * (0.18);
            return (double)val - tax;
        }
        public override double GST_1(object s1)
        {
            var s2 = (Nurse)s1;
            var bonas = (s2.Experiance < 2) ? 5000 : 10000;
            var val = s2.base_income + bonas;
            double tax = (double)val * (0.18);
            return tax;
        }
        public override decimal TotalAmount_1(object s1)
        {
            var s2 = (Nurse)s1;
            var bonas = (s2.Experiance < 2) ? 5000 : 10000;
            var val = s2.base_income + bonas;
            return val;
        }

        public void display(object s1)
        {
            AccountLogic a1 = new AccountLogic();
            a1.display();
        }

    }
    public class tech_Ac : Account_
    {

        public override double income_1(object s1)
        {
            var s2 = (Technician)s1;
            var bonas = (s2.Experiance < 2) ? 5000 : 10000;
            var val = s2.base_income + bonas;
            double tax = (double)val * (0.18);
            return (double)val - tax;
        }
        public override double GST_1(object s1)
        {
            var s2 = (Technician)s1;
            var bonas = (s2.Experiance < 2) ? 5000 : 10000;
            var val = s2.base_income + bonas;
            double tax = (double)val * (0.18);
            return tax;
        }
        public override decimal TotalAmount_1(object s1)
        {
            var s2 = (Technician)s1;
            var bonas = (s2.Experiance < 2) ? 5000 : 10000;
            var val = s2.base_income + bonas;
            return val;
        }

        public void display(object s1)
        {
            AccountLogic a1 = new AccountLogic();
            a1.display();
        }

    }
}
