using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLSchema;
namespace TLSchema.Messages
{
    [TLObject(-402498398)]
    public class TLSavedGifsNotModified : TLAbsSavedGifs
    {
        public override int Constructor
        {
            get
            {
                return -402498398;
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
