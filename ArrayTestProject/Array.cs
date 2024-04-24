using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace narray
{
    public class carray
    {
        public static void Main()
        {
            try
            {
                int[] serialnumber = new int[] { 12, 123, 1234 };
                double[] salary = { 123.234, 2345.456, 5678.345 };
                string[] name = new string[3];
                name[0] = "Pradeep";
                name[1] = "Kuldeep";
                name[2] = "Sandeep";

                Console.WriteLine("Int Array Length :: " + serialnumber.Length);
                for (int i = 0; i < serialnumber.Length; i++)
                {
                    Console.Write(serialnumber[i] + ",");
                }
                Console.WriteLine();
                Console.WriteLine("============================================");

                Console.WriteLine("Double Salary Length :: " + salary.Length);
                for (int i = 0; i < salary.Length; i++)
                {
                    Console.Write(salary[i] + ",");
                }
                Console.WriteLine();
                Console.WriteLine("============================================");

                Console.WriteLine("String Name Length :: " + name.Length);
                foreach (string STR in name)
                {
                    Console.Write(STR + ",");
                }
                Console.WriteLine();
                Console.WriteLine("============================================");

                Console.WriteLine("Do You Want To Add More Value To Salary :: Yes/No");
                string getMoreValueTosalary = Console.ReadLine();
                if (getMoreValueTosalary.ToUpper() == "YES")
                {
                    Console.Write("Add Number Of Count to Add ::");
                    int getNumberOfCount = int.Parse(Console.ReadLine());
                    int oldSalaryCount = salary.Length;
                    int newSalaryCount = getNumberOfCount + oldSalaryCount;
                    Array.Resize(ref salary, newSalaryCount);
                    for (int i = oldSalaryCount; i < newSalaryCount; i++)
                    {
                        salary[i] = double.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("New Double Salary Length :: " + salary.Length);
                    for (int i = 0; i < salary.Length; i++)
                    {
                        Console.Write(salary[i] + ",");
                    }
                    Console.WriteLine();
                    Console.WriteLine("============================================");
                }
                else
                {
                    Console.WriteLine("GoodBye");
                    Console.WriteLine("============================================");
                }

                Console.WriteLine("Assending Order");
                for (int i = 0; i < salary.Length; i++)
                {
                    for (int j = i + 1; j < salary.Length; j++)
                    {
                        if (salary[i] > salary[j])
                        {
                            double temp = salary[i];
                            salary[i] = salary[j];
                            salary[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < salary.Length; i++)
                {
                    Console.Write(salary[i] + ",");
                }
                Console.WriteLine();
                Console.WriteLine("============================================");


                Console.WriteLine("Desending Order");
                for (int i = 0; i < salary.Length; i++)
                {
                    for (int j = i + 1; j < salary.Length; j++)
                    {
                        if (salary[i] < salary[j])
                        {
                            double temp = salary[i];
                            salary[i] = salary[j];
                            salary[j] = temp;
                        }
                    }
                }
                for (int i = 0; i < salary.Length; i++)
                {
                    Console.Write(salary[i] + ",");
                }
                Console.WriteLine();
                Console.WriteLine("============================================");

                Console.WriteLine("Array to List");
                List<double> arrayList = salary.ToList();
                Console.WriteLine("Array List Length :: " + arrayList.Count);
                foreach (double AL in arrayList)
                {
                    Console.Write(AL + ",");
                }
                Console.WriteLine();
                Console.WriteLine("============================================");

                Console.WriteLine("Array To Dictionary");
                var arrayDictiony = salary.ToDictionary(x => x);
                foreach (var AD in arrayDictiony)
                {
                    Console.Write(AD + ",");
                }
                Console.WriteLine();
                Console.WriteLine("============================================");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.Message);
                Console.WriteLine(Ex.StackTrace);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}