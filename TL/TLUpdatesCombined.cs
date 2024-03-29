using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TLSchema;
namespace TLSchema
{
    [TLObject(1918567619)]
    public class TLUpdatesCombined : TLAbsUpdates
    {
        public override int Constructor
        {
            get
            {
                return 1918567619;
            }
        }

        public TLVector<TLAbsUpdate> Updates { get; set; }
        public TLVector<TLAbsUser> Users { get; set; }
        public TLVector<TLAbsChat> Chats { get; set; }
        public int Date { get; set; }
        public int SeqStart { get; set; }
        public int Seq { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            Updates = (TLVector<TLAbsUpdate>)ObjectUtils.DeserializeVector<TLAbsUpdate>(br);
            Users = (TLVector<TLAbsUser>)ObjectUtils.DeserializeVector<TLAbsUser>(br);
            Chats = (TLVector<TLAbsChat>)ObjectUtils.DeserializeVector<TLAbsChat>(br);
            Date = br.ReadInt32();
            SeqStart = br.ReadInt32();
            Seq = br.ReadInt32();

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            ObjectUtils.SerializeObject(Updates, bw);
            ObjectUtils.SerializeObject(Users, bw);
            ObjectUtils.SerializeObject(Chats, bw);
            bw.Write(Date);
            bw.Write(SeqStart);
            bw.Write(Seq);

        }
    }
}
