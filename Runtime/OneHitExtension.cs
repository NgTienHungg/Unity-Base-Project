using UnityEngine;

namespace OneHit.Extension
{
     public static class OneHitExtension
     {
          public static string Color(this string str)
          {
               return $"<color=lime>{str}</color>";
          }
     }
}