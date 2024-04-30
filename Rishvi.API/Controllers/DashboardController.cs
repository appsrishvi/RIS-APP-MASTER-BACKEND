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
			dashboard.agentEarnings = new List<AgentEarnings>()
			{
				new AgentEarnings()
				{
					EarningsCreated = "2:30 PM",
					Value = 2756.26f,
					FinalPL = 139.34f
				},
                new AgentEarnings()
				{
					EarningsCreated = "3:10 PM",
					Value = 3207.03f,
					FinalPL = 139.34f
				},
				new AgentEarnings()
				{
					EarningsCreated = "2:30 PM",
					Value = 2756.26f,
					FinalPL = 139.34f
				}
			};
			dashboard.authorAchivements = new List<AuthorAchivements>()
			{
				new AuthorAchivements()
				{
					AuthorCountry = "Haiti",
					AuthorName = "Guy Hawkins",
					ConversionPercentage = 78.34f
				},
				new AuthorAchivements()
				{
					AuthorCountry = "Mexico",
					AuthorName = "Cody Fishers",
					ConversionPercentage = 63.08f
				},
				new AuthorAchivements()
				{
					AuthorCountry = "Monaco",
					AuthorName = "Jane Cooper",
					ConversionPercentage = 92.56f
				},
				new AuthorAchivements()
				{
					AuthorCountry = "Poland",
					AuthorName = "Jacob Jones",
					ConversionPercentage = 63.83f
				}
			};
			dashboard.performanceOverview = new PerformanceOverview()
			{
				ChangeInPercentage = "2.2",
				campaigns = new List<Campaign>()
				{
					new Campaign()
					{
						CampaignName = "Social Campaigns"
					},
					new Campaign()
					{
						CampaignName = "Email Newsletter"
					},
					new Campaign()
					{
						CampaignName = "TV Campaign"
					},
					new Campaign()
					{
						CampaignName = "Google Ads"
					},
					new Campaign()
					{
						CampaignName = "Courses"
					},
					new Campaign()
					{
						CampaignName = "Radio"
					}
				}
			};
			dashboard.projectStats = new List<ProjectStats>()
			{
				new ProjectStats()
				{
					AppName = "Mivy App",
					AuthorName = "Jane Cooper",
					Budget = "32,400",
					Progress = 9.2f,
					Status = "In Process"
				},
				new ProjectStats()
				{
					AppName = "Charto CRM",
					AuthorName = "Tower Hill",
					Budget = "8,220",
					Progress = 9.0f,
					Status = "On Hold"
				},
				new ProjectStats()
				{
					AppName = "Avionica",
					AuthorName = "Esther Howard",
					Budget = "256,910",
					Progress = 0.4f,
					Status = "In Process"
				},
				new ProjectStats()
				{
					AppName = "9 Degree",
					AuthorName = "Savannah Nguyen",
					Budget = "183,300",
					Progress = 0.4f,
					Status = "Completed"
				}
			};
			return dashboard;
		}
	}
}
