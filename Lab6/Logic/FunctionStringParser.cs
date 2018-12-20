using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logic.MyFunction;

namespace Logic
{
   public class FunctionStringParser
    {
        public string Function { get; set; }
        public FunctionStringParser (string function)
        {
            Function = function;
        }

        public MyFunction ParseFunction ()
        {
            string[] s = Function.Split('+', '-');//не забыть стереть
            string stringKX, stringKY, stringC;

            foreach (string str in s)
            {
                if (str.Contains("x"))
                {
                    stringKX = str.Remove(str.IndexOf('*'));
                }
                else if (str.Contains("y"))
                {
                    stringKY = str.Remove(str.IndexOf('*'));
                }
                else stringC = str;
            }
            s = Function.Split('+', '-');
            string stringX, stringY;
            foreach (string str in s)
            {
                if (str.Contains("x"))
                {
                    stringX = str.Remove(0, str.IndexOf('*') + 1);
                }
                else if (str.Contains("y"))
                {
                    stringY = str.Remove(0, str.IndexOf('*') + 1);
                }
            }

            throw new NotImplementedException();
        }

        public ActionForParam GetAction(string action)
        {
            action = action.Trim(' ');
            if (action.Contains("sin"))
            {
               // double pow = Convert.ToDouble(action.Remove(0,action.IndexOf('^')+1));

                return new ActionForParam(Math.Sin);
            }

            throw new NotImplementedException();
        }
    }
}
