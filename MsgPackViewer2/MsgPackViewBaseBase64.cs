using System;
using System.Text;
using System.Windows.Forms;
using Fiddler;

namespace MsgPackViewer2
{
    public abstract class MsgPackViewBaseBase64 : Inspector2
    {
        private readonly MsgPackViewer2 _viewer = new MsgPackViewer2();
        private byte[] _decodedBody;
        private byte[] _body;

        public override void AddToTab(TabPage o)
        {
            o.Text = "MsgPack(Base64)";
            o.Controls.Add(_viewer);
            _viewer.Dock = DockStyle.Fill;
        }

        public override int GetOrder() => 1000;

        public void Clear()
        {
            _body = null;
            _decodedBody = null;
        }

        public byte[] body
        {
            get { return _body; }
            set
            {
                _body = value;
                DisplayData();
            }
        }

        private void DisplayData()
        {
            _decodedBody = _body;
            _decodedBody = Convert.FromBase64String(Encoding.UTF8.GetString(_decodedBody));
            Utilities.utilDecodeHTTPBody(GetHeaders(), ref _decodedBody);

            _viewer.DisplayData(_decodedBody);
        }

        protected abstract HTTPHeaders GetHeaders();

        public bool bDirty => false;

        public bool bReadOnly
        {
            get { return true; }
            set { }
        }
    }
}
