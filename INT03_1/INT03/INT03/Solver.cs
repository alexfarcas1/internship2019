using INT03.Domain;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INT03
{
    class Solver
    {
        private string getError(string error)
        {
            return error;
            
        }
        private Employee LoadJson(string input)
        {
            using (StreamReader r = new StreamReader(input))
            {
                var json = r.ReadToEnd();
                dynamic results = JsonConvert.DeserializeObject<dynamic>(json);
                var e = results.employeeData.suspensionPeriodList;
                Suspension[] rez = e.ToObject<Suspension[]>();
                DateTime employmentStartDate = results.employeeData.employmentStartDate;
                DateTime employmentEndDate = results.employeeData.employmentEndDate;
                List<Suspension> list = rez.ToList();

                return new Employee(employmentStartDate, employmentEndDate, list);
            }

             
        }


       
        public IList<Holiday> Solve(string input)
        {
            Employee employee = LoadJson(input);


            IList<int> years = new List<int>();
            IList<int> holidayDays = new List<int>();

            int initial = 20;

            for (int i = employee.EmploymentStartDate.Year; i <= employee.EmploymentEndDate.Year; i++) 
            {
                years.Add(i);

                holidayDays.Add(initial);
                if (initial < 24)
                {
                     initial++;   
                }

            }

            int minYear = employee.EmploymentStartDate.Year;

            foreach(Suspension suspension in employee.SuspensionPeriodList){

                if (suspension.StartDate.Year.Equals(suspension.EndDate.Year))
                {
                    int suspensionDays = (int)Math.Abs((suspension.StartDate - suspension.EndDate).TotalDays);

                    int index = (int)Math.Abs(minYear - suspension.StartDate.Year);

                    int diff = (int)Math.Round((double)(holidayDays[index] * suspensionDays)/365);

                    holidayDays[index] -= diff;
                }
            }

            IList<Holiday> result = new List<Holiday>();

            for (int i = 0; i< holidayDays.Count; i++)
            {
                result.Add(new Holiday(years[i], holidayDays[i]));
            }

            return result;
            
        }

        public void solutie(string input, string output)
        {
            string error = null;
            IList<Holiday> k = new List<Holiday>();

            try
            {
                k = this.Solve(input);
              
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Input file not found!");
            }
            catch (Exception e)
            {
                error = e.ToString();
            }

            var obj = new
            {
                output = new
                {
                    errorMessage = error,
                    holidayRightsPerYearList = k
                }
            };

            var re = JsonConvert.SerializeObject(obj, Formatting.Indented);

            using (StreamWriter r = new StreamWriter(output))
            {
                r.Write(re);
            }

        }
    }
}

          


