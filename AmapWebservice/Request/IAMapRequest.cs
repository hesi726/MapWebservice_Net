using AMapWebservice.Response;
using CoreMapWebservice;

namespace AMapWebservice.Request
{
    /// <summary>
    /// 请求类;
    /// </summary>
    /// <typeparam name="TResponse"></typeparam>
    public interface IAMapRequest<TResponse> : IRequest<TResponse>
        where TResponse: IAMapResponse
    {
    }
}
