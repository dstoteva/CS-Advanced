using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, Dictionary<int, List<string>>> departments = new Dictionary<string, Dictionary<int, List<string>>>();

            while (true)
            {
                string[] inputLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string department = inputLine[0];
                if (department == "Output")
                {
                    break;
                }
                string doctor = inputLine[1] + ' ' + inputLine[2];
                string patient = inputLine[3];

                if (!doctors.ContainsKey(doctor))
                {
                    doctors[doctor] = new List<string>();
                }
                doctors[doctor].Add(patient);

                if (!departments.ContainsKey(department))
                {
                    departments[department] = new Dictionary<int, List<string>>();
                    departments[department][0] = new List<string>();
                }
                if (departments[department].Keys.Count <= 20)
                {
                    if (departments[department][departments[department].Keys.Count - 1].Count < 3)
                    {
                        departments[department][departments[department].Keys.Count - 1].Add(patient);
                    }
                    else
                    {
                        int newKey = departments[department].Keys.Count;
                        departments[department][newKey] = new List<string>();
                        departments[department][newKey].Add(patient);
                    }
                }
            }
            while (true)
            {
                string[] inputLine = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (inputLine[0] == "End")
                {
                    break;
                }
                string firstWord = inputLine[0];
                if (departments.ContainsKey(firstWord) && inputLine.Length == 1)
                {
                    var currentDepartment = departments[firstWord];
                    foreach (int room in currentDepartment.Keys)
                    {
                        foreach (var bed in currentDepartment[room])
                        {
                            Console.WriteLine(bed);
                        }
                    }
                }
                else if (departments.ContainsKey(firstWord) && int.TryParse(inputLine[1], out int room))
                {
                    var currentDepartment = departments[firstWord];
                    foreach (var bed in currentDepartment[room - 1].OrderBy(x => x))
                    {
                        Console.WriteLine(bed);
                    }
                }
                else
                {
                    string doctor = firstWord + ' ' + inputLine[1];
                    foreach (var patient in doctors[doctor].OrderBy(x => x))
                    {
                        Console.WriteLine(patient);
                    }
                }
            }
        }
    }
}
