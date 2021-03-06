// Copyright (c) Microsoft. All rights reserved. 
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Net.Http;
using System.Net.Http.Formatting;
using Microsoft.Its.Domain.Serialization;

namespace Microsoft.Its.Domain.Api.Serialization
{
    internal class JsonContent : ObjectContent
    {
        private static readonly MediaTypeFormatter formatter = new JsonMediaTypeFormatter
        {
            SerializerSettings = Serializer.Settings
        };

        public JsonContent(object value) : base(value.GetType(), value, formatter)
        {
        }
    }
}
