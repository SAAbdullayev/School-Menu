using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Students_menu
{
    [Serializable]
    internal class Program
    {
        

        [Obsolete]
        static void Main(string[] args)
        {
             string FileNameTeachers = @"C:\Users\ASUS\source\repos\Students menu\Students menu\teachers.txt";
             string FileNameStudents = @"C:\Users\ASUS\source\repos\Students menu\Students menu\students.txt";





            List<Teachers> tc = LoadFromFile(FileNameTeachers);
            List<Student> st = LoadFromFilee(FileNameStudents);

            int exit = 0;
            while (exit == 0)
            {
            Step1:
                
                Console.WriteLine("---------- Menu of School ------------->");
                Console.WriteLine("1.Teachers menu: ");
                Console.WriteLine("--------------------------------------->");
                Console.WriteLine("2.Students menu: ");
                Console.WriteLine("--------------------------------------->");
                Console.WriteLine("3.Exit menu: ");
                Console.WriteLine("--------------------------------------->");
                Console.Write("Write the menu number, which you want: ");


                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a > 0 && a <= 3)
                    {

                        switch (a)
                        {
                            case 1:
                            Step2:
                                Console.Clear();
                                Console.WriteLine("---------- Menu of Teachers ----------->");
                                Console.WriteLine("1.Add a teacher: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.WriteLine("2.Remove by index: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.WriteLine("3.Save: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.WriteLine("4.Save and Exit: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.WriteLine("5.List of teachers: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.WriteLine("6.Go to main menu: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.WriteLine("7.Exit menu: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.Write("Write the menu number, which you want: ");
                                try
                                {
                                    int b = Convert.ToInt32(Console.ReadLine());
                                    if (b > 0 && b <= 7)
                                    {
                                        int exit1 = 0;
                                        while (exit1 == 0)
                                        {
                                            switch (b)
                                            {
                                                case 1:

                                                    Console.Clear();
                                                    Teachers teachers = new Teachers();
                                                    Console.Write("Name: ");
                                                    teachers.Name = Console.ReadLine();
                                                    Console.WriteLine("--------------------------------------->");
                                                    Console.Write("Surname: ");
                                                    teachers.Surname = Console.ReadLine();
                                                    Console.WriteLine("--------------------------------------->");
                                                    Console.Write("Age: ");
                                                    teachers.Age = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine("--------------------------------------->");
                                                    Console.Write("Number of School: ");
                                                    teachers.NumberOfSchool = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine("--------------------------------------->");
                                                    Console.Write("Grade: ");
                                                    teachers.Grade = Console.ReadLine();
                                                    tc.Add(teachers);
                                                    Console.Clear();
                                                    Console.WriteLine("Registrate has done!!");
                                                    Console.WriteLine("Click the enter key to go to the main menu: ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    goto Step2;
                                                    break;
                                                case 2:
                                                    Console.Clear();
                                                    int count1 = 0;
                                                    foreach (var item in tc)
                                                    {
                                                        Console.WriteLine($"{count1}. {item}");
                                                        count1++;
                                                    }
                                                    Console.Write("Enter a number to remove: ");
                                                    int remove1 = Convert.ToInt32(Console.ReadLine());
                                                    tc.RemoveAt(remove1);
                                                    Console.Clear();
                                                    Console.WriteLine("The person has been cleaned!! ");
                                                    Console.WriteLine("Click the enter key to go to the teachers menu: ");
                                                    Console.ReadKey();
                                                    goto Step2;
                                                    break;
                                                case 3:
                                                    Console.Clear();

                                                    SaveToFile(tc, FileNameTeachers);
                                                    Console.WriteLine("Saving successfully!!");
                                                    Console.WriteLine("Click the enter key to go to the teachers menu: ");
                                                    Console.ReadKey();
                                                    goto Step2;
                                                    break;
                                                case 4:
                                                    Console.Clear();
                                                    SaveToFile(tc, FileNameTeachers);
                                                    Console.WriteLine("Saving successfully!!");
                                                    exit1++;
                                                    break;
                                                case 5:
                                                    Console.Clear();
                                                    int count5 = 0;

                                                    foreach (var item in tc)
                                                    {
                                                        Console.WriteLine($"{count5}. {item}");
                                                        count5++;
                                                    }
                                                    Console.WriteLine("Click the enter key to go to the teachers menu: ");
                                                    Console.ReadKey();
                                                    goto Step2;
                                                    break;
                                                case 6:

                                                    Console.Clear();
                                                    goto Step1;
                                                    break;
                                                case 7:
                                                    Console.Clear();
                                                    exit1++;

                                                    break;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Please enter correctly!!");
                                        Console.WriteLine("Click the enter key to go to the teachers menu: ");
                                        Console.ReadKey();
                                        Console.Clear();
                                        goto Step2;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Please, enter a number");
                                    Console.WriteLine("Click the enter key to go to the main menu: ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    goto Step2;
                                    throw;
                                }
                                break;

                            case 2:
                            Step3:
                                Console.Clear();
                                Console.WriteLine("---------- Menu of Students ----------->");
                                Console.WriteLine("1.Add a student: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.WriteLine("2.Remove by index: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.WriteLine("3.Save: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.WriteLine("4.Save and Exit: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.WriteLine("5.List of students: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.WriteLine("6.Go to main menu: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.WriteLine("7.Exit menu: ");
                                Console.WriteLine("--------------------------------------->");
                                Console.Write("Write the menu number, which you want: ");
                                try
                                {
                                    int c = Convert.ToInt32(Console.ReadLine());
                                    if (c > 0 && c <= 7)
                                    {
                                        int exit2 = 0;
                                        while (exit2 == 0)
                                        {
                                            switch (c)
                                            {
                                                case 1:

                                                    Console.Clear();
                                                    Student student = new Student();
                                                    Console.Write("Name: ");
                                                    student.Name = Console.ReadLine();
                                                    Console.WriteLine("--------------------------------------->");
                                                    Console.Write("Surname: ");
                                                    student.Surname = Console.ReadLine();
                                                    Console.WriteLine("--------------------------------------->");
                                                    Console.Write("Age: ");
                                                    student.Age = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine("--------------------------------------->");
                                                    Console.Write("Number of School: ");
                                                    student.NumberOfSchool = Convert.ToInt32(Console.ReadLine());
                                                    Console.WriteLine("--------------------------------------->");
                                                    Console.Write("Grade: ");
                                                    student.Grade = Console.ReadLine();
                                                    st.Add(student);
                                                    Console.Clear();
                                                    Console.WriteLine("Registrate has done!!");
                                                    Console.WriteLine("Click the enter key to go to the main menu: ");
                                                    Console.ReadKey();
                                                    Console.Clear();
                                                    goto Step3;
                                                    break;
                                                case 2:
                                                    Console.Clear();
                                                    int count2 = 0;

                                                    foreach (var item in st)
                                                    {
                                                        Console.WriteLine($"{count2}. {item}");
                                                        count2++;
                                                    }
                                                    Console.Write("Enter a number to remove: ");
                                                    int remove2 = Convert.ToInt32(Console.ReadLine());
                                                    st.RemoveAt(remove2);
                                                    Console.Clear();
                                                    Console.WriteLine("The person has been cleaned!! ");
                                                    Console.WriteLine("Click the enter key to go to the students menu: ");

                                                    Console.ReadKey();
                                                    goto Step3;


                                                    break;
                                                case 3:
                                                    Console.Clear();
                                                    SaveToFile(st, FileNameStudents);
                                                    Console.WriteLine("Saving successfully!!");
                                                    Console.WriteLine("Click the enter key to go to the students menu: ");
                                                    Console.ReadKey();
                                                    goto Step3;

                                                    break;
                                                case 4:
                                                    Console.Clear();
                                                    SaveToFile(st, FileNameStudents);
                                                    Console.WriteLine("Saving successfully!!");
                                                    exit2++;
                                                    break;
                                                case 5:
                                                    Console.Clear();
                                                    int count = 0;

                                                    foreach (var item in st)
                                                    {
                                                        Console.WriteLine($"{count}. {item}");
                                                        count++;
                                                    }
                                                    Console.WriteLine("Click the enter key to go to the students menu: ");
                                                    Console.ReadKey();
                                                    goto Step3;
                                                    break;
                                                case 6:

                                                    Console.Clear();
                                                    goto Step1;
                                                    break;
                                                case 7:
                                                    Console.Clear();
                                                    exit2++;

                                                    break;
                                            }
                                        }

                                    }
                                    else
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Please enter correctly!!");
                                        Console.WriteLine("Click the enter key to go to the students menu: ");
                                        Console.ReadKey();
                                        Console.Clear();
                                        goto Step3;
                                    }
                                }
                                catch (Exception)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Please, enter a number");
                                    Console.WriteLine("Click the enter key to go to the main menu: ");
                                    Console.ReadKey();
                                    Console.Clear();
                                    goto Step3;
                                    throw;
                                }
                                break;
                            case 3:
                                exit++;
                                break;
                        }

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter correctly!!");
                        Console.WriteLine("Click the enter key to go to the main menu: ");
                        Console.ReadKey();
                        Console.Clear();
                        goto Step1;
                    }
                    exit++;
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("Please, enter a number");
                    Console.WriteLine("Click the enter key to go to the main menu: ");
                    Console.ReadKey();
                    Console.Clear();
                    goto Step1;
                    throw;
                }
            }
        }

        private static List<Teachers> LoadFromFile(string FileNameTeachers)
        {
            try
            {
                using(var fs = new FileStream(FileNameTeachers, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bf = new BinaryFormatter();  
                    return (List<Teachers>)bf.Deserialize(fs);
                }
            }
            catch (Exception)
            {

                return new List<Teachers>();
            }
        }

        private static List<Student> LoadFromFilee(string FileNameStudents)
        {
            try
            {
                using (var fss = new FileStream(FileNameStudents, FileMode.Open, FileAccess.Read))
                {
                    BinaryFormatter bff = new BinaryFormatter();
                    return (List<Student>)bff.Deserialize(fss);
                }
            }
            catch (Exception)
            {

                return new List<Student>();
            }
        }

        static void SaveToFile(List<Student> st, string FileNameStudents)
        {
            using (FileStream fsss = new FileStream(FileNameStudents, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bffff = new BinaryFormatter();
                bffff.Serialize(fsss, st);
            }
        }


        static void SaveToFile(List<Teachers> tc, string FileNameTeachers)
        {
            using (FileStream fs = new FileStream(FileNameTeachers, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, tc);
            }
        }
    }

    
    






}
