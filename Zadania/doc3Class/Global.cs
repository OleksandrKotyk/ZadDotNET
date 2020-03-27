using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania.doc3Class
{
    public class LosujLiczby
    {
        public int Liczba1 { get; set; }
        public int Liczba2 { get; set; }

        public LosujLiczby(int Liczba1, int Liczba2)
        {
            this.Liczba1 = Liczba1;
            this.Liczba2 = Liczba2;
        }
        public LosujLiczby() { }
    }

    public class Calculator
    {
        public int Dodawanie { get; set; }
        public int Mnozenie { get; set; }
        public int Odejmowanie { get; set; }
        public double Dzielenie { get; set; }
        public object Potegowanie { get; set; }
        public LosujLiczby LosujLiczby { get; set; }
        public Calculator(int dodawanie, int mnozenie, int odejmowanie, double dzielenie, object potegowanie, LosujLiczby losujLiczby)
        {
            this.Dodawanie = dodawanie;
            this.Mnozenie = mnozenie;
            this.Odejmowanie = odejmowanie;
            this.Dzielenie = dzielenie;
            this.LosujLiczby = losujLiczby;
            this.Potegowanie = potegowanie;
        }

        public Calculator(int dodawanie, int mnozenie, int odejmowanie, double dzielenie, LosujLiczby losujLiczby)
        {
            this.Dodawanie = dodawanie;
            this.Mnozenie = mnozenie;
            this.Odejmowanie = odejmowanie;
            this.Dzielenie = dzielenie;
            this.LosujLiczby = losujLiczby;
        }

        public Calculator() { }
    }

    public class Global
    {
        public List<Calculator> ListOfResults { get; set; }
        public Global(List<Calculator> listOfResults)
        {
            this.ListOfResults = listOfResults;
        }
        public Global() { }
    }
}
