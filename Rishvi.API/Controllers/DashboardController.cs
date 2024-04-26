using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rishvi.API.Models.Dashboard;

namespace Rishvi.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DashboardController : ControllerBase
	{
		[HttpGet("dashboard")]
		public Dashboard GetDashboardData()
		{
			Dashboard dashboard = new Dashboard();
			dashboard.professionals = 357;
			dashboard.externalLinks = new List<ExternalLinks>()
			{
				new ExternalLinks()
				{
					Text = "Avg.Client Rating",
					URL = "#"
				},
				new ExternalLinks()
				{
					Text = "Instagram Followers",
					URL = "#"
				},
				new ExternalLinks()
				{
					Text = "Google Ads CPC",
					URL = "#"
				}
			};
			dashboard.projectEarnings = new List<ProjectEarnings>()
			{
				new ProjectEarnings()
				{
					ProjectName = "Leaf CRM",
					ProjectEarning = 7660
				},
				new ProjectEarnings()
				{
					ProjectName = "Mivy App",
					ProjectEarning = 2820
				},
				new ProjectEarnings()
				{
					ProjectName = "Others",
					ProjectEarning = 59220
				}
			};
			dashboard.numberOfProjects = new NumberOfProjects()
			{
				ActiveProjects = 69,
				PendingProjects = 43,
				CompletedPercentage = 72
			};
			return dashboard;
		}
	}
}
