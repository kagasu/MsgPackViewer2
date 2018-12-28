using MiniMessagePack;
using System.Windows.Forms;
using Utf8Json;

namespace MsgPackViewer2
{
    public partial class MsgPackViewer2 : UserControl
    {
        MiniMessagePacker packer;

        public MsgPackViewer2()
        {
            InitializeComponent();
            packer = new MiniMessagePacker();
        }

        public void DisplayData(byte[] data)
        {
            var str = JsonSerializer.PrettyPrint(JsonSerializer.Serialize<dynamic>(packer.Unpack(data)));
            textBox.Text = str;
        }
    }
}
