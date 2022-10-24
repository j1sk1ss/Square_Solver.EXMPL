using System;
using System.Windows;
using Square_Solver.EXMPL.SCRIPTS;

namespace Square_Solver.EXMPL {
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
        }
        private void Calculate(object sender, RoutedEventArgs e) {
            try {
                SquareSolver solver = new(double.Parse( $"{VariableA.Text}"), double.Parse( $"{BCof.Text}{VariableB.Text}"),
                    double.Parse($"{CCof.Text}{VariableC.Text}"));
                solver.Calculate();
                FirstUpperAnswer.Content = -solver.B - solver.D;
                FirstDownerAnswer.Content = solver.A * 2 + " ";
                SecondUpperAnswer.Content = -solver.B + solver.D;
                SecondDownerAnswer.Content = solver.A * 2 + " ";
                AnswerSection.Visibility = Visibility.Visible;
                AnswerLabelOne.Content = "РЕШЕНИЕ:";
                if (solver.SecondValue != 0) {
                    Answer1.Content = solver.FirstValue;
                    Answer2.Content = solver.SecondValue;
                }
                else {
                    Answer1.Content = solver.FirstValue;
                    SecondExample.Visibility = Visibility.Hidden;
                    SecondValue.Visibility = Visibility.Hidden;
                }
            }
            catch (Exception exception) {
                MessageBox.Show($"{exception}", "Ошибка!", MessageBoxButton.OK, MessageBoxImage.Error);
                AnswerSection.Visibility = Visibility.Hidden;
                AnswerLabelOne.Content = "";
            }
        }
    }
}