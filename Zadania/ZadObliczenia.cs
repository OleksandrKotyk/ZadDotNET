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

        public static ZadGlobal Zadanie1(int M, Func<double, double> f, double x1 = 0, double x2 = 100)
        {
            var now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            List<SingleCount> retList = new List<SingleCount>();
            for (int i = 0; i < M; i++)
            {
                int N = rnd.Next(10, 100000);
                double area = TrapezLicz(x1, x2, N, f);
                retList.Add(new SingleCount(x1, x2, N, AreaType.Trapezoid, area, i + 1));
                area = ProstLicz(x1, x2, N, f);
                retList.Add(new SingleCount(x1, x2, N, AreaType.Rectangle, area, i + 1));
                if(DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 500)
                    throw new TooLongEx(new ZadGlobal(retList), "Obliczenia zajęły za dużo czasu!");
            }
            return new ZadGlobal(retList);
        }

        public static ZadGlobal Zadanie2(Func<double, double> f, double z, double mustBe, out bool test1, out bool test2)
        {
            var now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            List<SingleCount> res = new List<SingleCount>();
            int N = 1;
            res.Add(new SingleCount(1, 1, -1, AreaType.Trapezoid, 0, 1));
            res.Add(new SingleCount(1, 1, -1, AreaType.Rectangle, 0, 1));

            double x1 = 0;
            double x2 = 100;
            test1 = false;
            test2 = false;
            bool ifThrow = false;

            while (true)
            {
                double area = TrapezLicz(x1, x2, N, f);
                if (Math.Round(Math.Abs(area - mustBe)) <= Math.Round(Math.Abs(mustBe / 100.0 * z)))
                {
                    if (Math.Floor(Math.Abs(area - mustBe)) == Math.Floor(Math.Abs(mustBe / 100.0 * z)))
                        test1 = true;
                    res[0].N = N;
                    break;
                }

                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 6000)
                {
                    ifThrow = true;
                    break;
                }
                N++;
            }
            

            now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            while (true)
            {
                double area = ProstLicz(x1, x2, N, f);
                if (Math.Round(Math.Abs(area - mustBe)) <= Math.Round(Math.Abs(mustBe / 100.0 * z)))
                {
                    if (Math.Floor(Math.Abs(area - mustBe)) == Math.Floor(Math.Abs(mustBe / 100.0 * z)))
                        test2 = true;
                    res[1].N = N;
                    break;
                }

                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 6000)
                {
                    ifThrow = true;
                    break;
                }
                N++;
            }
            if(ifThrow)
                throw new TooLongEx(new ZadGlobal(res), "Obliczenia zajęły za dużo czasu!");
            return new ZadGlobal(res);
        }

        public static ZadGlobal Zadanie6(double m, double k)
        {
            var now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            List<SingleCount> res = new List<SingleCount>();
            res.Add(new SingleCount(1, 1, -1, AreaType.Rectangle, double.MaxValue, 1));
            res.Add(new SingleCount(1, 1, -1, AreaType.Trapezoid, double.MaxValue, 1));
            for (double i = 0; i < m; i++)
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
                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 5000)
                    throw new TooLongEx(new ZadGlobal(res), "Obliczenia zajęły za dużo czasu!" + " m = " + (i+1).ToString());
            }
            return new ZadGlobal(res);
        }

        public static ZadGlobal Zadanie7(double z, double x1, double x2)
        {
            var now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            bool ifThrow = false;
            int N = 1;
            List<SingleCount> res = new List<SingleCount>();
            res.Add(new SingleCount(1, 1, -1, AreaType.Trapezoid, 0, 1));
            res.Add(new SingleCount(1, 1, -1, AreaType.Rectangle, 0, 1));

            while (true)
            {
                double area = TrapezLicz(x1, x2, N, x => x * x);
                if (Math.Floor(area) % z == 0)
                {
                    res[0].Area = area;
                    res[0].N = N;
                    break;
                }
                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 3000)
                {
                    ifThrow = true;
                    break;
                }
                N++;
            }

            
            now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            while (true)
            {
                double area = ProstLicz(x1, x2, N, x => x * x);
                if (Math.Floor(area) % z == 0)
                {
                    res[1].Area = area;
                    res[1].N = N;
                    break;
                }
                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 3000)
                {
                    ifThrow = true;
                    break;
                }
                N++;
            }
            
            if(ifThrow)
                throw new TooLongEx(new ZadGlobal(res), "Obliczenia zajęły za dużo czasu!");
            
            return new ZadGlobal(res);
        }
        public static ZadGlobal Zadanie8(Func<double, double> f, double z, double mustBe)
        {
            var now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            bool ifThrow = false;
            
            List<SingleCount> res = new List<SingleCount>();
            int N = 1;
            res.Add(new SingleCount(1, 1, -1, AreaType.Trapezoid, 0, 1));
            res.Add(new SingleCount(1, 1, -1, AreaType.Rectangle, 0, 1));
        
            double x1 = 0;
            double x2 = Math.PI / 2.0;

            while (true)
            {
                double area = TrapezLicz(x1, x2, N, f);
                //Console.WriteLine(Math.Abs(area - mustBe) + "    " + mustBe / 100.0 * z);
                if (Math.Abs(area - mustBe) <= mustBe / 100.0 * z)
                {
                    res[0].Area = area;
                    res[0].N = N;
                    break;
                }
                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 4000)
                {
                    ifThrow = true;
                    break;
                }
                N++;
            }
            
            
            now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            N = 1;
            while (true)
            {
                double area = ProstLicz(x1, x2, N, f);
                //Console.WriteLine(Math.Abs(area - mustBe) + "    " + Math.Round(mustBe) / 100.0 * z);
                if (Math.Abs(area - mustBe) <= mustBe / 100.0 * z)
                {
                    res[1].Area = area;
                    res[1].N = N;
                    break;
                }
                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 4000)
                {
                    ifThrow = true;
                    break;
                }
                N++;
            }
            
            if(ifThrow)
                throw new TooLongEx(new ZadGlobal(res), "Obliczenia zajęły za dużo czasu!");
            
            return new ZadGlobal(res);
        }

        public static ZadGlobal zadanie5(double k)
        {
            var now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            bool ifThrow = false;
            
            List<SingleCount> ls2 = new List<SingleCount>();
            List<SingleCount> ls3 = new List<SingleCount>();
            List<SingleCount> res = new List<SingleCount>();
            for (int i = 0;i <= 99;i++)
            {
                for (int j = i + 1; j <= 100; j++)
                {
                    ls2.Add(new SingleCount(i, j, Math.Round(ProstLicz(i, j, Math.Pow(10, k), x => x * x))));
                    ls3.Add(new SingleCount(i, j, Math.Round(ProstLicz(i, j, Math.Pow(10, k), x => x * x * x))));
                    if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 4000)
                    {
                        ifThrow = true;
                        break;
                    }
                }
            }
            
            if(ifThrow)
                throw new TooLongEx(new ZadGlobal(res), "Obliczenia zajęły za dużo czasu!");

            now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            for (int i = 0; i < ls2.Count(); i++)
            {
                var g = ls3.Find(x => x.Area == ls2[i].Area);
                if (g != null && g.X1 != ls2[i].X1 && g.X2 != ls2[i].X2)
                {
                    res.Add(g);
                    res.Add(ls2[i]);
                    break;
                }
                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 4000)
                {
                    ifThrow = true;
                    break;
                }
            }

            ls2.Clear();
            ls3.Clear();
            //--------------------------------------------------------------------------------------------------
            
            
            now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            for (int i = 0; i <= 99; i++)
            {
                for (int j = i + 1; j <= 100; j++)
                {
                    ls2.Add(new SingleCount(i, j, Math.Round(TrapezLicz(i, j, Math.Pow(10, k), x => x * x))));
                    ls3.Add(new SingleCount(i, j, Math.Round(TrapezLicz(i, j, Math.Pow(10, k), x => x * x * x))));
                    if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 4000)
                    {
                        ifThrow = true;
                        break;
                    }
                }
            }
            
            
            if(ifThrow)
                throw new TooLongEx(new ZadGlobal(res), "Obliczenia zajęły za dużo czasu!");

            now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            for (int i = 0; i < ls2.Count(); i++)
            {
                var g = ls3.Find(x => x.Area == ls2[i].Area);
                if (g != null && g.X1 != ls2[i].X1 && g.X2 != ls2[i].X2)
                {
                    res.Add(g);
                    res.Add(ls2[i]);
                    break;
                }     
                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 4000)
                {
                    ifThrow = true;
                    break;
                }
            }
            
            if(ifThrow)
                throw new TooLongEx(new ZadGlobal(res), "Obliczenia zajęły za dużo czasu!");
            
            return new ZadGlobal(res);
        }

        public static ZadGlobal zadanie3(SingleCount el)
        {
            double trueRes = (Math.Pow(el.X2, 3) / 3) - (Math.Pow(el.X2, 3) / 3);
            List<SingleCount> res = new List<SingleCount>();
            double resTr = 0, resRg = 0;
            var now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            for (int i = 1; i <= 6; i++)
            {
                resTr += Math.Pow(trueRes - ZadObliczenia.TrapezLicz(el.X1, el.X2, (int)Math.Pow(10, i), x => x * x), 2);
                resRg += Math.Pow(trueRes - ZadObliczenia.ProstLicz(el.X1, el.X2, (int)Math.Pow(10, i), x => x * x), 2);
                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 5000)
                    throw new TooLongEx(new ZadGlobal(res), "Obliczenia zajęły za dużo czasu!");
            }
            res.Add(new SingleCount(el.X1, el.X2, 6, AreaType.Trapezoid, Math.Round(Math.Sqrt(resTr / 6), 2), 1));
            res.Add(new SingleCount(el.X1, el.X2, 6, AreaType.Rectangle, Math.Round(Math.Sqrt(resRg / 6), 2), 1));
            return new ZadGlobal(res);
        }

        public static ZadGlobal zadanie4(double x1, double x2, double z, double k)
        {
            List<SingleCount> res = new List<SingleCount>();
            
            var now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            bool ifThrow = false;
            double fakeX1 = x1, fakeX2 = x2, resTr, resRg;
            do
            {
                resTr = ZadObliczenia.TrapezLicz(fakeX1, fakeX2, (int)Math.Pow(10, k), x => x * x * x);
                if(resTr < 0)
                    throw new Exception();
                if (fakeX1 < fakeX2 - 1) fakeX1++;
                else fakeX2 += x2;
                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 2000)
                {
                    ifThrow = true;
                    break;
                }
            } while (Math.Floor(resTr) % z != 0);

            if(!ifThrow)
                res.Add(new SingleCount(fakeX1, fakeX2, resTr));

            fakeX1 = x1;
            fakeX2 = x2;
            
            now  = DateTimeOffset.Now.ToUnixTimeMilliseconds();
            do
            {
                resRg = ZadObliczenia.ProstLicz(fakeX1, fakeX2, (int)Math.Pow(10, k), x => x * x * x);
                if(resRg < 0)
                    throw new Exception();
                if (fakeX1 < fakeX2 - 1) fakeX1++;
                else fakeX2 += x2;
                if (DateTimeOffset.Now.ToUnixTimeMilliseconds() - now > 2000)
                {
                    ifThrow = true;
                    break;
                }
            } while (Math.Floor(resRg) % z != 0);

            if (Math.Floor(resRg) % z == 0)
                res.Add(new SingleCount(fakeX1, fakeX2, resRg));
            
            if(ifThrow)
                throw new TooLongEx(new ZadGlobal(res), "Obliczenia zajęły za dużo czasu!");

            return new ZadGlobal(res);
        }
    }
}
