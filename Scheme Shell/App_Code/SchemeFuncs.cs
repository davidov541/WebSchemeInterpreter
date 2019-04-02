using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Collections;

/// <summary>
/// Static class of functions derived from Scheme in order to aid in reading and using
/// scheme code entered by the user into the console.
/// </summary>
namespace Scheme
{
    public static class SchemeFuncs
    {

        /// <summary>
        /// Static method to represent the car procedure in scheme.
        /// </summary>
        /// <param name="code">Represents input which will be cared.</param>
        /// <returns>Returns first element in list alone.</returns>
        public static LinkedListNode<object> car(LinkedList<object> code)
        {
            return code.First;
        }

        /// <summary>
        /// Static method to represent cdr procedure in scheme.
        /// </summary>
        /// <param name="code">Represents input which will be cdred.</param>
        /// <returns>Returns all elements except for the first in a list format.</returns>
        public static LinkedList<object> cdr(LinkedList<object> code)
        {
            return code.First.remove();
        }

        /// <summary>
        /// Represents symbol? procedure in scheme, and checks according to the symbol rules 
        /// in Chez Scheme.
        /// </summary>
        /// <param name="code">String which will be checked to see if it is a symbol.</param>
        /// <returns>Returns boolean indicating if the string is indeed a symbol.</returns>
        public static Boolean symbol(String code)
        {
            if (code == "+" || code == "-" || code == "*" || code == "\\")
            {
                return true;
            }
            return false;
        }
    }
}