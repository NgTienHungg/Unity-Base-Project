using UnityEngine;

namespace OneHit.Extension
{
     public static class OneHitExtension
     {
          public static string Color(this string str)
          {
               return $"<color=lime>{str}</color>";
          }

          public static string Error(this string str)
          {
               return $"<color=red>{str}</color>";
          }
     }
}