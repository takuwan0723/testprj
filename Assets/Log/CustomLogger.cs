

#define DEBUG_LOG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;


namespace Assets.Log
{
#if DEBUG_LOG
    public static class CustomLogger
    {
        //汎用
        public static void LogDebug(string message)
        {
            Debug.Log("[Debug]" + message);
        }

        //プレイヤー関連
        public static void LogPlayer(string message)
        {
            Debug.Log("[Player]" + message);
        }

        //オブジェクト
        public static void LogObject(string message)
        {
            Debug.Log("[Obj]" + message);
        }
    }
#endif
}