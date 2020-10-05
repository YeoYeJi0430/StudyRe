using StockSystem.Sub;
using System;
using System.Windows.Forms;

namespace StockSystem
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());      //서치폼 확인
                                                    //Application.Run(new SearchForm());
        }
    }
}
