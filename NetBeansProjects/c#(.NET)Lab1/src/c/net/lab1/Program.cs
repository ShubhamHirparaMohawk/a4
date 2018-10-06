using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// name and student number: Shubham Hirpara, 000770045
///file date: 21st september, 2018
///The program's purpose: read data from file and manipulate it.
///Statement of Authorship: I, Shubham Hirpara, student number 000770045, certify that all code submitted is my own work; that I have not copied it from any other source.
/// I also certify that I have not allowed my work to be copied by others.
/// </summary>
namespace LAB1_DOTNET
{
    class Program
    {
        /// <summary>
        /// Class variables 
        /// countEmployee : Employee class object's arrey to store Employee class objects.
        /// declared size 100
        /// it will use to calculate the number of data
        /// </summary>
        static Employee[] countEmployee = new Employee[100];
        /// <summary>
        /// emp : Employee class object's arrey to store Employee class objects.
        /// not declared size now. 
        /// it will use to store Employee objects 
        /// static variable, to use in static functions
        /// </summary>
        static Employee[] emp = null;
        /// <summary>
        /// DATAFILE : string variable tostore textfile name.
        /// </summary>
        static string DATAFILE = "employee.txt";

        /// <summary>
        /// Sort function to sort by user input
        /// static function 
        /// </summary>
        /// <param name="choice">user input</param>
        public static void Sort(int choice)
        {
            if (choice == 2)
            {
                /// <summary>
                /// temp : Employee class temporary object & initialized null.
                /// </summary>
                Employee temp = null;
                for (int i = 0; i < emp.Length - 1; i++)
                {
                    for (int j = i + 1; j < emp.Length; j++)
                    {
                        if (emp[j].GetNumber() < emp[i].GetNumber())
                        {
                            temp = emp[i];
                            emp[i] = emp[j];
                            emp[j] = temp;
                        }
                    }
                }
            }
            if (choice == 1)
            {
                /// <summary>
                /// temp : Employee class temporary object & initialized null.
                /// </summary>
                Employee temp = null;
                for (int i = 0; i < emp.Length - 1; i++)
                {
                    for (int j = i + 1; j < emp.Length; j++)
                    {
                        if (emp[j].GetName().CompareTo(emp[i].GetName()) < 0)
                        {
                            temp = emp[i];
                            emp[i] = emp[j];
                            emp[j] = temp;
                        }
                    }
                }
            }
            
            if (choice == 3)
            {
                /// <summary>
                /// temp : Employee class temporary object & initialized null.
                /// </summary>
                Employee temp = null;
                for (int i = 0; i < emp.Length - 1; i++)
                {
                    for (int j = i + 1; j < emp.Length; j++)
                    {
                        if (emp[j].GetRate() > emp[i].GetRate())
                        {
                            temp = emp[i];
                            emp[i] = emp[j];
                            emp[j] = temp;
                        }
                    }
                }
            }
            if (choice == 4)
            {
                /// <summary>
                /// temp : Employee class temporary object & initialized null.
                /// </summary>
                Employee temp = null;
                for (int i = 0; i < emp.Length - 1; i++)
                {
                    for (int j = i + 1; j < emp.Length; j++)
                    {
                        if (emp[j].GetHours() > emp[i].GetHours())
                        {
                            temp = emp[i];
                            emp[i] = emp[j];
                            emp[j] = temp;
                        }
                    }
                }
            }
            if (choice == 5)
            {
                /// <summary>
                /// temp : Employee class temporary object & initialized null.
                /// </summary>
                Employee temp = null;
                for (int i = 0; i < emp.Length - 1; i++)
                {
                    for (int j = i + 1; j < emp.Length; j++)
                    {
                        if (emp[j].GetGross() > emp[i].GetGross())
                        {
                            temp = emp[i];
                            emp[i] = emp[j];
                            emp[j] = temp;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Read function to read the data from the file.
        /// static function 
        /// </summary>
        public static void Read()
        {
            try
            {
                /// <summary>
                /// line : string variable to store each line of text file.
                /// </summary>
                string line = "";
                /// <summary>
                /// count : int variable to track the arrey location.
                /// </summary>
                int count = 0;
                /// <summary>
                /// counter : int variable to count the array size of "emp" variable .
                /// initialized by 0
                /// </summary>
                int counter = 0;
                /// <summary>
                /// readerCount : StreamReader object to read datafile.
                /// </summary>
                StreamReader readerCount = new StreamReader(DATAFILE);
                while (!readerCount.EndOfStream)
                {
                    line = readerCount.ReadLine();
                    counter++;
                }
                readerCount.Close();

                emp = new Employee[counter];

                Console.WriteLine("Employee data reading");
                /// <summary>
                /// reader : StreamReader object to read datafile.
                /// </summary>
                StreamReader reader = new StreamReader(DATAFILE);
                while (!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    /// <summary>
                    /// values : string arrey to store values split by ",".
                    /// </summary>
                    string[] values = line.Split(',');
                    emp[count++] = new Employee(values[0], Int32.Parse(values[1]), Decimal.Parse(values[2]), Convert.ToDouble(values[3]));
                }
                reader.Close();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File has not been found " + DATAFILE );
            }
            catch (Exception e)
            {
                Console.WriteLine("Error " + e.Message);
            }
        }
        /// <summary>
        /// Main method : run first 
        /// give choice to user and call relevent methods upon user request.
        /// </summary>
        /// <param name="args"> A string arrey for user input and output</param>
        static void Main(string[] args)
        {
            /// <summary>
            ///run : to control loop           
            /// </summary>
            Boolean run = true;
            Read();
            foreach (Employee e in emp)
            {
                Console.WriteLine(e);

            }
            while (run)
            {
                Console.WriteLine("\n1: Sort by Employee Name(ascending) \n" +
                    "2: Sort by Employee Number (ascending) \n" +
                    "3: Sort by Employee Pay Rate (descending) \n" +
                    "4: Sort by Employee Hours (descending) \n" +
                    "5: Sort by Employee Gross Pay (descending) \n" +
                    "6: Exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("\n Sorting by Employee Name(ascending)  \n\n");
                        Sort(choice);
                        foreach (Employee e in emp)
                        {
                            Console.WriteLine(e);

                        }
                        break;
                    case 2:
                        Console.Write("\n Sorting by Employee Number(ascending)  \n\n");
                        Sort(choice);
                        foreach (Employee e in emp)
                        {
                            Console.WriteLine(e);

                        }
                        break;
                    case 3:
                        Console.Write("\n Sorting by Employee Pay Rate(descending)  \n\n");
                        Sort(choice);
                        foreach (Employee e in emp)
                        {
                            Console.WriteLine(e);

                        }
                        break;
                    case 4:
                        Console.Write("\n Sorting by Employee Hours(descending)  \n\n");
                        Sort(choice);
                        foreach (Employee e in emp)
                        {
                            Console.WriteLine(e);

                        }
                        break;
                    case 5:
                        Console.Write("\n Sorting by Employee Gross Pay(descending)  \n\n");
                        Sort(choice);
                        foreach (Employee e in emp)
                        {
                            Console.WriteLine(e);

                        }
                        break;
                    case 6:
                        run = false;
                        break;
                    default:
                        Console.WriteLine("\nPlease enter valid input \n");
                        break;


                }


            }



        }
    }
}
