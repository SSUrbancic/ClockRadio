using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClockRadioApplication
{
    public class ClockRadio
    {

        // member variables (HAS A relationship)
        public string name;
        public bool radioStationStatus;
        public bool alarmStatus;
        public string radioStation;
        // constructor (SPAWNER)
        public ClockRadio(string name)
        {
            this.name = name;
            alarmStatus = false;
            radioStationStatus = false;
            DisplayTime();
            SetRadioStation();
            SetAlarm();

        }
        // member methods (CAN DO relationship)
        public void DisplayTime()
        {
            Console.WriteLine(DateTime.Now);

        }


        public void SetRadioStation()
        {
            Console.WriteLine("What radio station would you like to listen to? 1 - Hip Hop 2 - Rock 3- Country 4 - Turn Off Radio");
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    radioStation = "Hip Hop";
                    Console.WriteLine("You're listening to Hip Hop Radio!");
                    break;
                case "2":
                    radioStation = "Rock Radio";
                    Console.WriteLine("You're listening to Rock Radio!");
                    break;
                case "3":
                    radioStation = "Country";
                    Console.WriteLine("You're listening to Country Radio!");
                    break;
                default:
                    radioStation = "Radio Off";
                    Console.WriteLine("Radio Off");
                    break;
            }

        }
        public void SetAlarm()
        {
            Console.WriteLine("Would you like to set an alarm?");
            string userInput2 = Console.ReadLine();

            if (userInput2 == "yes")
            {
                Console.WriteLine("What time do you want to set the alarm for?");
                string alarmTime = Console.ReadLine();
                Console.WriteLine("Your alarm is set for: " + alarmTime);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("No Alarm Set");
            }

        }
    }

}

