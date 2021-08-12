using static LedQueue.Enums;

namespace LedQueue
{
    /// <summary>
    /// Kuyruklama için gönderilmesi gereken Model
    /// </summary>
    /// <typeparam name="T">Request data</typeparam>
    public class QueueContent<T> : QueueContent
    {
        public QueueContent(QueueAction action, T data) : base(action)
        {
            Data = data;
        }
        public T Data { get; set; }
    }

    public class QueueContent
    {
        public QueueContent(QueueAction action)
        {
            Action = action;
        }
        public QueueAction Action { get; set; }
    }
}
