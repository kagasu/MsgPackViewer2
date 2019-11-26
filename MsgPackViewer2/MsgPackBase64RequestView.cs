using Fiddler;

namespace MsgPackViewer2
{
    public class MsgPackBase64RequestView : MsgPackViewBaseBase64, IRequestInspector2
    {
        public HTTPRequestHeaders headers { get; set; }

        protected override HTTPHeaders GetHeaders()
        {
            return headers;
        }
    }
}
