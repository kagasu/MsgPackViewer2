using Fiddler;

namespace MsgPackViewer2
{
    public class MsgPackBase64ResponseView : MsgPackViewBaseBase64, IResponseInspector2
    {
        public HTTPResponseHeaders headers { get; set; }

        protected override HTTPHeaders GetHeaders()
        {
            return headers;
        }
    }
}
