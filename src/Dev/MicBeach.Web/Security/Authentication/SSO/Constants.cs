﻿using IdentityModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicBeach.Web.Security.Authentication.SSO
{
    public static class Constants
    {
        public static class RoutePaths
        {
            public const string CredentialVerify = "unity-authentication/check-credential";
        }

        public static class EndpointNames
        {
            public const string CredentialVerify = "CredentialVerify";
        }

        public static class CredentialVerifyRequestKeys
        {
            public const string ClientId = "client_id";
            public const string SubjectId = JwtClaimTypes.Subject;
        }

        public const string SSOAuthenticationScheme = "SSO-Authentication-Scheme";
    }
}
