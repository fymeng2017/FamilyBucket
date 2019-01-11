using Bucket.Values;
using System.Threading.Tasks;

namespace Bucket.Listener.Abstractions
{
    public interface IExtractCommand
    {
        /// <summary>
        /// 提取命令
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        Task ExtractCommandMessage(NetworkCommand command);
    }
}
