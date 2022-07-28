// See https://aka.ms/new-console-template for more information
using CS_Gen_App.Hospital;
using CS_Gen_App.Entities;
using CS_Gen_App.Logic;
//using CS_Gen_App.Models;

StaffLogic<Doctor,int>ob1 = new DoctorLogic();
StaffLogic<Nurse, int> ob2 = new NurseLogic();
//taffLogic<Doctor, int> ob1 = new DoctorLogic();
AccountLogic acc = new AccountLogic();
Search s1 = new Search();
Data d_ = new Data();
void fun_doc(int val_1)
{
    Doctor d1 = new Doctor();
    int id = 0;

    
    if (val_1!=1)
    {
        Console.Write("\nEnter ID :");
        id = Convert.ToInt32(Console.ReadLine());
    }
    switch (val_1)
    {
       
        case 1:
               
             ob1.Create();
             break;
        case 2:
            ob1.Update(id);
            break;
        case 3:
            ob1.Delete(id);
            break;
       
        default:
            Console.WriteLine("\nWrong Input !!\n");
            break;
    }
    
    
    
}

void fun_nur(int val_1)
{
    Nurse d1 = new Nurse();
    int id = 0;
    if (val_1 != 1)
    {
        Console.Write("\nEnter ID");
        id = Convert.ToInt32(Console.ReadLine());
    }
    switch (val_1)
    {

        case 1:

            ob2.Create();
            break;
        case 2:
            ob2.Update(id);
            break;
        case 3:
            ob2.Delete(id);
            break;
        default:
            Console.WriteLine("\nWrong Input !!\n");
            break;
    }


}
char ch = 'Y';
do
{
    Console.WriteLine("\n\nDoctor     Opearation  Enter 1 :");
    Console.WriteLine("Nurse      Opearation  Enter 2 : ");
    Console.WriteLine("Technician Opearation  Enter 3 : ");
    Console.WriteLine("Search     Operation   ENter 4 : ");
    Console.WriteLine("Account Details        Enter 5 : ");
    
    Console.Write("\n\nEnter : ");
    int val = Convert.ToInt32(Console.ReadLine());
    int val_ = 0;
    if (val >= 1 && val <= 3)
    {
        Console.WriteLine("\n\nEnter New Record   Enter 1 : ");
        Console.WriteLine("Update Record      Enter 2 : ");
        Console.WriteLine("Remove Record      Enter 3 : ");
        Console.Write("\n\nEnter : ");
        val_ = Convert.ToInt32(Console.ReadLine());


        if (val == 1)
        {
            fun_doc(val_);
        }
        else if (val == 2)
        {
            fun_nur(val_);
        }
        else
            Console.WriteLine("\nWrong Input !!");
    }
    else if (val > 3 && val <= 5)
    {
        if (val == 4)
        {
            s1.search_op();
        }
        else if (val == 5)
        {
            acc.display();
        }

        
    }
    else
        Console.WriteLine("\n\tWrong Input !!\n");

     
    }
    while (ch == 'y' || ch == 'Y');


