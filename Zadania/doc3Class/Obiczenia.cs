using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.doc3Class
{
    public class Obiczenia
    {
        private readonly Random rnd;
        private LosujLiczby Losuj()
        {
            int losuj1 = this.rnd.Next(0,300);
            int losuj2 = this.rnd.Next(1, 300);
            return new LosujLiczby(losuj1, losuj2);
        }

        private Calculator SingleCalculation()
        {
            LosujLiczby Wylosowane;
            Wylosowane = Losuj();
            int dodawanie = Wylosowane.Liczba1 + Wylosowane.Liczba2;
            int odejmowanie = Wylosowane.Liczba1 - Wylosowane.Liczba2;
            double dzielenie = (double)Wylosowane.Liczba1 / (double)Wylosowane.Liczba2;
            int mnozenie = Wylosowane.Liczba1 * Wylosowane.Liczba2;
            object potegowanie = null;
            try
            {
                potegowanie = Math.Pow(Wylosowane.Liczba1, Wylosowane.Liczba2);
            }
            catch
            {
                return new Calculator(dodawanie, mnozenie, odejmowanie, dzielenie, Wylosowane);
            }
            return new Calculator(dodawanie, mnozenie, odejmowanie, dzielenie, potegowanie, Wylosowane);
        }

        public Global Wykonaj(int numberOfIterations)
        {
            var now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            Calculator calcResult;
            List<Calculator> ListOfCalc = new List<Calculator>();
            for(int i =0; i < numberOfIterations; i++)
            {
                calcResult = SingleCalculation();
                ListOfCalc.Add(calcResult);
                if(DateTimeOffset.Now.ToUnixTimeMilliseconds() - now == 20)
                    throw new TooLongEx(new Global(ListOfCalc), "Obliczenia zajęły za dużo czasu!");
            }
            return new Global(ListOfCalc);
        }

        public Obiczenia()
        {
            rnd = new Random((int)DateTime.Now.Ticks);
        }
    }
}
