using System;
using System.Net;

namespace hello.streamingaudio
{
    public sealed class UriNotFoundException : MediaException
    {
        public UriNotFoundException(Uri uri, HttpStatusCode statusCode) :
            base($"Could not get uri \"{uri}\" (HTTP status: {statusCode})")
        {
            Uri = uri;
            StatusCode = statusCode;
        }

        public Uri Uri { get; private set; }
        public HttpStatusCode StatusCode { get; private set; }
    }
}