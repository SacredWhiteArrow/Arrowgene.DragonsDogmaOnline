using System.Collections.Generic;
using Arrowgene.Buffers;
using Arrowgene.Ddon.Shared.Entity.Structure;
using Arrowgene.Ddon.Shared.Network;

namespace Arrowgene.Ddon.Shared.Entity.PacketStructure
{
    public class S2CStageGetStageListRes : ServerResponse
    {
        public override PacketId Id => PacketId.S2C_STAGE_GET_STAGE_LIST_RES;

        public List<CDataStageInfo> StageList { get; set; }

        public class Serializer : EntitySerializer<S2CStageGetStageListRes>
        {
            static Serializer()
            {
                Id = PacketId.S2C_STAGE_GET_STAGE_LIST_RES;
            }
            
            public override void Write(IBuffer buffer, S2CStageGetStageListRes obj)
            {
                WriteServerResponse(buffer, obj);
                WriteEntityList<CDataStageInfo>(buffer, obj.StageList);
            }

            public override S2CStageGetStageListRes Read(IBuffer buffer)
            {
                S2CStageGetStageListRes obj = new S2CStageGetStageListRes();
                ReadServerResponse(buffer, obj);
                obj.StageList = ReadEntityList<CDataStageInfo>(buffer);
                return obj;
            }
        }
    }
}
