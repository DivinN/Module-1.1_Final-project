using Module_1._1_Final_project.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Module_1._1_Final_project.ViewModels
{
    internal class MainWindowViewModel : INotifyPropertyChanged
    {
        // Событие изменения свойства
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        #region input field description
        // Поле и свойство класса, описывающее содержимое поля ввода
        private string formula = "";
        public string Formula
        {
            get => formula;
            set
            {
                formula = value;
                OnPropertyChanged();
            }
        }
        #endregion


        // Возможность добавления знаков в поле ввода
        private bool CanAddNumsCommandExecute(object p)
        {
            return true;
        }
        // Возможность запуска функции расчета
        private bool CanResultCommandExecute(object p)
        {
            bool flag = false;
            string formulaValue = Formula;
            if (formulaValue.Length > 0)
            {
                char[] formulaValueInCh = formulaValue.ToCharArray();
                for (int i = 0; i < formulaValueInCh.Length; i++)
                {
                    if (char.IsDigit(formulaValueInCh[i]) || formulaValueInCh[i] == ',' 
                        || formulaValueInCh[i] == '.' 
                        || formulaValueInCh[i] == '+' 
                        || formulaValueInCh[i] == '-'
                        || formulaValueInCh[i] == '*'
                        || formulaValueInCh[i] == '/')
                    {
                        flag = false;
                    }
                    else
                    {
                        flag = true;
                        break;
                    }
                }
            }
            if (flag == true)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #region Number 1
        // Добавить знак "1" в поле ввода
        public ICommand Num1_AddCommand { get; }
        private void OnNum1_AddCommand(object p)
        {
            Formula = Formula + "1";
        }
        #endregion
        #region Number 2
        // Добавить знак "2" в поле ввода
        public ICommand Num2_AddCommand { get; }
        private void OnNum2_AddCommand(object p)
        {
            Formula = Formula + "2";
        }
        #endregion
        #region Number 3
        // Добавить знак "3" в поле ввода
        public ICommand Num3_AddCommand { get; }
        private void OnNum3_AddCommand(object p)
        {
            Formula = Formula + "3";
        }
        #endregion
        #region Number 4
        // Добавить знак "4" в поле ввода
        public ICommand Num4_AddCommand { get; }
        private void OnNum4_AddCommand(object p)
        {
            Formula = Formula + "4";
        }
        #endregion
        #region Number 5
        // Добавить знак "5" в поле ввода
        public ICommand Num5_AddCommand { get; }
        private void OnNum5_AddCommand(object p)
        {
            Formula = Formula + "5";
        }
        #endregion
        #region Number 6
        // Добавить знак "6" в поле ввода
        public ICommand Num6_AddCommand { get; }
        private void OnNum6_AddCommand(object p)
        {
            Formula = Formula + "6";
        }
        #endregion
        #region Number 7
        // Добавить знак "7" в поле ввода
        public ICommand Num7_AddCommand { get; }
        private void OnNum7_AddCommand(object p)
        {
            Formula = Formula + "7";
        }
        #endregion
        #region Number 8
        // Добавить знак "8" в поле ввода
        public ICommand Num8_AddCommand { get; }
        private void OnNum8_AddCommand(object p)
        {
            Formula = Formula + "8";
        }
        #endregion
        #region Number 9
        // Добавить знак "9" в поле ввода
        public ICommand Num9_AddCommand { get; }
        private void OnNum9_AddCommand(object p)
        {
            Formula = Formula + "9";
        }
        #endregion
        #region Number 0
        // Добавить знак "0" в поле ввода
        public ICommand Num0_AddCommand { get; }
        private void OnNum0_AddCommand(object p)
        {
            Formula = Formula + "0";
        }
        #endregion

        #region Symbol +
        // Добавить знак "+" в поле ввода
        public ICommand Plus_AddCommand { get; }
        private void OnPlus_AddCommand(object p)
        {
            // Проверяем, не поставим ли мы арифм знак после другого арифм знака, если да, заменим
            if (Formula.Length > 0)
            {
                char last = Formula.Last();
                if (!char.IsDigit(last))
                {
                    Formula = Formula.Substring(0, Formula.Length - 1);
                }
            }

            Formula = Formula + "+";
        }
        #endregion
        #region Symbol -
        // Добавить знак "-" в поле ввода
        public ICommand Minus_AddCommand { get; }
        private void OnMinus_AddCommand(object p)
        {
            // Проверяем, не поставим ли мы арифм знак после другого арифм знака, если да, заменим
            if (Formula.Length > 0)
            {
                char last = Formula.Last();
                if (!char.IsDigit(last))
                {
                    Formula = Formula.Substring(0, Formula.Length - 1);
                }
            }

            Formula = Formula + "-";
        }
        #endregion
        #region Symbol *
        // Добавить знак "*" в поле ввода
        public ICommand Multiply_AddCommand { get; }
        private void OnMultiply_AddCommand(object p)
        {
            // Проверяем, не поставим ли мы арифм знак после другого арифм знака, если да, заменим
            if (Formula.Length > 0)
            {
                char last = Formula.Last();
                if (!char.IsDigit(last))
                {
                    Formula = Formula.Substring(0, Formula.Length - 1);
                }
            }

            Formula = Formula + "*";
        }
        #endregion
        #region Symbol /
        // Добавить знак "/" в поле ввода
        public ICommand Divide_AddCommand { get; }
        private void OnDivide_AddCommand(object p)
        {
            // Проверяем, не поставим ли мы арифм знак после другого арифм знака, если да, заменим
            if (Formula.Length > 0)
            {
                char last = Formula.Last();
                if (!char.IsDigit(last))
                {
                    Formula = Formula.Substring(0, Formula.Length - 1);
                }
            }

            Formula = Formula + "/";
        }
        #endregion

        #region Delete
        // Выполнить очистку поля для ввода
        public ICommand DeleteCommand { get; }
        private void OnDeleteCommand(object p)
        {
            Formula = "";
        }
        #endregion
        #region Result
        // Выполнить подсчет результата по выражению из поля ввода
        public ICommand ResultCommand { get; }
        private void OnResultCommand(object p)
        {
            if (Formula.Length > 0)
            {
                string formulaValue = Formula;
                // DataTable не работает с , поэтому заменим все , на .
                if (Formula.Contains(","))
                {
                    formulaValue = formulaValue.Replace(",", ".");
                }
                // Проверим,что последний символ поля ввода - цифра
                char last = formulaValue.Last();
                if (char.IsDigit(last))
                {
                    string val = new DataTable().Compute(formulaValue, null).ToString();
                    Formula = val;
                }
            }
        }
        #endregion

        #region Off
        // Выключение калькулятора
        public ICommand OffCommand { get; }
        private void OnOffCommand(object p)
        {
            System.Windows.Application.Current.Shutdown();
        }
        #endregion
        #region DeleteLast
        // Удаление последнего символа из поля ввода
        public ICommand DeleteLastCommand { get; }
        private void OnDeleteLastCommand(object p)
        {
            if (Formula.Length > 0)
            {
                Formula = Formula.Substring(0, Formula.Length - 1);
            }
        }
        #endregion
        #region Symbol ,
        // Добавить знак "," в поле ввода
        public ICommand Dot_AddCommand { get; }
        private void OnDot_AddCommand(object p)
        {
            if (Formula.Length > 0)
            {
                char last = Formula.Last();
                if (last == ',')
                {
                    Formula = Formula.Substring(0, Formula.Length - 1);
                    Formula = Formula + ",";
                }
                if (char.IsDigit(last))
                {
                    Formula = Formula + ",";
                }
            }
        }
        #endregion



        public MainWindowViewModel()
        {
            Num1_AddCommand = new RelayCommand(OnNum1_AddCommand, CanAddNumsCommandExecute);
            Num2_AddCommand = new RelayCommand(OnNum2_AddCommand, CanAddNumsCommandExecute);
            Num3_AddCommand = new RelayCommand(OnNum3_AddCommand, CanAddNumsCommandExecute);
            Num4_AddCommand = new RelayCommand(OnNum4_AddCommand, CanAddNumsCommandExecute);
            Num5_AddCommand = new RelayCommand(OnNum5_AddCommand, CanAddNumsCommandExecute);
            Num6_AddCommand = new RelayCommand(OnNum6_AddCommand, CanAddNumsCommandExecute);
            Num7_AddCommand = new RelayCommand(OnNum7_AddCommand, CanAddNumsCommandExecute);
            Num8_AddCommand = new RelayCommand(OnNum8_AddCommand, CanAddNumsCommandExecute);
            Num9_AddCommand = new RelayCommand(OnNum9_AddCommand, CanAddNumsCommandExecute);
            Num0_AddCommand = new RelayCommand(OnNum0_AddCommand, CanAddNumsCommandExecute);

            Plus_AddCommand = new RelayCommand(OnPlus_AddCommand, CanAddNumsCommandExecute);
            Minus_AddCommand = new RelayCommand(OnMinus_AddCommand, CanAddNumsCommandExecute);
            Multiply_AddCommand = new RelayCommand(OnMultiply_AddCommand, CanAddNumsCommandExecute);
            Divide_AddCommand = new RelayCommand(OnDivide_AddCommand, CanAddNumsCommandExecute);
            
            DeleteCommand = new RelayCommand(OnDeleteCommand, CanAddNumsCommandExecute);
            ResultCommand = new RelayCommand(OnResultCommand, CanResultCommandExecute);

            OffCommand = new RelayCommand(OnOffCommand, CanAddNumsCommandExecute);
            DeleteLastCommand = new RelayCommand(OnDeleteLastCommand, CanAddNumsCommandExecute);
            Dot_AddCommand = new RelayCommand(OnDot_AddCommand, CanAddNumsCommandExecute);
        }

    }
}
