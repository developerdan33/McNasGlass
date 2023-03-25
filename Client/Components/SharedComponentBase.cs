using Microsoft.AspNetCore.Components;

namespace McNasGlass.Web.Components;

public class SharedComponentBase : LayoutComponentBase
{
	#region Properties
	public string WebAddress { get; set; } = "https://www.mcnas.glass";
	[Inject] public HttpClient HttpClient { get; set; }
	#endregion
}