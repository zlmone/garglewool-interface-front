﻿using System.Collections.Generic;
using Abp.Dependency;

namespace GargleWool.Web.Core.Authentication.External
{
    public class ExternalAuthConfiguration : IExternalAuthConfiguration, ISingletonDependency
    {
        public ExternalAuthConfiguration()
        {
            Providers = new List<ExternalLoginProviderInfo>();
        }

        public List<ExternalLoginProviderInfo> Providers { get; }
    }
}