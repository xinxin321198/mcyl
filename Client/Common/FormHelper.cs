using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Common
{
    /// <summary>
    /// winform的帮助类
    /// </summary>
    public class FormHelper
    {

        public static readonly string INIT_ERROR = "此类空的构造方法已禁用，请调用重载的构造方法";

        private static void initFormCommon(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;//起始位置在屏幕中间
            form.KeyPreview = true;
        }


        /// <summary>
        /// 初始化winform的一些参数
        /// </summary>
        /// <param Name="form"></param>
        public static void initForm(Form form)
        {
            initFormCommon(form);
            form.AutoScroll = true;
        }

        /// <summary>
        /// 初始化winfrom的一些参数，以工具窗体的形式
        /// </summary>
        /// <param name="form"></param>
        public static void initFormForToolWindow(Form  form)
        {
            initFormCommon(form);
            form.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            form.ShowInTaskbar = false;
        }


        /// <summary>
        /// 根据窗体的完全限定名及参数创建窗体的实例
        /// </summary>
        /// <param name="formName"></param>
        /// <param name="objs"></param>
        /// <returns></returns>
        public static Form CreateWinForm(string formName, object[] objs)
        {
            //反射可以有很多方法，编写程序时请先导入 System.Reflection 命名空间，假设你要反射一个 DLL 中的类，并且没有引用它（即未知的类型）： 
            //Assembly assembly = Assembly.LoadFile("程序集路径，不能是相对路径"); // 加载程序集（EXE 或 DLL） 
            //object obj = assembly.CreateInstance("类的完全限定名（即包括命名空间）"); // 创建类的实例 

            //若要反射当前项目中的类可以为： 

            //Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
            //object obj = assembly.CreateInstance("类的完全限定名（即包括命名空间）"); // 创建类的实例，返回为 object 类型，需要强制类型转换 

            //也可以为： 
            //Type type = Type.GetType("类的完全限定名"); 
            //object obj = type.Assembly.CreateInstance(type); 
            if (null == formName)
            {
                throw new Exception("创建窗体对象请输入正确的窗体完全限定名");
            }
            Assembly assembly = Assembly.GetExecutingAssembly(); // 获取当前程序集 
            object obj = assembly.CreateInstance(formName, false, BindingFlags.CreateInstance, null, objs, null, null);
            Form form = (Form)obj;
            return form;
        }

        #region
        //窗体弹出或消失效果start
        [DllImport("user32.dll", EntryPoint = "AnimateWindow")]
        private static extern bool AnimateWindow(IntPtr handle, int ms, int flags);
        private const Int32 AW_HOR_POSITIVE = 0x00000001;
        private const Int32 AW_HOR_NEGATIVE = 0x00000002;
        private const Int32 AW_VER_POSITIVE = 0x00000004;
        private const Int32 AW_VER_NEGATIVE = 0x00000008;
        private const Int32 AW_CENTER = 0x00000010;
        private const Int32 AW_HIDE = 0x00010000;
        private const Int32 AW_ACTIVATE = 0x00020000;
        private const Int32 AW_SLIDE = 0x00040000;
        private const Int32 AW_BLEND = 0x00080000;
        /// <summary>
        /// 关闭窗口(作废)
        /// </summary>
        /// <param Name="form"></param>
        public static void closeForm(Form thisForm)
        {
            //if (null != main)
            //{
            //    //main.FormList.Remove(thisForm);
            //}

            //窗体弹出效果
            AnimateWindow(thisForm.Handle, 300, AW_HIDE + AW_CENTER);
        }

        #endregion
    }
}
