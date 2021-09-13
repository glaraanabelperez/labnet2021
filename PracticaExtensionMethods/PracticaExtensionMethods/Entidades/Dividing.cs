﻿using System;

using PracticaExtensionMethods.ExtensionMethodsHelpers;

namespace PracticaExtensionMethods.Clases
{
    public class Dividing : DividingForZero
    {
        public Dividing()
        {

        }
        public override void MessageResult(String tipMessage)
        {
            if (tipMessage.Equals("FormatException"))
            {
                Message = $"Seguro Ingreso una letra o no ingreso nada!, {Message}";
                
            }
            if (tipMessage.Equals("DivideByZeroException"))
            {
                Message = $"Solo Chuck Norris divide por cero!, {Message}";
            }
            if (tipMessage.Equals("FormatExceptionOK"))
            {
                Message = "Datos Correctos";
            }

        }

        public override int[] ConversionStringToNumber(string entrada)
        {
            int[] resultConvertion = new int[2];

            try
            {
                resultConvertion = entrada.ConversionStringToNumber();
            }
            catch (FormatException ex)
            {
                Message = ex.Message;
                this.MessageResult("FormatException");
            }

            return resultConvertion;
        }

        public override int CalculateDivisions(int dividend, int divisor)
        {
            return divisor.DividingAndCatchingException(dividend);
        }

    }
}
