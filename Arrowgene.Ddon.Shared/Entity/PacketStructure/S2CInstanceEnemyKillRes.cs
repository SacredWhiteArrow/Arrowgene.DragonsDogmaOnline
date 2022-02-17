using Arrowgene.Buffers;
using Arrowgene.Ddon.Shared.Network;

namespace Arrowgene.Ddon.Shared.Entity.PacketStructure
{
    public class S2CInstanceEnemyKillRes : ServerResponse
    {
        public override PacketId Id => PacketId.S2C_INSTANCE_ENEMY_KILL_RES;

        public S2CInstanceEnemyKillRes()
        {
            EnemyId = 0;
            KillNum = 0;
        }

        public uint EnemyId { get; set; }
        public uint KillNum { get; set; }

        public class Serializer : EntitySerializer<S2CInstanceEnemyKillRes>
        {
            static Serializer()
            {
                Id = PacketId.S2C_INSTANCE_ENEMY_KILL_RES;
            }
            
            public override void Write(IBuffer buffer, S2CInstanceEnemyKillRes obj)
            {
                WriteUInt32(buffer, obj.EnemyId);
                WriteUInt32(buffer, obj.KillNum);
            }

            public override S2CInstanceEnemyKillRes Read(IBuffer buffer)
            {
                S2CInstanceEnemyKillRes obj = new S2CInstanceEnemyKillRes();
                obj.EnemyId = ReadUInt32(buffer);
                obj.KillNum = ReadUInt32(buffer);
                return obj;
            }
        }
    }
}
