using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharpConsole
{
    public class Program
    {
        [STAThread]
        public static int Main(string[] args)
        {
            Program program = new Program();
            return program.Execute(args);
        }

        private TextWriter _out = System.Console.Out;
        public TextWriter Out
        {
            get { return _out; }
        }
        private TextWriter _error = System.Console.Error;
        public TextWriter Error
        {
            get { return _error; }
        }
        public int Execute(string[] args)
        {
            return 0;
        }
    }
}
