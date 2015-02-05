using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Test
{
    [StructLayout(LayoutKind.Sequential)]
    public class InitInfo
    {
        public int size;
        public int game_id;
        public IntPtr send_data_to_svr;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#!");
            Console.WriteLine("IntPtr Size:{0}", IntPtr.Size);

            InitInfo init_info = new InitInfo();
            Console.WriteLine("{0}", Marshal.SizeOf(init_info));
        }
    }
}
