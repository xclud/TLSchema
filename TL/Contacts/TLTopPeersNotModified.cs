using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLSchema;
namespace TLSchema.Contacts
{
    [TLObject(-567906571)]
    public class TLTopPeersNotModified : TLAbsTopPeers
    {
        public override int Constructor
        {
            get
            {
                return -567906571;
            }
        }



        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);

        }
    }
}
