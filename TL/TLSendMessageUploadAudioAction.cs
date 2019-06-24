using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLSchema;
namespace TLSchema
{
    [TLObject(-212740181)]
    public class TLSendMessageUploadAudioAction : TLAbsSendMessageAction
    {
        public override int Constructor
        {
            get
            {
                return -212740181;
            }
        }

        public int Progress { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Progress = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(Progress);

        }
    }
}
