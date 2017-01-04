using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client.Common
{
    /// <summary>
    /// NumericUpDown控件的帮助类
    /// </summary>
    public class NumericUpDownHelper
    {

        public enum 数值控件模式
        {
            整型 = 0,
            一位小数 = 1,
            二位小数 = 2,
            三位小数 = 3,
        }

        public static void initNumericUpDown(NumericUpDown nud, 数值控件模式 type)
        {
            nud.Minimum = 0;     //设置允许的最小值 
            nud.Maximum = int.MaxValue;   //设置允许的最大值 
            nud.InterceptArrowKeys = true;    //允许通过上下箭头调整值


            switch (type)
            {
                case 数值控件模式.整型:
                    {
                        nud.DecimalPlaces = 0;   //设置小数点的位数为0位 
                        nud.Increment = 1;       //设置步长为1 
                    }
                    break;
                case 数值控件模式.一位小数:
                    {
                        nud.DecimalPlaces = 1;   //设置小数点的位数为1位 
                        nud.Increment = (decimal)0.1;       //设置步长为1 
                    }
                    break;
                case 数值控件模式.二位小数:
                    {
                        nud.DecimalPlaces = 2;   //设置小数点的位数为2位 
                        nud.Increment = (decimal)0.01;       //设置步长为0.01
                    }
                    break;
                case 数值控件模式.三位小数:
                    {
                        nud.DecimalPlaces = 3;   //设置小数点的位数为3位 
                        nud.Increment = (decimal)0.001;       //设置步长为0.001
                    }
                    break;
                default:
                    {
                        throw new Exception("没有此模式");
                    }
            }
        }


    }
}
