using System;
using System.Windows.Forms;

namespace 不同的语言数据库
{
    internal static class Program
    {
        [STAThread]
        //Esta es mi instancia de mi form
        static void Main()
        {
            shujuku data_base = new shujuku("翻译");
            Application.Run(data_base);
        }
    }
}