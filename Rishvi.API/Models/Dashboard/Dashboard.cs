namespace Rishvi.API.Models.Dashboard
{
    public class Dashboard
    {
        public NumberOfProjects numberOfProjects { get; set; }
        public int professionals { get; set; }
        public List<ProjectEarnings> projectEarnings { get; set; }
        public List<ExternalLinks> externalLinks { get; set; }
        public PerformanceOverview performanceOverview { get; set; }
        public List<AuthorAchivements> authorAchivements { get; set; }
        public List<AgentEarnings> agentEarnings { get; set; }
        public List<ProjectStats> projectStats { get; set; }
	}
}
