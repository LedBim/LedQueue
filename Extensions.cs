using Newtonsoft.Json;

namespace LedQueue
{
    public static class Extensions
    {
        public static string SerializeObject(this QueueContent request)
        {
            var settings = new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            return JsonConvert.SerializeObject(request, settings: settings);
        }

        public static T DeserializeObject<T>(this string request)
        {
            return JsonConvert.DeserializeObject<T>(request);
        }
    }
}
