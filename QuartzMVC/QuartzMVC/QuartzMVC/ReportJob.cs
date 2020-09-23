using System.Threading.Tasks;
using Quartz;

namespace QuartzMVC
{
    public class ReportJob : IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            throw new System.NotImplementedException();
        }
    }
}