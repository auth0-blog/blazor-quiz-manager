using Microsoft.AspNetCore.Authentication;
using Auth0.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace QuizManager.Pages
{
  public class LoginModel : PageModel
  {
    public async Task OnGet(string redirectUri)
    {
      var authenticationProperties = new LoginAuthenticationPropertiesBuilder()
          .WithRedirectUri(redirectUri)
          .Build();

      await HttpContext.ChallengeAsync(Auth0Constants.AuthenticationScheme, authenticationProperties);
    }
  }
}
