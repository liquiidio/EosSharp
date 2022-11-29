using System.Threading.Tasks;

namespace Assets.Packages.eossharp.EosSharp.EosSharp.Unity3D
{
    public static class AsyncHelper
    {
        public static int timer = 0;

        public static async Task Delay(int duration)
        {
#if UNITY_WEBGL
            //await UniTask.Delay(duration); 
            //Debug.Log($"Custom delay has been called for duration {duration}");
            
            while(timer < duration)
            {
                await Task.Yield();
                timer++;
            }

            timer = 0;
#else
            await Task.Delay(duration);

#endif
        }
    }
}
