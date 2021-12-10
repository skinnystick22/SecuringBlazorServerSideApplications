// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using Duende.IdentityServer.Models;
using System.Collections.Generic;

namespace BethanysPieShopHRM.IDP;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        {
            new IdentityResources.OpenId(),
            new IdentityResources.Profile(),
            new IdentityResources.Email(),
            new("country", new[] {"country"})
        };

    public static IEnumerable<ApiResource> Apis =>
        new ApiResource[]
        {
            new("bethanyspieshophrapi", "Bethany's Pie Shop HR API", new[] {"country"})
        };

    public static IEnumerable<Client> Clients =>
        new Client[]
        {
            new()
            {
                ClientId = "bethanyspieshophr",
                ClientName = "Bethany's Pie Shop HRM",
                AllowedGrantTypes = GrantTypes.Code,
                RequireClientSecret = false,
                RequirePkce = true,
                RedirectUris = {"https://localhost:5000/signin-oidc"},
                FrontChannelLogoutUri = "https://localhost:5000/signout-oidc",
                PostLogoutRedirectUris = {"https://localhost:5000/signout-callback-oidc"},
                AllowedScopes = {"openid", "profile", "email"},
                AllowedCorsOrigins = {"https://localhost:5000"}
            },
        };
}