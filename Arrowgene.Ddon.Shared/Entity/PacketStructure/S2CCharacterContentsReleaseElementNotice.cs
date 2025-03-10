using System.Collections.Generic;
using Arrowgene.Buffers;
using Arrowgene.Ddon.Shared.Entity.Structure;
using Arrowgene.Ddon.Shared.Network;

namespace Arrowgene.Ddon.Shared.Entity.PacketStructure
{
    public class S2CCharacterContentsReleaseElementNotice : IPacketStructure
    {
        // List of content elements to release (Menu options, such as inventory, warp...)

        public PacketId Id => PacketId.S2C_CHARACTER_CONTENTS_RELEASE_ELEMENT_NTC;

        public S2CCharacterContentsReleaseElementNotice()
        {
            CharacterReleaseElements = new List<CDataCharacterReleaseElement>();
        }

        public List<CDataCharacterReleaseElement> CharacterReleaseElements { get; set; }

        public class Serializer : PacketEntitySerializer<S2CCharacterContentsReleaseElementNotice>
        {
            public override void Write(IBuffer buffer, S2CCharacterContentsReleaseElementNotice obj)
            {
                WriteEntityList<CDataCharacterReleaseElement>(buffer, obj.CharacterReleaseElements);
            }

            public override S2CCharacterContentsReleaseElementNotice Read(IBuffer buffer)
            {
                S2CCharacterContentsReleaseElementNotice obj = new S2CCharacterContentsReleaseElementNotice();
                obj.CharacterReleaseElements = ReadEntityList<CDataCharacterReleaseElement>(buffer);
                return obj;
            }
        }
    }
}