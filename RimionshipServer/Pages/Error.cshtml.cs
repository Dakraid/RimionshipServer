using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace RimionshipServer.Pages
{
	[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	[IgnoreAntiforgeryToken]
	public class ErrorModel : PageModel
	{
		public string RequestId { get; set; }

		public bool ShowRequestId => RequestId.IsNotEmpty();

		// private readonly ILogger<ErrorModel> _logger;

		public ErrorModel(/* ILogger<ErrorModel> logger */)
		{
			// _logger = logger;
		}

		public void OnGet()
		{
			RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
		}
	}
}
