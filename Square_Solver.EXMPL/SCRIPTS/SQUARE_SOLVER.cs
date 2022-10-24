using System;
using System.Windows;

namespace Square_Solver.EXMPL.SCRIPTS
{
    public class SquareSolver
    {
        public double D { get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double FirstValue { get; set; }
        public double SecondValue { get; set; }
        public SquareSolver() {
            A = 0;
            B = 0;
            C = 0;
        }
        public SquareSolver(double a, double b, double c) {
            A = a;
            B = b;
            C = c;
        }
        public void Calculate() {
            D = B * B - 4 * A * C;
            switch (D) {
                case 0:
                    FirstValue = Math.Round((-B - Math.Sqrt(D)) / (2 * A), 5);
                    MessageBox.Show("Корень только один!", "Предупреждение.", MessageBoxButton.OK);
                    return;
                case < 0:
                    MessageBox.Show("Корней нет!", "Предупреждение.", MessageBoxButton.OK);
                    return;
                default:
                    FirstValue = Math.Round((-B - Math.Sqrt(D)) / (2 * A), 5);
                    SecondValue = Math.Round((-B + Math.Sqrt(D)) / (2 * A), 5);
                    break;
            }
        }
    }
}