using SETestFreelancer.Models;
using SETestFreelancer.Services.Interface;
using System.Web.Http;

namespace SETestFreelancer.Controllers
{
    public class LiveNationController : ApiController
    {
        ILiveNationService liveNationService;

        public LiveNationController(ILiveNationService liveNationService)
        {
            this.liveNationService = liveNationService;
        }

        [HttpPost]
        public LiveNationSummaryResponseDto LiveNationSummary(LiveNationSummaryRequestDto request)
        {
            return this.liveNationService.GetLiveNationSummary(request.Start, request.End);
        }
    }
}
