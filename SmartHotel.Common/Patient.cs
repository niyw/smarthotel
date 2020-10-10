using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHotel.Common
{
    public class Patient
    {
        public Patient()
        {
            IsNew = true;
            BloodSugar = 5.0f;
        }
        public float BloodSugar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int HeartBeatRate { get; set; }
        public bool IsNew { get; set; }

        public void IncreaseHeartBeatRate()
        {
            HeartBeatRate = CalculateHeartBeatRate() + 2;
        }

        private int CalculateHeartBeatRate()
        {
            var random = new Random();
            return random.Next(1, 100);
        }
        public void HaveDinner()
        {
            var random = new Random();
            BloodSugar += (float)random.Next(1, 1000) / 1000; 
        }
    }
}
