using System;

namespace SecsNaarUMS
{
    class Program
    {
        static void HMSToSeconds(int hours, int minutes, int seconds, out int totalSeconds)
        {
            // TODO - Done

            totalSeconds = hours * 3600 + minutes * 60 + seconds;
        }

        static void SecondsToHMS(int totalSeconds, int temp, out int hours, out int minutes, out int seconds)
        {
            // TODO - Done
            hours = totalSeconds / 3600;
            temp = totalSeconds % 3600;
            minutes = temp / 60;
            seconds = temp % 60;
        }


        static void Invoer3(string[] vragen, out int getal1, out int getal2, out int getal3)
        {
            getal1 = 0;
            getal2 = 0;
            getal3 = 0;

            Invoer1(vragen[0], out getal1);
            Invoer1(vragen[1], out getal2);
            Invoer1(vragen[2], out getal3);

        }

        static void Main(string[] args)
        {
            int t;
            int h;
            int m;
            int s;
            string[] vragen = {
                "Geef het aantal uur: ",
                "Geef het aantal minuten: ",
                "Geef het aantal seconden: "
            };

            Invoer3(vragen, out h, out m, out s);
            HMSToSeconds(h, m, s, out t);
            Console.WriteLine("{0} uren, {1} minuten en {2} seconden, zijn in totaal {3} seconden. ", h, m, s, t);
            Console.WriteLine("{0} seconds = {1}h {2}m {3}s", t, h, m, s);


        }
        static void Invoer1(string vraag, out int getal)
        {
            getal = 0;
            string invoer;
            bool succeeded = false;
            while (!succeeded)
            {
                Console.WriteLine(vraag);
                invoer = Console.ReadLine();
                succeeded = Int32.TryParse(invoer, out getal);
                if (!succeeded)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fout, geef een getal in!");
                    Console.ResetColor();
                }
            }
        }
    }
}