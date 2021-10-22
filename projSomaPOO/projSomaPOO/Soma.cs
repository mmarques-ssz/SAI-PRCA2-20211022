using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projSomaPOO
{
    class Soma
    {
        #region atributos
        private int num1;
        private int num2;
        private int resultado;
        #endregion

        #region métodos de interface (Setter's & Getter's)
        public void setNum1(int n)
        {
            num1 = n;
        }

        public void setNum2(int n)
        {
            num2 = n;
        }

        public int getNum1()
        {
            return num1;
        }

        public int getNum2()
        {
            return num2;
        }

        public int getResultado()
        {
            return resultado;
        }
        #endregion

        #region métodos funcionais
        public void calcular()
        {
            resultado = num1 + num2;
        }
        #endregion
    }
}
