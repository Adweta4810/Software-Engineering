using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Task 2
using System.Windows.Forms;


namespace Lab01Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            Console.WriteLine("Starting...");
            Program app = new Program();

        }

        public Program()
        {
            //Task 1
            Console.WriteLine("In constructor and out of static context");

            //Task 2 & 3
            MessageBox.Show("Hello from Task 2", "Lab 01 Console",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Message", "Title",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //Task 4
            RunBmiLoop();
        }
        private void RunBmiLoop()
        {
            while (true)   // required loop
            {
                Console.WriteLine("\n=== BMI Calculator ===");
                Console.WriteLine("Press Enter on gender to quit.");
                Console.Write("Gender (F/M): ");
                string gender = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(gender)) break;   // exit loop
                gender = gender.Trim().ToUpper();

                // Reading a string 
                Console.Write("Units (M = metric kg/m, I = imperial lb/in): ");
                string unitString = Console.ReadLine();          // ← string s = Console.ReadLine();
                string s;                                        // demonstrate variable s

                float weight = 0f, height = 0f, bmi = 0f;

                if (unitString.ToUpper() == "I")
                {
                    Console.Write("Weight (lb): ");
                    s = Console.ReadLine();                      // read string
                    weight = Single.Parse(s);                    // convert to float

                    Console.Write("Height (in): ");
                    s = Console.ReadLine();
                    height = Single.Parse(s);

                    bmi = (weight / (height * height)) * 703f;
                }
                else
                {
                    Console.Write("Weight (kg): ");
                    s = Console.ReadLine();
                    weight = Single.Parse(s);                    // convert string → float

                    Console.Write("Height (m or cm): ");
                    s = Console.ReadLine();
                    height = Single.Parse(s);
                    if (height > 3) height = height / 100f;      // assume cm

                    bmi = weight / (height * height);
                }

                // ---------------- Convert float → string ----------------
                s = bmi.ToString("F1");                          // float to string
                Console.WriteLine($"BMI = {s}");

                // ---------------- Conditional if-else bands ----------------
                string femaleBand = BandForFemale(bmi);
                string maleBand = BandForMale(bmi);

                if (gender == "F")
                {
                    Console.WriteLine($"Female band: {femaleBand}");
                    Console.WriteLine($"Male band: {maleBand}");
                }
                else if (gender == "M")
                {
                    Console.WriteLine($"Male band: {maleBand}");
                    Console.WriteLine($"Female band: {femaleBand}");
                }
                else
                {
                    Console.WriteLine("Unknown gender – showing both:");
                    Console.WriteLine($"Female: {femaleBand}");
                    Console.WriteLine($"Male: {maleBand}");
                }
            }

            Console.WriteLine("Goodbye!");
        }
        private string BandForFemale(float bmi)
        {
            if (bmi < 17.5f) return "Severely underweight (<17.5)";
            if (bmi < 19.1f) return "Underweight (17.5–19.1)";
            if (bmi < 25.8f) return "Normal (19.1–25.8)";
            if (bmi < 27.3f) return "Marginally overweight (25.8–27.3)";
            if (bmi < 32.3f) return "Overweight (27.3–32.3)";
            if (bmi < 35f) return "Very overweight (32.3–35)";
            if (bmi < 40f) return "Severely obese (35–40)";
            if (bmi < 50f) return "Morbidly obese (40–50)";
            if (bmi < 60f) return "Super obese (50–60)";
            return "Extremely obese (>=60)";
        }

        private string BandForMale(float bmi)
        {
            if (bmi < 18.5f) return "Severely underweight (<18.5)";
            if (bmi < 20.7f) return "Underweight (18.5–20.7)";
            if (bmi < 26.4f) return "Normal (20.7–26.4)";
            if (bmi < 27.8f) return "Marginally overweight (26.4–27.8)";
            if (bmi < 31.1f) return "Overweight (27.8–31.1)";
            if (bmi < 35f) return "Very overweight (31.1–35)";
            if (bmi < 40f) return "Severely obese (35–40)";
            if (bmi < 50f) return "Morbidly obese (40–50)";
            if (bmi < 60f) return "Super obese (50–60)";
            return "Extremely obese (>=60)";
        }

    }
}
    

