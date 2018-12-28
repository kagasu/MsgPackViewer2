using Fiddler;

namespace MsgPackViewer2
{
    public class MsgPackResponseView : MsgPackViewBase, IResponseInspector2
    {
        public HTTPResponseHeaders headers { get; set; }

        protected override HTTPHeaders GetHeaders()
        {
            return headers;
        }
    }
}
