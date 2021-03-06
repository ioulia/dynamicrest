﻿using System;
using DynamicRest.HTTPInterfaces;

namespace DynamicRest.UnitTests.TestDoubles
{
    internal class FakeHttpRequestFactory : IHttpRequestFactory
    {
        internal IHttpRequest CreatedRequest {get; set; }
        public IHttpRequest Create(Uri uri)
        {
            CreatedRequest = new FakeHttpRequest(uri);
            return CreatedRequest;
        }
    }
}