using Arrowgene.Buffers;
using Arrowgene.Ddon.Shared.Entity.Structure;
using Arrowgene.Ddon.Shared.Network;

namespace Arrowgene.Ddon.Shared.Entity.PacketStructure
{
    public class C2SInstanceEnemyKillReq : IPacketStructure
    {
        public PacketId Id => PacketId.C2S_INSTANCE_ENEMY_KILL_REQ;

        public C2SInstanceEnemyKillReq()
        {
            LayoutId=new CStageLayoutId();
            SetId=0;
            InnerId=0;
            DropPosX=0;
            DropPosY=0;
            DropPosZ=0;
            IsNoBattleReword=false;
            Unk0=false;
            RegionFlag=0;
        }

        public CStageLayoutId LayoutId { get; set; }
        public uint SetId { get; set; }
        public uint InnerId { get; set; }
        public double DropPosX { get; set; }
        public float DropPosY { get; set; }
        public double DropPosZ { get; set; }
        public bool IsNoBattleReword { get; set; }
        public bool Unk0 { get; set; } // It's possible that IsNoBattleReword is this data instead
        public uint RegionFlag { get; set; }

        public class Serializer : PacketEntitySerializer<C2SInstanceEnemyKillReq>
        {

            public override void Write(IBuffer buffer, C2SInstanceEnemyKillReq obj)
            {
                WriteEntity<CStageLayoutId>(buffer, obj.LayoutId);
                WriteUInt32(buffer, obj.SetId);
                WriteUInt32(buffer, obj.InnerId);
                WriteDouble(buffer, obj.DropPosX);
                WriteFloat(buffer, obj.DropPosY);
                WriteDouble(buffer, obj.DropPosZ);
                WriteBool(buffer, obj.IsNoBattleReword);
                WriteBool(buffer, obj.Unk0);
                WriteUInt32(buffer, obj.RegionFlag);
            }

            public override C2SInstanceEnemyKillReq Read(IBuffer buffer)
            {
                C2SInstanceEnemyKillReq obj = new C2SInstanceEnemyKillReq();
                obj.LayoutId = ReadEntity<CStageLayoutId>(buffer);
                obj.SetId = ReadUInt32(buffer);
                obj.InnerId = ReadUInt32(buffer);
                obj.DropPosX = ReadDouble(buffer);
                obj.DropPosY = ReadFloat(buffer);
                obj.DropPosZ = ReadDouble(buffer);
                obj.IsNoBattleReword = ReadBool(buffer);
                obj.Unk0 = ReadBool(buffer);
                obj.RegionFlag = ReadUInt32(buffer);
                return obj;
            }
        }
    }
}
