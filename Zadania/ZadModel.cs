using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{

    public enum AreaType
    {
        Rectangle,
        Trapezoid
    }
    public class SingleCount
    {
        public double X1 { get; set; }
        public double X2 { get; set; }
        public int N { get; set; }
        public AreaType AreaType { get; set; }
        public double Area { get; set; }
        public int CalculationNumber { get; set; }
        public int LowestN { get; set; }
        public double MinSquareError { get; set; }

        public SingleCount() { }
        public SingleCount(double x1, double x2, int n, AreaType areaType, double area, int calcNumber) 
        {
            this.X1 = x1;
            this.X2 = x2;
            this.N = n;
            this.AreaType = areaType;
            this.Area = area;
            this.CalculationNumber = calcNumber;
        }

        public SingleCount(double x1, double x2, int n, AreaType areaType, double area, int calcNumber, int lowestN)
        {
            this.X1 = x1;
            this.X2 = x2;
            this.N = n;
            this.AreaType = areaType;
            this.Area = area;
            this.CalculationNumber = calcNumber;
            this.LowestN = lowestN;
        }

        public SingleCount(double x1, double x2, double area)
        {
            this.X1 = x1;
            this.X2 = x2;
            this.Area = area;
        }

    }

    public class ZadGlobal
    {
        public List<SingleCount> ListOfSingleCount { get; set; }

        public ZadGlobal() { }
        public ZadGlobal(List<SingleCount> listOfSingleCount)
        {
            this.ListOfSingleCount = listOfSingleCount;
        }
    }

   
}
