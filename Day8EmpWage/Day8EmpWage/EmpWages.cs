﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8EmpWage
{
    public class EmpWages
    {
        public const int EMP_ABSENT = 0, PART_TIME = 1, FULL_TIME = 2, EMP_RATE_PER_HOUR = 20, FULL_TIME_HOURS = 8, PART_TIME_HOURS = 4;
        int empHours = 0;
        int EmpWage = 0;

        public EmpWages()
        {
            Console.WriteLine("Welcome To Employee Wage Problem:\n");
        }
        public void UsingSwitch()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);

            switch (empCheck)
            {
                case EMP_ABSENT:
                    Console.WriteLine("Employee is Absent ");
                    break;
                case PART_TIME:
                    Console.WriteLine("Employee is Present For Part Time ");
                    empHours = PART_TIME_HOURS;
                    break;
                case FULL_TIME:
                    Console.WriteLine("Employee is Present For Full Time ");
                    empHours = FULL_TIME_HOURS;
                    break;
            }

            EmpWage = EMP_RATE_PER_HOUR * empHours;
            Console.WriteLine($"Emp Wage : {EmpWage}");
        }
    }
}
