using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyLC
{
    /// <summary>
    /// Valid parenthesis.
    /// </summary>
    public class LC20
    {
        public bool IsValid(string s)
        {
            var parDict = new Dictionary<char, char>() { { ')', '(' }, { ']', '[' }, { '}', '{' } };
            var parStack = new Stack<char>();

            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{') parStack.Push(c);
                else
                {
                    if (parStack.Count == 0 || parDict[c] != parStack.Pop()) return false;
                }
            }
            return parStack.Count == 0;
        }
    }
}
