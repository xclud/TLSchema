using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLSchema;
namespace TLSchema.Upload
{
    [TLObject(-1291540959)]
    public class TLRequestSaveFilePart : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -1291540959;
            }
        }

        public long FileId { get; set; }
        public int FilePart { get; set; }
        public byte[] Bytes { get; set; }
        public bool Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            FileId = br.ReadInt64();
            FilePart = br.ReadInt32();
            Bytes = BytesUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            bw.Write(FileId);
            bw.Write(FilePart);
            BytesUtil.Serialize(Bytes, bw);

        }
        public override void DeserializeResponse(BinaryReader br)
        {
            Response = BoolUtil.Deserialize(br);

        }
    }
}
