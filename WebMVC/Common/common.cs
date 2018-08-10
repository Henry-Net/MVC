using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Common
{
    public class common
    {
        #region 获取MD5加密
        public static string GetMD5Code(string input) 
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] data = md5.ComputeHash(Encoding.Default.GetBytes(input));
            //正常加密  每个数组元素转换16进制数字
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            ////混淆加密  每个数组元素转换16进制数字 + henry 
            //StringBuilder sBuilder = new StringBuilder();
            //for (int i = 0; i < data.Length; i++)
            //{
            //    sBuilder.Append(data[i].ToString("x2") + "henry");
            //}

            //正常加密  通过BitConverter转换为string类型  但是会生成带“-”符号  用Replace 替换掉
            string output = BitConverter.ToString(data).Replace("-", "");
            //混淆加密 把0替换成L
            string otherput = output.Replace("0", "l");

            return sBuilder.ToString();
        }
        #endregion

        #region 校验MD5加密是否相同
        public static bool VerifyMD5Code(string input,string md5Code) 
        {
            string codeOfInput = GetMD5Code(input);
            //数据库不区分大小写  调用此对象进行不区分大小写比较
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;
            if (0 == comparer.Compare(codeOfInput, md5Code))
                return true;
            else
                return false;
        }
        #endregion

        #region 生成key 与 session
        public static string GetSessionKeyByMod(object mod) 
        {
            string key = "";
            if (mod != null )
            {
                key = Guid.NewGuid().ToString();
                HttpContext.Current.Session.Add(key, mod);
            }
            return key;
        }
        #endregion

        #region 根据session 里key 返回对应的值
        public static object GetModBySessionKey(string key)
        {
            object mod = HttpContext.Current.Session[key];
            if (mod != null)
                return mod;
            return null;
        }
        #endregion

        #region 校验MD5加密是否相同
        #endregion

        #region 校验MD5加密是否相同
        #endregion
    }
}
