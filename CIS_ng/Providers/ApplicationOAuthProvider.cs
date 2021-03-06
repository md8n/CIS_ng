﻿using System;
using System.Threading.Tasks;
using Microsoft.Owin.Security.OAuth;

namespace CIS_ng.Providers
{
  public class ApplicationOAuthProvider : OAuthAuthorizationServerProvider
  {
    private readonly string _publicClientId;

    public ApplicationOAuthProvider(string publicClientId)
    {
      if (publicClientId == null)
      {
        throw new ArgumentNullException(nameof(publicClientId));
      }

      _publicClientId = publicClientId;
    }

    public override Task ValidateClientRedirectUri(OAuthValidateClientRedirectUriContext context)
    {
      if (context.ClientId != _publicClientId)
      {
        return Task.FromResult<object>(null);
      }

      var expectedRootUri = new Uri(context.Request.Uri, "/");

      if (expectedRootUri.AbsoluteUri == context.RedirectUri)
      {
        context.Validated();
      }
      else if (context.ClientId == "web")
      {
        var expectedUri = new Uri(context.Request.Uri, "/");
        context.Validated(expectedUri.AbsoluteUri);
      }

      return Task.FromResult<object>(null);
    }
  }
}