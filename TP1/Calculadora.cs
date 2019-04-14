using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp01
{
    class Calculadora
    {
        #region metodos
        /// <summary>
        /// Metodo que opera entre los dos numeros ingresados
        /// </summary>
        /// <param name="numero1">tipo Numero</param>
        /// <param name="numero2">tipo Numero</param>
        /// <param name="operador">caracter de operacion</param>
        /// <returns>Valor a mostrar</returns>
        public double Operar(Numero numero1, Numero numero2, string operador)
        {

            double resultado = 0;            
            if (operador == "+")
            {
                resultado = numero1 + numero2;
            }
            if (operador == "-")
            {
                resultado = numero1 - numero2;
            }
            if (operador == "*")
            {
                resultado = numero1 * numero2;
            }
            if (operador == "/")
            {
                resultado = numero1 / numero2;
                if (numero2 == 0D)
                {
                    resultado = 0D;
                }                
            }
            
            return resultado;
        }

        /// <summary>
        /// valida que el caracter de operacion sea logico
        /// </summary>
        /// <param name="operador">caracter de operacion</param>
        /// <returns>caracter de operacion validado</returns>
        public string ValidarOperador(string operador)
        {
            string retorno = "+";
            if (operador != "-" && operador != "*" && operador != "/" && operador != "+")
            {
                return retorno;
            }
            
            if (operador == "-")
            {
                retorno = "-";
            }
            if (operador == "*")
            {
                retorno = "*";
            }
            if (operador == "/")
            {
                retorno = "/";
            }
            
            return retorno;
        }
        # endregion
    }
}
