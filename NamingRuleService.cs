using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingtungCity.Culture.IMS.Service.Logic
{
    public class NamingRuleService
    {
        /// <summary>
        /// 測試函式
        /// </summary>
        /// <param name="index">索引參數</param>
        /// <returns></returns>
        public int TestFunction(int index)
        {
            switch (index)// bad
            {
                case 1: break;
                default: break;
            }

            switch (index)// good
            {
                case 1:
                    break;
                default:
                    break;
            }

            // bad
            if (index == 0) DoTrue();
            else
                DoFalse();

            // good 即使陳述區塊內僅有一行程式，也請使用大括號圈住，此規範包含if -else, for, foreach, while, do -while
            if (index == 0)
            {
                DoTrue();
            }
            else
            {
                DoFalse();
            }

            if (DoTrue() == true) { DoTrue(); }// bad
            if (DoTrue()) { DoTrue(); }// good 在條件陳述式中，不將布林變數與true/false作比較

            return (index * (index + 1) / 2);// bad
            return index * (index + 1) / 2;// good 回傳值本身不再使用括號
        }

        /// <summary>
        /// 為真
        /// </summary>
        /// <returns></returns>
        private bool DoTrue()
        {
            return true;
        }

        /// <summary>
        /// 為假
        /// </summary>
        /// <returns></returns>
        private bool DoFalse()
        {
            return false;
        }

        /// <summary>
        /// 測試字串函式
        /// </summary>
        /// <param name="value">字串參數</param>
        public void TestStringFunction(string value)
        {
            string NewString = "ABCDEFG"; //新字串 // bad
            string newString = "ABCDEFG"; // 新字串 // good 註解開始前先空一格，私有變數(Local Variable)使用 camelCasting 命名法(第一個單字字首小寫，其他單字字首大寫)

            if (value != null | value != "") value = NewString.Replace("A", ",").Replace("B", "_").Replace("C", " ");// bad

            if (!string.IsNullOrWhiteSpace(value))// good
            {
                value = new StringBuilder(newString).Replace("A", ",").Replace("B", "_").Replace("C", " ").ToString();
            }
        }

    }
}
