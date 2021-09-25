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
            string[] inputs = request.Range.Split(',');
            int start = 0;
            int end = 0;

            try
            {
                start = int.Parse(inputs[0]);
                end = int.Parse(inputs[1]);
            }
            catch(System.Exception ex)
            {
                throw ex;
            }

            return this.liveNationService.GetLiveNationSummary(start, end);
        }
    }
}
