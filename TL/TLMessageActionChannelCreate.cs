using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLSchema;
namespace TLSchema
{
    [TLObject(-1781355374)]
    public class TLMessageActionChannelCreate : TLAbsMessageAction
    {
        public override int Constructor
        {
            get
            {
                return -1781355374;
            }
        }

        public string Title { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Title = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(Title, bw);

        }
    }
}
