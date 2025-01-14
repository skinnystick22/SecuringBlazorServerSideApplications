// Copyright (c) Duende Software. All rights reserved.
// See LICENSE in the project root for license information.


namespace BethanysPieShopHRM.IDP.Quickstart.Account;

public class LoggedOutViewModel
{
    public string PostLogoutRedirectUri { get; set; }
    public string ClientName { get; set; }
    public string SignOutIframeUrl { get; set; }

    public bool AutomaticRedirectAfterSignOut { get; set; }

    public string LogoutId { get; set; }
    public bool TriggerExternalSignout => ExternalAuthenticationScheme != null;
    public string ExternalAuthenticationScheme { get; set; }
}