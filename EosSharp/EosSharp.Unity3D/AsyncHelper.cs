#if UNITY_WEBGL
// ReSharper disable once RedundantUsingDirective
using Cysharp.Threading.Tasks;
#endif
using System.Threading.Tasks;

namespace Assets.Packages.eossharp.EosSharp.EosSharp.Unity3D
{
    public static class AsyncHelper
    {
        public static int counter = 0;

        public static async Task Delay(int duration)
        {
#if UNITY_WEBGL && !UNITY_EDITOR_WIN
            await UniTask.Delay(duration); 
            //Debug.Log($"Custom delay has been called for duration {duration}");
            
            //while(counter < duration)
            //{
            //    await Task.Yield();
            //    counter++;
            //}

            //counter = 0;
#else
            await Task.Delay(duration);

#endif
        }
    }
}
