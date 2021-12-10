// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


using System.Collections.Generic;
using System.Security.Claims;
using Duende.IdentityServer.Test;
using IdentityModel;

namespace BethanysPieShopHRM.IDP.Quickstart;

public class TestUsers
{
    public static List<TestUser> Users =>
        new()
        {
            new TestUser
            {
                SubjectId = "767F093D-EB3C-47E8-8821-5FFE0C3C08D1",
                Username = "Jack",
                Password = "password",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Jack Torrance"),
                    new Claim(JwtClaimTypes.GivenName, "Jack"),
                    new Claim(JwtClaimTypes.FamilyName, "Torrance"),
                    new Claim(JwtClaimTypes.Email, "jack.torrance@email.com"),
                    new Claim("country", "BE")
                }
            },
            new TestUser
            {
                SubjectId = "637A3430-0208-410B-9AC8-B3F1B59B1D2A",
                Username = "Wendy",
                Password = "password",
                Claims =
                {
                    new Claim(JwtClaimTypes.Name, "Wendy Torrance"),
                    new Claim(JwtClaimTypes.GivenName, "Wendy"),
                    new Claim(JwtClaimTypes.FamilyName, "Torrance"),
                    new Claim(JwtClaimTypes.Email, "wendy.torrance@email.com"),
                    new Claim("country", "NL")
                }
            }
        };
}