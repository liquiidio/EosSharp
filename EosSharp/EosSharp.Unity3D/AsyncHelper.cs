#if UNITY_WEBGL
// ReSharper disable once RedundantUsingDirective
using Cysharp.Threading.Tasks;
#endif
using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Packages.eossharp.EosSharp.EosSharp.Unity3D
{
    public static class AsyncHelper
    {
        public static async Task Delay(int durationMiliseconds)
        {
            var endTime = DateTimeOffset.Now.AddMilliseconds(durationMiliseconds);

#if UNITY_WEBGL && !UNITY_EDITOR_WIN
            //await UniTask.Delay(duration); 
            //Debug.Log($"Custom delay has been called for duration {duration}");
            int counter = 0;
            while(DateTimeOffset.Now < endTime)
            {
                await Task.Yield();
                counter++;
                Debug.Log($"counter {counter}");
            }
#else
            await Task.Delay(durationMiliseconds);

#endif
        }

//#if UNITY_WEBGL && !UNITY_EDITOR_WIN
//            //await UniTask.Delay(duration); 
//            //Debug.Log($"Custom delay has been called for duration {duration}");
//            int counter = 0;
//            while(Time.time < endTime)
//            {
//                await Task.Yield();
//                counter++;
//                Debug.Log($"counter {counter}");
//                Debug.Log($"Time.time {Time.time}");
//            }
//#else
//        await Task.Delay(durationMiliseconds);
//#endif
    }
}
