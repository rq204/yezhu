using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.RegularExpressions;

namespace bhmz
{
   public class Common
    {
       /// <summary>
       /// 由输入的字符生成连续或不连续的值
       /// </summary>
       /// <param name="data"></param>
       /// <returns></returns>
       public static List<int> ParserNum(string data)
       {
           List<int> result = new List<int>();
           string[] arr = data.Split(',');
           foreach (string a in arr)
           {
               string[] brr = a.Split('-');
               if (brr.Length == 2)
               {
                   if (IsInt(brr[0]) &&IsInt(brr[1]))
                   {
                       int b1 = int.Parse(brr[0]);
                       int b2 = int.Parse(brr[1]);
                       if (b1 < b2)
                       {
                           for (int i = b1; i <= b2; i++)
                           {
                               result.Add(i);
                           }

                       }
                   }
               }
               else
               {
                   if (brr.Length == 1)
                   {
                       if (IsInt(brr[0]))
                       {
                           int re=int.Parse(brr[0]);
                           if (!result.Contains(re)) result.Add(re);
                       }
                   }
               }
           }
           result.Sort();
           return result;
       }



       #region 是不是Int型的
       /**/
       /// <summary>
       /// 是不是Int型的
       /// </summary>
       /// <param name="source"></param>
       /// <returns></returns>
       public static bool IsInt(string source)
       {
           Regex regex = new Regex(@"^(-){0,1}\d+$");
           if (regex.Match(source).Success)
           {
               if ((long.Parse(source) > 0x7fffffffL) || (long.Parse(source) < -2147483648L))
               {
                   return false;
               }
               return true;
           }
           return false;
       }
       #endregion

       #region 是不是Num型的
       /**/
       /// <summary>
       /// 是不是Int型的
       /// </summary>
       /// <param name="source"></param>
       /// <returns></returns>
       public static bool IsNum(string source)
       {
           Regex regex = new Regex(@"^(-){0,1}\d+$");
           if (regex.Match(source).Success) return true;
           return false;
       }
       #endregion


       /**/
       /// <summary>
       /// 中文
       /// </summary>
       /// <param name="source"></param>
       /// <returns></returns>
       public static bool IsChinese(string source)
       {
           return Regex.IsMatch(source, @"^[\u4e00-\u9fa5]+$", RegexOptions.IgnoreCase);
       }

       /// <summary>
       /// 是否手机号
       /// </summary>
       /// <param name="phone"></param>
       /// <returns></returns>
       public static bool IsPhone(string phone)
       {
           foreach (string p in phone.Split('、'))
           {
               if (p.Length != 11 || !p.StartsWith("1")) return false;
           }
           return true;
       }

       public static List<int> GetBuildings(List<YeZhu> yzs)
       {
           List<int> buildings = new List<int>();
           foreach (YeZhu yz in yzs) buildings.Add(yz.building);
           buildings = buildings.Distinct().ToList();
           buildings.Sort();
           return buildings;
       }
    }
}
