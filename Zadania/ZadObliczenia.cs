using System;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadania;

namespace Zadania
{
    class ZadObliczenia
    {
        public static Random rnd = new Random((int)DateTime.Now.Ticks);
        public static double Xdo2(double x)
        {
            return x * x;
        }

        public static double Xdo3(double x)
        {
            return x * x * x;
        }

        public static double ProstLicz(double xp, double xk, double N, Func<double, double> f)
        {
            double res = 0, dx = (xk - xp) / N; ;
            for (int i = 1; i <= N; i++)
                res += f(xp + i * dx);
            return res * dx;
        }

        public static double TrapezLicz(double xp, double xk, double N, Func<double, double> f)
        {
            double res = 0;
            double dx = (xk - xp) / N;
            for (int i = 1; i <= N; i++)
                res += f(xp + i * dx);
            return (res + (f(xp) + f(xk))/2) * dx;
        }

        public static List<SingleCount> Oblicznie(int M, Func<double, double> f, double x1 = 0, double x2 = 100)
        {

            List<SingleCount> retList = new List<SingleCount>();
            for (int i = 0; i < M; i++)
            {
                int N = rnd.Next(10, 100000);
                double area = TrapezLicz(x1, x2, N, f);
                retList.Add(new SingleCount(x1, x2, N, AreaType.Trapezoid, area, i + 1));
                area = ProstLicz(x1, x2, N, f);
                retList.Add(new SingleCount(x1, x2, N, AreaType.Rectangle, area, i + 1));
                Console.WriteLine(retList[i].AreaType);
            }
            return retList;
        }

        public static ZadGlobal Zadanie2(Func<double, double> f, double z, double mustBe, out bool test1, out bool test2)
        {
            List<SingleCount> res = new List<SingleCount>();
            int N = 1;
            res.Add(new SingleCount(1, 1, -1, AreaType.Trapezoid, 0, 1));
            res.Add(new SingleCount(1, 1, -1, AreaType.Rectangle, 0, 1));

            double x1 = 0;
            double x2 = 100;
            test1 = false;
            test2 = false;
            for (; N <= 10000; N++)
            {
                double area = TrapezLicz(x1, x2, N, f);
                Console.WriteLine(Math.Abs(area - mustBe) + "    " + Math.Round(mustBe) / 100.0 * z);
                if (Math.Round(Math.Abs(area - mustBe)) <= Math.Round(Math.Abs(mustBe / 100.0 * z)))
                {
                    if (Math.Round(Math.Abs(area - mustBe)) == Math.Round(Math.Abs(mustBe / 100.0 * z)))
                        test1 = true;
                    res[0].N = N;
                    break;
                }
            }


            const string message = "Are you sure that you would like to continue? It can take a long time.";
            const string caption = "Form Continue";
            DialogResult result = DialogResult.No;
            if (res[0].N == -1)
            {
                result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if (result == DialogResult.No)
                {
                    return new ZadGlobal(res); ;
                }

            }

            while (true)
            {
                double area = TrapezLicz(x1, x2, N, f);
                Console.WriteLine(Math.Abs(area - mustBe) + "    " + mustBe / 100.0 * z);
                if (Math.Round(Math.Abs(area - mustBe)) <= Math.Round(Math.Abs(mustBe / 100.0 * z)))
                {
                    if (Math.Round(Math.Abs(area - mustBe)) == Math.Round(Math.Abs(mustBe / 100.0 * z)))
                        test1 = true;
                    res[0].N = N;
                    break;
                }
                N++;
            }

            Console.WriteLine("-------------------------");

            N = 1;
            for (; N <= 10000; N++)
            {
                double area = ProstLicz(x1, x2, N, f);
                Console.WriteLine(Math.Abs(area - mustBe) + "    " + Math.Round(mustBe) / 100.0 * z);
                if (Math.Round(Math.Abs(area - mustBe)) <= Math.Round(Math.Abs(mustBe / 100.0 * z)))
                {
                    if (Math.Round(Math.Abs(area - mustBe)) == Math.Round(Math.Abs(mustBe / 100.0 * z)))
                        test2 = true;
                    res[1].N = N;
                    break;
                }
            }

            if (result == DialogResult.No && res[1].N == -1)
            {
                result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if (result == DialogResult.No)
                    return new ZadGlobal(res);
            }


            while (true)
            {
                double area = ProstLicz(x1, x2, N, f);
                Console.WriteLine(Math.Abs(area - mustBe) + "    " + Math.Round(mustBe) / 100.0 * z);
                if (Math.Round(Math.Abs(area - mustBe)) <= Math.Round(Math.Abs(mustBe / 100.0 * z)))
                {
                    if (Math.Round(Math.Abs(area - mustBe)) == Math.Round(Math.Abs(mustBe / 100.0 * z)))
                        test2 = true;
                    res[1].N = N;
                    break;
                }
                N++;
            }
            return new ZadGlobal(res);
        }

        public static ZadGlobal Zadanie6(double m, double k)
        {
            List<SingleCount> res = new List<SingleCount>();
            res.Add(new SingleCount(1, 1, -1, AreaType.Rectangle, double.MaxValue, 1));
            res.Add(new SingleCount(1, 1, -1, AreaType.Trapezoid, double.MaxValue, 1));
            for (int i = 0; i < m; i++)
            {
                double x1 = rnd.Next(0, 1000), x2 = rnd.Next((int)x1 + 1, 1200);
                double res2 = ProstLicz(x1, x2, (int)Math.Pow(10, k), x => x * x);
                double res3 = ProstLicz(x1, x2, (int)Math.Pow(10, k), x => x * x * x);

                if (Math.Abs(res3 - res2) < res[0].Area)
                { 
                    res[0].Area = Math.Abs(res3 - res2);
                    res[0].X1 = x1;
                    res[0].X2 = x2;
                }

                res2 = TrapezLicz(x1, x2, (int)Math.Pow(10, k), x => x * x);
                res3 = TrapezLicz(x1, x2, (int)Math.Pow(10, k), x => x * x * x);

                if (Math.Abs(res3 - res2) < res[1].Area)
                {
                    res[1].Area = Math.Abs(res3 - res2);
                    res[1].X1 = x1;
                    res[1].X2 = x2;
                }
            }
            return new ZadGlobal(res);
        }

        public static ZadGlobal Zadanie7(double z, double x1, double x2)
        {
           
            int N = 1;
            List<SingleCount> res = new List<SingleCount>();
            res.Add(new SingleCount(1, 1, -1, AreaType.Trapezoid, 0, 1));
            res.Add(new SingleCount(1, 1, -1, AreaType.Rectangle, 0, 1));
           
            for (; N <= 10000; N++)
            {
                double area = TrapezLicz(x1, x2, N, x => x * x);
                if (Math.Floor(area) % z == 0)
                {
                    res[0].N = N;
                    break;
                }
            }


            DialogResult result = DialogResult.No;
            if (res[0].N == -1)
            {
                const string message = "Are you sure that you would like to continue? This process cat be endless!!!";
                const string caption = "Form Continue";
                result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if (result == DialogResult.No)
                    return new ZadGlobal(res);


            }

            while (true)
            {
                
                
                double area = TrapezLicz(x1, x2, N, x => x * x);
                if (Math.Floor(area) % z == 0)
                {
                    res[0].N = N;
                    break;
                }
                N++;
            }

            N = 1;
            for (; N <= 10000; N++)
            {
               
                double area = ProstLicz(x1, x2, N, x => x * x);
                if (Math.Floor(area) % z == 0)
                {
                    res[1].N = N;
                    return new ZadGlobal(res);
                }
            }

            if (result == DialogResult.No)
            {
                const string message = "Are you sure that you would like to continue? This process cat be endless!!!";
                const string caption = "Form Continue";
                result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return new ZadGlobal(res);

            }


            while (true)
            {
                
                double area = ProstLicz(x1, x2, N, x => x * x);
                if (Math.Floor(area) % z == 0)
                {
                    res[1].N = N;
                    break;
                }
                N++;
            }

            return new ZadGlobal(res);
        }
        public static ZadGlobal Zadanie8(Func<double, double> f, double z, double mustBe)
        {
            List<SingleCount> res = new List<SingleCount>();
            int N = 1;
            res.Add(new SingleCount(1, 1, -1, AreaType.Trapezoid, 0, 1));
            res.Add(new SingleCount(1, 1, -1, AreaType.Rectangle, 0, 1));
        
            double x1 = 0;
            double x2 = Math.PI / 2.0;
            for (; N <= 10000; N++)
            {
                double area = TrapezLicz(x1, x2, N, f);
                //Console.WriteLine(Math.Abs(area - mustBe) + "    " + Math.Round(mustBe) / 100.0 * z);
                if (Math.Abs(area - mustBe) <= mustBe / 100.0 * z)
                {
                    res[0].N = N;
                    break;
                }
            }


            const string message = "Are you sure that you would like to continue? It can take a long time.";
            const string caption = "Form Continue";
            DialogResult result = DialogResult.No;
            if (res[0].N == -1)
            {
                result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if (result == DialogResult.No)
                {
                    return new ZadGlobal(res); ;
                }

            }

            while (true)
            {
                double area = TrapezLicz(x1, x2, N, f);
                //Console.WriteLine(Math.Abs(area - mustBe) + "    " + mustBe / 100.0 * z);
                if (Math.Abs(area - mustBe) <= mustBe / 100.0 * z)
                {
                    res[0].N = N;
                    break;
                }
                N++;
            }

            Console.WriteLine("-------------------------");

            N = 1;
            for (; N <= 10000; N++)
            {
                double area = ProstLicz(x1, x2, N, f);
                //Console.WriteLine(Math.Abs(area - mustBe) + "    " + Math.Round(mustBe) / 100.0 * z);
                if (Math.Abs(area - mustBe) <= mustBe / 100.0 * z)
                {
                    res[1].N = N;
                    return new ZadGlobal(res);
                }
                N++;
            }

            if (result == DialogResult.No)
            {
                result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if (result == DialogResult.No)
                    return new ZadGlobal(res);
            }


            while (true)
            {
                double area = ProstLicz(x1, x2, N, f);
                //Console.WriteLine(Math.Abs(area - mustBe) + "    " + Math.Round(mustBe) / 100.0 * z);
                if (Math.Abs(area - mustBe) <= mustBe / 100.0 * z)
                {
                    res[1].N = N;
                    break;
                }
                N++;
            }
            return new ZadGlobal(res);
        }

        public static ZadGlobal zadanie5(double k)
        {
            List<SingleCount> ls2 = new List<SingleCount>();
            List<SingleCount> ls3 = new List<SingleCount>();
            List<SingleCount> res = new List<SingleCount>();
            for (int i = 0;i <= 99;i++)
            {
                for (int j = i + 1; j <= 100; j++)
                {
                    ls2.Add(new SingleCount(i, j, Math.Round(ProstLicz(i, j, Math.Pow(10, k), x => x * x))));
                    ls3.Add(new SingleCount(i, j, Math.Round(ProstLicz(i, j, Math.Pow(10, k), x => x * x * x))));
                }
            }

            for (int i = 0; i < ls2.Count(); i++)
            {
                var g = ls3.Find(x => x.Area == ls2[i].Area);
                if (g != null && g.X1 != ls2[i].X1 && g.X2 != ls2[i].X2)
                {
                    res.Add(g);
                    res.Add(ls2[i]);
                    break;
                }
                    
            }

            ls2.Clear();
            ls3.Clear();
            //--------------------------------------------------------------------------------------------------
            for (int i = 0; i <= 99; i++)
            {
                for (int j = i + 1; j <= 100; j++)
                {
                    ls2.Add(new SingleCount(i, j, Math.Round(TrapezLicz(i, j, Math.Pow(10, k), x => x * x))));
                    ls3.Add(new SingleCount(i, j, Math.Round(TrapezLicz(i, j, Math.Pow(10, k), x => x * x * x))));
                }
            }

            for (int i = 0; i < ls2.Count(); i++)
            {
                var g = ls3.Find(x => x.Area == ls2[i].Area);
                if (g != null && g.X1 != ls2[i].X1 && g.X2 != ls2[i].X2)
                {
                    res.Add(g);
                    res.Add(ls2[i]);
                    break;
                }        
            }
            return new ZadGlobal(res);
        }

        public static ZadGlobal zadanie3(SingleCount el)
        {
            double trueRes = (Math.Pow(el.X2, 3) / 3) - (Math.Pow(el.X2, 3) / 3);
            List<SingleCount> res = new List<SingleCount>();
            double resTr = 0, resRg = 0;
            for (int i = 1; i <= 6; i++)
            {
                resTr += Math.Pow(trueRes - ZadObliczenia.TrapezLicz(el.X1, el.X2, (int)Math.Pow(10, i), x => x * x), 2);
                resRg += Math.Pow(trueRes - ZadObliczenia.ProstLicz(el.X1, el.X2, (int)Math.Pow(10, i), x => x * x), 2);
            }
            res.Add(new SingleCount(el.X1, el.X2, 6, AreaType.Trapezoid, Math.Round(Math.Sqrt(resTr / 6), 2), 1));
            res.Add(new SingleCount(el.X1, el.X2, 6, AreaType.Rectangle, Math.Round(Math.Sqrt(resRg / 6), 2), 1));
            return new ZadGlobal(res);
        }

        public static ZadGlobal zadanie4(double x1, double x2, double z, double k)
        {
            List<SingleCount> res = new List<SingleCount>();

            double fakeX1 = x1, fakeX2 = x2, resTr, resRg;
            do
            {
                resTr = ZadObliczenia.TrapezLicz(fakeX1, fakeX2, (int)Math.Pow(10, k), x => x * x * x);
                if (fakeX1 < fakeX2 - 1) fakeX1++;
                else fakeX2 += x2;
            } while (Math.Floor(resTr) % z != 0);

            res.Add(new SingleCount(fakeX1, fakeX2, resTr));

            fakeX1 = x1;
            fakeX2 = x2;
            do
            {
                resRg = ZadObliczenia.ProstLicz(fakeX1, fakeX2, (int)Math.Pow(10, k), x => x * x * x);
                if (fakeX1 < fakeX2 - 1) fakeX1++;
                else fakeX2 += x2;
            } while (Math.Floor(resRg) % z != 0);

            res.Add(new SingleCount(fakeX1, fakeX2, resRg));

            return new ZadGlobal(res);
        }
    }
}
