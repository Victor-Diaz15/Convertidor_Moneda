using Application.Enuns;
using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CurrencyService
    {
        public CurrencyService() { }

        public double CalculateCurrency(CurrenciesViewModel vm)
        {
            switch (vm.De)
            {
                case (int)Currencies.PESO:
                    if (vm.A == 1)
                    {
                        double peso = vm.Cantidad;
                        return Math.Round(peso, 2);
                    }
                    else if (vm.A == 2)
                    {
                        double dolar = vm.Cantidad * 0.01813;
                        return Math.Round(dolar, 2);
                    }
                    else
                    {
                        double euro = vm.Cantidad * 0.01695;
                        return Math.Round(euro, 2);
                    }
                case (int)Currencies.DOLAR:
                    if (vm.A == 1)
                    {
                        double peso = vm.Cantidad * 55.17000;
                        return Math.Round(peso, 2);
                    }
                    else if (vm.A == 2)
                    {
                        double dolar = vm.Cantidad;
                        return Math.Round(dolar, 2);
                    }
                    else
                    {
                        double euro = vm.Cantidad * 0.93565;
                        return Math.Round(euro, 2);
                    }
                case (int)Currencies.EURO:
                    if (vm.A == 1)
                    {
                        double peso = vm.Cantidad * 58.96570;
                        return Math.Round(peso, 2);
                    }
                    else if (vm.A == 2)
                    {
                        double dolar = vm.Cantidad * 1.06880;
                        return Math.Round(dolar, 2);
                    }
                    else
                    {
                        double euro = vm.Cantidad;
                        return Math.Round(euro, 2);
                    }
                default:
                    break;

            }
            return 0;
        }
    }
}
