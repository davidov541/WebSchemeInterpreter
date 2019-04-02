using System;
using System.Collections.Generic;

/// <summary>
/// Class which will parse the incoming scheme code into an XML Document to be 
/// later.
/// </summary>
namespace Scheme
{
    public class Interpreter
    {

        private LinkedList<Object> _code;

        /// <summary>
        /// Default Constructor.
        /// </summary>
        public Interpreter()
        {
        }

        public LinkedList<Object> Code
        {
            get
            {
                return _code;
            }
            private set
            {
                _code = value;
            }
        }

        public void convertForScheme(String code)
        {
            String str = null;
            _code = convertList(code, out str);
        }

        private LinkedList<Object> convertList(String code, out String remainingcode)
        {
            String currword = null;
            String currcode = String.Copy(code);
            LinkedList<Object> parsedcode = new Pair<object>();
            char c = ' ';
            while (currcode != "" && currcode != null)
            {
                c = (currcode.ToCharArray())[0];
                currcode = currcode.Substring(1);
                if (c == ' ')
                {
                    parsedcode.AddLast(currword);
                    currword = null;
                }
                else if (c == '\'')
                {
                    if (!currcode.Contains("(") || !currcode.Contains(")"))
                    {
                        parsedcode.AddLast("quote");
                        parsedcode.AddLast(currcode);
                    }
                    else
                    {
                        parsedcode.AddLast(convertList("quote " + currcode, out currcode));
                        currword = null;
                    }
                }
                else if (c == '(')
                {
                    parsedcode.AddLast(convertList(currcode, out currcode));
                }
                else if (c == ')' && currword != null)
                {
                    parsedcode.AddLast(currword);
                    remainingcode = currcode;
                    return parsedcode;
                }
                else if (c == null)
                {
                    currcode = "";
                }
                else
                {
                    currword += c;
                }
            }
            remainingcode = null;
            return parsedcode;
        }

        public String representList(LinkedList<Object> linkedList)
        {
            LinkedListNode<Object> node = linkedList.First;
            String returnable = null;
            while (node != null)
            {
                if (node != null && typeof(LinkedList<Object>) == node.Value.GetType())
                {
                    returnable += "(" + representList((LinkedList<Object>)node.Value) + ") ";
                    node = node.Next;
                }
                else if ((String)node.Value == "quote")
                {
                    if (node.Next.Value.GetType() == typeof(string))
                    {
                        returnable += "(quote " + node.Next.Value + ")";
                    }
                    else
                    {
                        returnable += "quote (" + representList((LinkedList<Object>)node.Next.Value) + ")";
                    }
                    node = node.Next.Next;
                }
                else
                {
                    returnable += node.Value + " ";
                    node = node.Next;
                }
            }
            return returnable;
        }
    }
}