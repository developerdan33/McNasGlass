using Microsoft.AspNetCore.Components;

namespace McNasGlass.Web.Components;

public class SharedComponentBase : LayoutComponentBase
{
	#region Properties
	[Inject] public HttpClient HttpClient { get; set; }
	#endregion
}