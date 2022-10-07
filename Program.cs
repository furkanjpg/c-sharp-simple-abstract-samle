using System;

namespace Abstract_sample2
{
    public abstract class month
    {
        public abstract void months();
        public abstract void Days();
        public void Hours()
        {
            Console.WriteLine("24 HOUR");
        }
        public void Dakika()
        {
            Console.WriteLine("1440 MINUTE");
        }
        public void Saniye()
        {
            Console.WriteLine("86.400 SECOND");
        }
    }

    public class January : month
    {
        public override void months()
        {
            Console.WriteLine("January - 1");
        }

        public override void Days()
        {
            Console.WriteLine("31 DAY");
        }

    }
    public class February : month
    {
        public override void months()
        {
            Console.WriteLine("February - 2");
        }

        public override void Days()
        {
            Console.WriteLine("28 DAY");
        }
    }
    public class March : month
    {
        public override void months()
        {
            Console.WriteLine("March - 3");
        }

        public override void Days()
        {
            Console.WriteLine("31 DAY");
        }
    }
    public class April : month
    {
        public override void months()
        {
            Console.WriteLine("April - 4");
        }

        public override void Days()
        {
            Console.WriteLine("30 DAY");
        }
    }
    public class May : month
    {
        public override void months()
        {
            Console.WriteLine("May - 5");
        }

        public override void Days()
        {
            Console.WriteLine("31 DAY");
        }
    }
    public class June : month
    {
        public override void months()
        {
            Console.WriteLine("June - 6");
        }

        public override void Days()
        {
            Console.WriteLine("30 DAY");
        }
    }
    public class July : month
    {
        public override void months()
        {
            Console.WriteLine("July - 7");
        }

        public override void Days()
        {
            Console.WriteLine("31 DAY");
        }
    }
    public class August : month
    {
        public override void months()
        {
            Console.WriteLine("August - 8");
        }

        public override void Days()
        {
            Console.WriteLine("31 DAY");
        }
    }
    public class September : month
    {
        public override void months()
        {
            Console.WriteLine("September - 9");
        }

        public override void Days()
        {
            Console.WriteLine("30 DAY");
        }
    }
    public class October : month
    {
        public override void months()
        {
            Console.WriteLine("October - 10");
        }

        public override void Days()
        {
            Console.WriteLine("31 DAT");
        }
    }
    public class November: month
    {
        public override void months()
        {
            Console.WriteLine("November - 11");
        }

        public override void Days()
        {
            Console.WriteLine("30 DAY");
        }
    }
    public class December : month
    {
        public override void months()
        {
            Console.WriteLine("December - 12");
        }

        public override void Days()
        {
            Console.WriteLine("31 DAY");
        }
    }


    // *************MAIN**************
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            // Jan **
            month Jan = new January();
            Jan.months();
            Jan.Days();
            Jan.Hours();
            Jan.Saniye();
            Console.WriteLine("----------------------");
            // Feb **
            month Feb = new February();
            Feb.months();
            Feb.Days();
            Feb.Hours();
            Feb.Saniye();
            Console.WriteLine("----------------------");

            // Mar **
            month Mar = new March();
            Mar.months();
            Mar.Days();
            Mar.Hours();
            Mar.Saniye();
            Console.WriteLine("----------------------");

            // Apr **
            month Apr = new April();
            Apr.months();
            Apr.Days();
            Apr.Hours();
            Apr.Saniye();
            Console.WriteLine("----------------------");

            // Mayıs **
            month May = new May();
            May.months();
            May.Days();
            May.Hours();
            May.Saniye();
            Console.WriteLine("----------------------");

            // Jun **
            month Jun = new June();
            Jun.months();
            Jun.Days();
            Jun.Hours();
            Jun.Saniye();
            Console.WriteLine("----------------------");

            // Jul **
            month Jul = new July();
            Jul.months();
            Jul.Days();
            Jul.Hours();
            Jul.Saniye();
            Console.WriteLine("----------------------");

            // Aug **
            month Aug = new August();
            Aug.months();
            Aug.Days();
            Aug.Hours();
            Aug.Saniye();
            Console.WriteLine("----------------------");

            // Sep **
            month Sep = new September();
            Sep.months();
            Sep.Days();
            Sep.Hours();
            Sep.Saniye();
            Console.WriteLine("----------------------");

            // Oct **
            month Oct = new October();
            Oct.months();
            Oct.Days();
            Oct.Hours();
            Oct.Saniye();
            Console.WriteLine("----------------------");

            // Kasım **
            month Nov = new November();
            Nov.months();
            Nov.Days();
            Nov.Hours();
            Nov.Saniye();
            Console.WriteLine("----------------------");

            // Dec **
            month Dec = new December();
            Dec.months();
            Dec.Days();
            Dec.Hours();
            Dec.Saniye();
            Console.WriteLine("----------------------");

            // CRK
            Console.ReadKey();
        }
    }
}
