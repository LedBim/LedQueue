using Newtonsoft.Json;

namespace LedQueue
{
    public static class Extensions
    {
        public static string SerializeObject(this QueueContent request)
        {
            return JsonConvert.SerializeObject(request);
        }

        public static T DeserializeObject<T>(this string request)
        {
            return JsonConvert.DeserializeObject<T>(request);
        }
    }
}
