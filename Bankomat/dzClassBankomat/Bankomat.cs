using System;

namespace dzClassBankomat
{
    public class Bankomat
    {
        #region Fields
        private const string _addresBankomat = "Ул.Голубинская д.12";
        private float _virtualMoney;
        private string _firstName, _lastName, _otchestvo;
        private string _currentText = "Rub";
        private currencyType currentCurrency = currencyType.Rub;
        enum currencyType
        {
            Rub,
            Usd,
            Eur
        }
        #endregion

        #region Properties
        public float VirtualMoney
        {
            get { return _virtualMoney; }
            set
            {
                if (value > 0)
                {
                    _virtualMoney = value;
                }
                else
                    _virtualMoney += 0;
            }
        }
        #endregion

        #region Constructor
        public Bankomat(string firstName, string lastName, string otchestvo, float maneyCash)
        {
            _firstName = firstName;
            _lastName = lastName;
            _otchestvo = otchestvo;
            VirtualMoney = maneyCash;
        }


        #endregion

        #region Metod

        /// <summary>
        /// снятие денег с банкомата
        /// </summary>
        public void GiveMoney(float enterMoney)
        {
            VirtualMoney -= enterMoney;
            Information();
        }

        /// <summary>
        /// Зачисление денежных средств
        /// </summary>
        public void SetMoney(float enterMoney)
        {
            VirtualMoney += enterMoney;
            Information();
        }

        /// <summary>
        /// Перевод валюты
        /// </summary>
        public void Translate()
        {
            Console.WriteLine("Выберите валюту для перевода: \n 1-Рубль.\n 2-Долар. \n 3-Евро");
            int inputUser = Convert.ToInt32(Console.ReadLine());
            switch (inputUser)
            {
                case 1:
                    if (currentCurrency == currencyType.Usd)
                    {
                        VirtualMoney *= 77.82f;
                    }
                    else if(currentCurrency == currencyType.Eur)
                    {
                        VirtualMoney *= 86.64f;
                    }
                    currentCurrency = currencyType.Rub;
                    _currentText = "Rub";
                    break;
                case 2:
                    if (currentCurrency == currencyType.Rub)
                    {
                        VirtualMoney *= 0.012851f;
                    }
                    else if (currentCurrency == currencyType.Eur)
                    {
                        VirtualMoney *= 1.12f;
                    }
                    currentCurrency = currencyType.Usd;
                    _currentText = "Usd";
                    break;
                case 3:
                    if (currentCurrency == currencyType.Rub)
                    {
                        VirtualMoney *= 0.011542f;
                    }
                    else if (currentCurrency == currencyType.Usd)
                    {
                        VirtualMoney *= 0.89334f;
                    }
                    currentCurrency = currencyType.Eur;
                    _currentText = "Eur";
                    break;
            }
            Information();
        }

        public void Information()
        {
            Console.WriteLine($"на счету осталось {VirtualMoney} {_currentText}");
            Console.ReadKey();
        }
        #endregion
    }
}
