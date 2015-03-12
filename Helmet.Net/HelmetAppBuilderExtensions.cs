﻿using System;
using System.ComponentModel;
using Helmet.Net.Configuration;
using Owin;

namespace Helmet.Net
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static class HelmetAppBuilderExtensions
    {
        public static IAppBuilder UseHelmet(this IAppBuilder builder, HelmetConfiguration configuration)
        {
            if (builder == null)
                throw new ArgumentNullException("builder");
            if (configuration == null)
                throw new ArgumentNullException("configuration");

            //TODO:

            return builder;
        }
    }
}