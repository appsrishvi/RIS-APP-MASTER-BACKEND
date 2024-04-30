namespace Rishvi.API.Models.Dashboard
{
	public class PerformanceOverview
	{
		public string Total {  get; set; }
		public string ChangeInPercentage { get; set; }
		public List<Campaign> campaigns { get; set; }
	}
}
