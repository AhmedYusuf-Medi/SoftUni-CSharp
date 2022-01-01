namespace BMR.Web.Extensions
{
    using System.Security.Claims;

    internal static class ClaimsPrincipalExtensions
    {
        internal static string GetEmail(this ClaimsPrincipal claimsPrincipal)
            => claimsPrincipal.FindFirstValue(ClaimTypes.Email);
    }
}
