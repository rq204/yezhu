using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace Lv.Winform
{
    public class AppStart
    {
        static AppStart()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);//设置非窗体异常是否捕获或抛出模式
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }

        //关于异常处理：http://hi.baidu.com/zionking/blog/item/d6e28fdf5a5438b3cc11662d.html
        /// <summary>
        /// 非UI线程异常，UnhandledException提供的机制并不能阻止应用程序终止，记录到异常后，应用程序就会被终止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = e.ExceptionObject as Exception;
            if (exception == null)
            {
                return;
            }
            MessageBox.Show(exception.Message + "\r\n" + exception.StackTrace, "线程异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// UI线程异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            MessageBox.Show(e.Exception.Message + "\r\n" + e.Exception.StackTrace, "UI线程异常", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary> 
        /// 该函数设置由不同线程产生的窗口的显示状态。 
        /// </summary> 
        /// <param name="hWnd">窗口句柄</param> 
        /// <param name="cmdShow">指定窗口如何显示。查看允许值列表，请查阅ShowWlndow函数的说明部分。</param> 
        /// <returns>如果函数原来可见，返回值为非零；如果函数原来被隐藏，返回值为零。</returns> 
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        /// <summary> 
        /// 该函数将创建指定窗口的线程设置到前台，并且激活该窗口。键盘输入转向该窗口，并为用户改各种可视的记号。系统给创建前台窗口的线程分配的权限稍高于其他线程。 
        /// </summary> 
        /// <param name="hWnd">将被激活并被调入前台的窗口句柄。</param> 
        /// <returns>如果窗口设入了前台，返回值为非零；如果窗口未被设入前台，返回值为零。</returns> 
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        private const int WS_SHOWNORMAL = 1;



        /// <summary> 
        /// 获取正在运行的实例，没有运行的实例返回null; 
        /// </summary> 
        public static System.Diagnostics.Process RunningInstance(bool onlyOne = false)
        {
            try
            {
                System.Diagnostics.Process current = System.Diagnostics.Process.GetCurrentProcess();
                System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcessesByName(current.ProcessName);
                foreach (System.Diagnostics.Process process in processes)
                {
                    try
                    {
                        if (process.Id != current.Id)
                        {
                            if (process.MainModule.FileName == current.MainModule.FileName)
                            {
                                return process;
                            }
                            else if (onlyOne)
                            {
                                return process;
                            }
                        }
                    }
                    catch { }
                }
            }
            catch { }
            return null;
        }



        /// <summary> 
        /// 显示已运行的程序。 
        /// </summary> 
        public static void HandleRunningInstance(System.Diagnostics.Process instance)
        {
            ShowWindowAsync(instance.MainWindowHandle, WS_SHOWNORMAL); //显示，可以注释掉 
            SetForegroundWindow(instance.MainWindowHandle);            //放到前端 
        }
    }
}
