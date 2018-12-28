using Fiddler;

namespace MsgPackViewer2
{
    public class MsgPackRequestView : MsgPackViewBase, IRequestInspector2
    {
        public HTTPRequestHeaders headers { get; set; }

        protected override HTTPHeaders GetHeaders()
        {
            return headers;
        }
    }
}
