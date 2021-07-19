using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8_HW_and_Excersize
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3] { 1, 2, 3 };
            int[] arr2 = arr1;

            int[] arr3 = new int[arr1.Length];

            for (int i = 0; i < arr3.Length; i++)
            {
                int tempValue = arr1[i];
                arr3[i] = tempValue;
            }

            #region HW7 Overloading operations

            DigitalWatch myWatch = new DigitalWatch(14, 04, 33, "Thoursday", 34.5);

            myWatch.PrintDetails(myWatch._hour, myWatch._minutes, myWatch._seconds, myWatch._day, myWatch._temp);

            #endregion

            #region HW8 Overloading operation

            string[] myFiles = new string[3] { "wordFile", "exelFile", "pdfFile" };

            string[] myFiles2 = new string[3];
            
            Computer computer = new Computer(myFiles);

            SmartComp smartComp = new SmartComp();
            smartComp._allOpenFiles = myFiles;

            //computer.TurnOff();

            smartComp.TurnOffSmart(true, true);

            #endregion
        }
    }

    #region HW7 Overloading 

    public class DigitalWatch
    {
        public int _hour, _minutes, _seconds;
        public string _day;
        public double _temp;

        public DigitalWatch(int hour, int minutes, int seconds, string day, double temp)
        {
            _hour = hour;
            _minutes = minutes;
            _seconds = seconds;
            _day = day;
            _temp = temp;
        }

        public void PrintDetails(int hour, int minutes)
        {
            Console.WriteLine($"Time now is(h:m):\n{_hour} : {_minutes}");
        }

        public void PrintDetails(int hour, int minutes, int seconds)
        {
            Console.WriteLine($"Time now is(h:m:s):\n{_hour} : {_minutes} : {_seconds}");
        }

        public void PrintDetails(int hour, int minutes, int seconds, string day)
        {
            Console.WriteLine($"Today is {_day}\nTime now is(h:m:s):\n{_hour} : {_minutes} : {_seconds}");

        }

        public void PrintDetails(int hour, int minutes, int seconds, string day, double temp)
        {
            Console.WriteLine($"Today is {_day}\nTime now is(h:m:s):\n{_hour} : {_minutes} : {_seconds}\nTemperature outside: {_temp}");
        }
    }

    #endregion

    #region HW8 Overloading 

    public class Computer
    {
        // Fields

        public string[] _allOpenFiles;
        public bool _isOn;

        // Ctors

        public Computer()
        {

        }

        public Computer(string[] openFiles)
        {
            _allOpenFiles = openFiles;
            _isOn = true;
        }

        // Abilities

        public void TurnOff()
        {
            _allOpenFiles = null;
            _isOn = false;
        }

        public void TurnOff(bool Off)
        {
            if (_allOpenFiles == null)
            {
                TurnOff();
            }
            else
            {
                Console.WriteLine("Are you sure? (Y/N)");
                string ans = Console.ReadLine();
                if(ans.ToUpper() == "Y")
                {
                    TurnOff();
                }
            }
        }
    }

    public class SmartComp : Computer
    {
        // Fields

        public string[] _filesInCache;

        //Ctors



        // Abilities

        public void TurnOffSmart(bool Off , bool saveFiles)
        {
            if (Off || (Off == false && _allOpenFiles != null))
            {
                if (saveFiles)
                {
                    _filesInCache = new string[_allOpenFiles.Length];
                    for (int j = 0; j < _allOpenFiles.Length; j++)
                    {
                        _filesInCache[j] = _allOpenFiles[j];
                    }
                    _isOn = false;
                    _allOpenFiles = null;
                }
                else
                {
                    _isOn = false;
                }
            }
        }

    }

    #endregion
}
