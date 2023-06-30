
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace RestoFlow.Api.Middlewares
{
    public static class JwtMiddleware
    {
        public static IApplicationBuilder UseJwtMiddleware(this IApplicationBuilder app)
        {
            app.Use(async (context, next) =>
            {
                string token = context.Request.Headers["Authorization"];
                if (!string.IsNullOrEmpty(token))
                {
                    var tok = token.Replace("Bearer ", "");
                    var jwttoken = new JwtSecurityTokenHandler().ReadJwtToken(tok);
                    var claims = jwttoken.Claims.ToList();
                    var userIdentity = new ClaimsIdentity(claims, ClaimTypes.Name);
                    context.User = new ClaimsPrincipal(userIdentity);
                }
                await next();
            });

            return app;
        }
    }
}
