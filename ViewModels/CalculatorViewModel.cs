using CommunityToolkit.Mvvm.ComponentModel;
using PAMCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PAMCalculator.ViewModels
{
    public partial class CalculatorViewModel : ObservableObject
    {
        [ObservableProperty]
        private double primeiroTermo;
        [ObservableProperty]
        private double segundoTermo;
        [ObservableProperty]
        private double resultado;


        public CalculatorViewModel() //Construtor 
        {
            SomarCommand = new Command(Somar);
            SubtrairCommand = new Command(Subtrair);
            MultiplicarCommand = new Command(Multiplicar);
            DividirCommand = new Command(Dividir);
            ElevarCommand = new Command(Elevar);
            RaizCommand = new Command(Raiz);
        }


        //SOMA
        public ICommand SomarCommand { get; }
        public void Somar()
        {
            //deu certo

            Resultado = new Calculator().Somar(PrimeiroTermo, SegundoTermo);
        }

        //=============================================================================
        //SUBTRAÇÃO
        public ICommand SubtrairCommand { get; }
        public void Subtrair()
        {
            //deu certo
            Resultado = new Calculator().Subtrair(PrimeiroTermo, SegundoTermo);
        }

        //=============================================================================

        //MULTIPLICAÇÃO
        public ICommand MultiplicarCommand { get; }
        public void Multiplicar()
        {
            //deu certo
            Resultado = new Calculator().Multiplicar(PrimeiroTermo, SegundoTermo);
        }

        //=============================================================================

        //DIVISÃO
        public ICommand DividirCommand { get; }
        public void Dividir()
        {
            //deu certo
            Resultado = new Calculator().Dividir(PrimeiroTermo, SegundoTermo);
        }

        //=============================================================================

        //POTÊNCIA
        public ICommand ElevarCommand { get; }
        public void Elevar()
        {
            //deu certo
            Resultado = new Calculator().Elevar(PrimeiroTermo, SegundoTermo);
        }

        //=============================================================================

        //RAÍZ
        public ICommand RaizCommand { get; }
        public void Raiz()
        {
            //deu certo
            Resultado = new Calculator().Raiz(PrimeiroTermo, SegundoTermo);
        }


    }
}