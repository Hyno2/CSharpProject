using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 맛집API해보기
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
                Application.Run(new Login());
=======
            Login login = new Login();
            if(login.ShowDialog() == DialogResult.OK)
            {
                Form1 form1 = new Form1();
                Application.Run(new Form1());
>>>>>>> 47678d6a480fc802fdba62d9edcbe2f8c20ba068
            }
            
           
        }
    }
<<<<<<< HEAD

=======
}
>>>>>>> 47678d6a480fc802fdba62d9edcbe2f8c20ba068
