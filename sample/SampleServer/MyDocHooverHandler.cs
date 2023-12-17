using OmniSharp.Extensions.LanguageServer.Protocol.Client.Capabilities;
using OmniSharp.Extensions.LanguageServer.Protocol.Document;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;


#pragma warning disable CS0618

namespace SampleServer
{
    internal class MyDocHooverHandler : IHoverHandler
    {
        public HoverRegistrationOptions GetRegistrationOptions(HoverCapability capability, ClientCapabilities clientCapabilities) => new HoverRegistrationOptions
        {
            DocumentSelector = TextDocumentSelector.ForLanguage("csharp")
        };
        public Task<Hover?> Handle(HoverParams request, CancellationToken cancellationToken)
        {
            var h = new Hover
            {
                Contents =  new MarkedStringsOrMarkupContent( new MarkedString("Hello world on Hoover"))
            };
            return Task.FromResult<Hover?>(h);
        }
    }
}
