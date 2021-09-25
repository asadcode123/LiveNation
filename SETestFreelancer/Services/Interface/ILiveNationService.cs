using SETestFreelancer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SETestFreelancer.Services.Interface
{
    public interface ILiveNationService
    {
        LiveNationSummaryResponseDto GetLiveNationSummary(int start, int end);
    }
}
