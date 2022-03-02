using Arrowgene.Buffers;
using Arrowgene.Ddon.Shared.Network;

namespace Arrowgene.Ddon.Shared.Entity.PacketStructure
{
    public class S2CCharacterDecideCharacterIdRes : ServerResponse
    {
        public override PacketId Id => PacketId.S2C_CHARACTER_DECIDE_CHARACTER_ID_RES;

        public S2CCharacterDecideCharacterIdRes()
        {
            CharacterId = 0;
            FirstName = "";
            LastName = "";
        }

        public uint CharacterId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


        public class Serializer : PacketEntitySerializer<S2CCharacterDecideCharacterIdRes>
        {
            public override void Write(IBuffer buffer, S2CCharacterDecideCharacterIdRes obj)
            {
                WriteServerResponse(buffer, obj);
                WriteUInt32(buffer, obj.CharacterId);
                WriteUInt32(buffer, obj.CharacterId);
                WriteUInt32(buffer, 0);
                WriteUInt32(buffer, 0);
                WriteMtString(buffer, obj.FirstName);
                WriteMtString(buffer, obj.LastName);
                WriteByteArray(buffer, new byte[] /* 2.0.2 */
                {
                    // Reference: GameDump.Dump_13
                    0x2, 0x4, 0x75, 0x30, 0x1, 0x1, 0x1, 0x44,
                    0x12, 0x0, 0x0, 0x2, 0x3, 0x5, 0x8, 0x0, 0x45, 0x0, 0x45, 0x37, 0x37, 0xC, 0x74, 0x9A,
                    0x74, 0x7C, 0x76, 0xD4, 0x73, 0x85, 0x73, 0xB7, 0x74, 0x13, 0x71, 0xCF, 0x75, 0xDC, 0x74, 0x82,
                    0x77, 0x1C, 0x75, 0x32, 0x74, 0xD1, 0x7C, 0x38, 0x72, 0xD8, 0x75, 0x30, 0x75, 0x30, 0x75, 0xC3,
                    0x74, 0xF2, 0x74, 0x4F, 0x75, 0x2, 0x74, 0xE0, 0x74, 0x9A, 0x72, 0x10, 0x72, 0xDC, 0x74, 0x4,
                    0x73, 0x20, 0x77, 0xD0, 0x71, 0x48, 0x73, 0x50, 0x77, 0xB5, 0x75, 0xA2, 0x75, 0x30, 0x75, 0x30,
                    0x75, 0x30, 0x75, 0x30, 0x75, 0x30, 0xBB, 0xB2, 0x9B, 0x35, 0x71, 0xFC, 0x80, 0x48, 0x96, 0x96,
                    0x99, 0xF2, 0xA9, 0xB3, 0x96, 0xC8, 0x77, 0x88, 0x72, 0x95, 0x70, 0x1C, 0x51, 0xA4, 0x75, 0x30,
                    0x61, 0x44, 0x0, 0x0, 0x11, 0x9B, 0x0, 0x0, 0x1, 0xC2, 0x3, 0x0, 0x0, 0x2, 0xF8, 0x0,
                    0x0, 0x1, 0xC2, 0x0, 0x0, 0x11, 0xED, 0x0, 0x0, 0xA, 0xF, 0x0, 0x0, 0x3, 0xAC, 0x0,
                    0x0, 0x0, 0x3B, 0x0, 0x0, 0x0, 0x3A, 0x0, 0x0, 0x0, 0x41, 0x0, 0x0, 0x0, 0x39, 0x5,
                    0x0, 0x0, 0x0, 0xA, 0x9, 0x0, 0x84, 0x64, 0xA4, 0x0, 0x5, 0x3B, 0xD8, 0x0, 0x0, 0x0,
                    0x3E, 0x0, 0xD5, 0x0, 0xA1, 0x0, 0x8E, 0x0, 0xA1, 0x0, 0x19, 0x0, 0x32, 0x0, 0x32, 0x0,
                    0x0, 0x0, 0x1B, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x68, 0x2A, 0x0, 0x0, 0xD, 0xAC, 0x0, 0x0, 0x0, 0xB,
                    0x0, 0x3C, 0x0, 0x84, 0x0, 0x28, 0x0, 0x5B, 0x0, 0x19, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0,
                    0x0, 0x15, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0xA, 0x0, 0x24, 0xCB, 0xEC, 0x0, 0x2, 0xF, 0x58, 0x0, 0x0, 0x0, 0x2E, 0x0,
                    0xA5, 0x0, 0x77, 0x0, 0xA5, 0x0, 0x77, 0x0, 0x19, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0,
                    0x12, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x1E,
                    0x0, 0x53, 0x0, 0x14, 0x0, 0x53, 0x0, 0xA, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0, 0x12,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x4, 0x0, 0x0, 0x91, 0xE8, 0x0, 0x0, 0x7, 0x6C, 0x0, 0x0, 0x0, 0xC, 0x0, 0x2A, 0x0,
                    0x3E, 0x0, 0x3F, 0x0, 0x6F, 0x0, 0x12, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0, 0x9, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5,
                    0xD, 0x78, 0x7C, 0x80, 0x0, 0x2, 0xCA, 0xD8, 0x0, 0x0, 0x0, 0x78, 0x1, 0x83, 0x0, 0xFE,
                    0x1, 0x83, 0x0, 0xFE, 0x0, 0x1E, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0, 0x1E, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x6, 0x1,
                    0x17, 0x99, 0x8D, 0x0, 0x6, 0x65, 0x1C, 0x0, 0x0, 0x0, 0x47, 0x0, 0xA0, 0x0, 0x4C, 0x0,
                    0xF0, 0x0, 0xAA, 0x0, 0x1E, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0, 0x9, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x7, 0x0, 0x24,
                    0x5D, 0x14, 0x0, 0x2, 0x81, 0x4, 0x0, 0x0, 0x0, 0x2D, 0x0, 0xA2, 0x0, 0xAC, 0x0, 0x6C,
                    0x0, 0x76, 0x0, 0x23, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0, 0x18, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x8, 0x7, 0x69, 0xE4,
                    0xB2, 0x0, 0x6, 0xE, 0x0, 0x0, 0x0, 0x0, 0x63, 0x0, 0xD8, 0x0, 0x64, 0x1, 0x44, 0x0,
                    0x9E, 0x0, 0x12, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0, 0x9, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xB, 0x0, 0x2A, 0x90, 0x4,
                    0x0, 0x2, 0xCC, 0xCC, 0x0, 0x0, 0x0, 0x2F, 0x0, 0xA8, 0x0, 0x77, 0x0, 0xA8, 0x0, 0x77,
                    0x0, 0x19, 0x0, 0x32, 0x0, 0x32, 0x0, 0x0, 0x0, 0x12, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xA, 0x9, 0x1,
                    0x0, 0x0, 0x0, 0x0, 0x1, 0x1, 0x0, 0x0, 0x0, 0x36, 0xA, 0x1, 0x0, 0x0, 0x0, 0x0,
                    0x2, 0x1, 0x0, 0x0, 0x0, 0x0, 0x4, 0x1, 0x0, 0x0, 0x0, 0x0, 0x5, 0x2, 0x0, 0x0,
                    0x3, 0xF, 0x6, 0x1, 0x0, 0x0, 0x0, 0x3C, 0x7, 0x1, 0x0, 0x0, 0x0, 0x0, 0x8, 0x1,
                    0x0, 0x0, 0x2, 0xF4, 0xB, 0x1, 0x0, 0x0, 0x0, 0x36, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0,
                    0x0, 0xE, 0x0, 0x0, 0x61, 0x99, 0x0, 0x1, 0x0, 0x1, 0x6, 0x0, 0x0, 0x0, 0x0, 0x4,
                    0x1, 0x0, 0x0, 0x24, 0x2C, 0x0, 0x0, 0x2, 0x0, 0x0, 0x24, 0x2C, 0x0, 0x0, 0x3, 0x0,
                    0x0, 0x24, 0x2C, 0x0, 0x0, 0x4, 0x0, 0x0, 0x24, 0x2C, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1,
                    0x1, 0x1, 0x0, 0x59, 0x0, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x62, 0xB, 0x0, 0x1,
                    0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x63, 0x74, 0x0, 0x1, 0x0, 0x3, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x1, 0x1, 0x1, 0x2, 0x9D, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x63, 0x79,
                    0x0, 0x1, 0x0, 0x4, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x1, 0x1,
                    0x2, 0x80, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x63, 0xA2, 0x0, 0x1, 0x0, 0x5,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x63, 0x7E, 0x0, 0x1, 0x0, 0x6, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1,
                    0x1, 0x1, 0x1, 0xD2, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x63, 0x83, 0x0, 0x1,
                    0x0, 0x7, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x1, 0x1, 0x2, 0x25,
                    0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x63, 0xA7, 0x0, 0x1, 0x0, 0x8, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x63, 0xAC,
                    0x0, 0x1, 0x0, 0x9, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x54, 0x93, 0x0, 0x1, 0x0, 0xB, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1,
                    0x1, 0x0, 0x0, 0x56, 0x5F, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x46, 0xE3, 0x0, 0x1, 0x0, 0xC, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3, 0x1, 0x0, 0x0,
                    0x5A, 0x48, 0x0, 0x0, 0x2, 0x0, 0x0, 0x3F, 0xA6, 0x0, 0x0, 0x3, 0x0, 0x0, 0x4B, 0xB2,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x11, 0x2, 0x0, 0x2, 0x3, 0x0, 0x2,
                    0x4, 0x0, 0x2, 0x5, 0x0, 0x2, 0x6, 0x0, 0x50, 0x7, 0x0, 0x3C, 0x8, 0x0, 0x5, 0x9,
                    0x0, 0x7, 0xA, 0x0, 0x4, 0xB, 0x0, 0x4, 0xC, 0x0, 0x4, 0xD, 0x0, 0x4, 0xE, 0x0,
                    0x0, 0xF, 0x0, 0x5, 0x10, 0x0, 0x5, 0x11, 0x0, 0x5, 0x12, 0x0, 0x5, 0x0, 0x0, 0x5C,
                    0x9F, 0x0, 0x1, 0x0, 0xD, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x1, 0x0, 0x0, 0x5C, 0x56,
                    0x0, 0xE, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x54, 0x93, 0x0, 0x1,
                    0x0, 0xE, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x1, 0x0, 0x0, 0x56, 0xDD, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x53, 0x4A, 0x0, 0x1, 0x0, 0xF, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x1, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x25, 0x70, 0x0, 0x2, 0x0, 0x4, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x1, 0x1, 0x0, 0x0, 0x24, 0x66, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x21, 0x55, 0x0, 0x2, 0x0, 0x5, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3, 0x99, 0x0, 0x2, 0x0, 0x6,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x50, 0xB3, 0x0, 0x2, 0x0, 0x7, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0xF9, 0x0, 0x2, 0x0, 0x8, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0,
                    0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x2, 0x5, 0x0, 0x0, 0x0, 0x11, 0x2, 0x0, 0x2,
                    0x3, 0x0, 0x2, 0x4, 0x0, 0x2, 0x5, 0x0, 0x2, 0x6, 0x0, 0x50, 0x7, 0x0, 0x3C, 0x8,
                    0x0, 0x5, 0x9, 0x0, 0x7, 0xA, 0x0, 0x4, 0xB, 0x0, 0x4, 0xC, 0x0, 0x4, 0xD, 0x0,
                    0x4, 0xE, 0x0, 0x0, 0xF, 0x0, 0x5, 0x10, 0x0, 0x5, 0x11, 0x0, 0x5, 0x12, 0x0, 0x5,
                    0x0, 0x0, 0x0, 0x11, 0x1, 0x0, 0x14, 0x2, 0x0, 0x28, 0x3, 0x0, 0x28, 0x4, 0x0, 0x5,
                    0x5, 0x0, 0x14, 0x6, 0x1, 0x90, 0x7, 0x1, 0x90, 0x8, 0x1, 0x90, 0x9, 0x1, 0x90, 0xA,
                    0x1, 0x90, 0xB, 0x0, 0x0, 0xC, 0x3, 0x20, 0xD, 0x1, 0x90, 0xE, 0x0, 0x0, 0xF, 0x0,
                    0x0, 0x10, 0x0, 0x0, 0x11, 0x0, 0x0, 0x0, 0x0, 0x0, 0xD, 0x1, 0x0, 0x96, 0x80, 0x22,
                    0x2, 0x0, 0x1F, 0xFE, 0xC, 0x3, 0x0, 0x0, 0xC3, 0x50, 0x4, 0x0, 0x0, 0x16, 0x10, 0x6,
                    0x0, 0x1, 0x86, 0x9F, 0x9, 0x0, 0x0, 0x13, 0x88, 0xA, 0x0, 0x0, 0x0, 0x0, 0xB, 0x0,
                    0x0, 0x0, 0x8, 0xC, 0x0, 0x0, 0x0, 0xDB, 0xD, 0x0, 0x0, 0x0, 0x2, 0xE, 0x0, 0x0,
                    0x0, 0x2, 0xF, 0x0, 0x0, 0x0, 0x73, 0x10, 0x0, 0x0, 0x0, 0x69, 0x3, 0x5, 0x0, 0x0,
                    0x0, 0x4, 0x1, 0x0, 0x0, 0x0, 0x5, 0x0, 0x5, 0x1, 0x8, 0x2, 0x8, 0x3, 0x8, 0x4,
                    0x8, 0x2, 0x0, 0x0, 0x0, 0x5, 0x0, 0x5, 0x1, 0x8, 0x2, 0x8, 0x3, 0x8, 0x4, 0x8,
                    0x3, 0x0, 0x0, 0x0, 0x5, 0x0, 0x5, 0x1, 0x8, 0x2, 0x8, 0x3, 0x8, 0x4, 0x8, 0x4,
                    0x0, 0x0, 0x0, 0x5, 0x0, 0x5, 0x1, 0x8, 0x2, 0x8, 0x3, 0x8, 0x4, 0x8, 0x0, 0x0,
                    0x0, 0x6, 0x0, 0x0, 0x0, 0x1, 0x0, 0xB, 0x4D, 0x79, 0x20, 0x50, 0x68, 0x72, 0x61, 0x73,
                    0x65, 0x20, 0x31, 0x0, 0x0, 0x0, 0xA, 0x0, 0x0, 0x0, 0x1, 0x0, 0x8, 0xEF, 0x80, 0x8D,
                    0x48, 0x65, 0x6C, 0x6C, 0x6F, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0xD,
                    0xEF, 0x80, 0x8D, 0x47, 0x6F, 0x6F, 0x64, 0x20, 0x77, 0x6F, 0x72, 0x6B, 0x21, 0x0, 0x0, 0x0,
                    0x3, 0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0x13, 0xEF, 0x80, 0x8D, 0x43, 0x6F, 0x6E, 0x67, 0x72,
                    0x61, 0x74, 0x75, 0x6C, 0x61, 0x74, 0x69, 0x6F, 0x6E, 0x73, 0x21, 0x0, 0x0, 0x0, 0x9, 0x0,
                    0x0, 0x0, 0x0, 0x4, 0x0, 0x6, 0xEF, 0x80, 0x8D, 0x4F, 0x4B, 0x21, 0x0, 0x0, 0x0, 0x27,
                    0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x23, 0xEF, 0x80, 0x8D, 0x43, 0x61, 0x6E, 0x20, 0x49, 0x20,
                    0x61, 0x64, 0x64, 0x20, 0x79, 0x6F, 0x75, 0x20, 0x74, 0x6F, 0x20, 0x6D, 0x79, 0x20, 0x66, 0x72,
                    0x69, 0x65, 0x6E, 0x64, 0x20, 0x6C, 0x69, 0x73, 0x74, 0x3F, 0x0, 0x0, 0x0, 0x3B, 0x0, 0x0,
                    0x0, 0x0, 0x6, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x7, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x8, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x9, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xA, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0xB, 0x4D, 0x79, 0x20, 0x50,
                    0x68, 0x72, 0x61, 0x73, 0x65, 0x20, 0x32, 0x0, 0x0, 0x0, 0xA, 0x0, 0x0, 0x0, 0x1, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x4,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x6, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x7, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x8, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x9, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0xA, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0xB, 0x4D,
                    0x79, 0x20, 0x50, 0x68, 0x72, 0x61, 0x73, 0x65, 0x20, 0x33, 0x0, 0x0, 0x0, 0xA, 0x0, 0x0,
                    0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x6, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x7, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x8, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x9, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0xA, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x4,
                    0x0, 0xB, 0x4D, 0x79, 0x20, 0x50, 0x68, 0x72, 0x61, 0x73, 0x65, 0x20, 0x34, 0x0, 0x0, 0x0,
                    0xA, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x2,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x5, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x6, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x7, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x8, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x9, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xA, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x5, 0x0, 0xB, 0x4D, 0x79, 0x20, 0x50, 0x68, 0x72, 0x61, 0x73, 0x65, 0x20, 0x35,
                    0x0, 0x0, 0x0, 0xA, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x6, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x7, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x8, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x9,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xA, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x6, 0x0, 0xB, 0x4D, 0x79, 0x20, 0x50, 0x68, 0x72, 0x61, 0x73,
                    0x65, 0x20, 0x36, 0x0, 0x0, 0x0, 0xA, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x3, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x6, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x7, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x8, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x9, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xA, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xC, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0,
                    0x1, 0x0, 0x0, 0x0, 0x32, 0x0, 0x0, 0x0, 0x28, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0,
                    0x0, 0x1, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x32, 0x0, 0x0, 0x2C, 0x8F, 0x0, 0x0,
                    0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x37, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x4,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0,
                    0x2, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x32, 0x0, 0x0, 0x0, 0x37, 0x0, 0x0, 0x0,
                    0x0, 0x2, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x1F, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x3, 0x0,
                    0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x2,
                    0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x16, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x1, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x32, 0x0, 0x0, 0x1D,
                    0x80, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0,
                    0x0, 0x32, 0x0, 0x0, 0x24, 0x91, 0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x3, 0x0,
                    0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x32, 0x0, 0x0, 0x0, 0x37, 0x0, 0x0, 0x0, 0x0, 0x2,
                    0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x32, 0x0, 0x0, 0x0, 0x29,
                    0x0, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x29, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x1, 0x6,
                    0x1, 0x0, 0x0, 0x0, 0xC, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x2, 0x6, 0x1, 0x0,
                    0x0, 0x0, 0x10, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x3, 0x6, 0x3, 0x0, 0x0, 0x0,
                    0x5, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x4, 0x6, 0x0, 0x0, 0x0, 0x0, 0x4, 0x0,
                    0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x5, 0x6, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x1, 0x0, 0x0, 0x0, 0x6, 0x6, 0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x1, 0x0,
                    0x0, 0x0, 0x7, 0x6, 0x3, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0,
                    0x8, 0x6, 0x0, 0x0, 0x0, 0x0, 0x8, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x1, 0x5,
                    0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x2, 0x5, 0x0, 0x0,
                    0x0, 0x0, 0x7, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x3, 0x5, 0x0, 0x0, 0x0, 0x0,
                    0x8, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x4, 0x5, 0x0, 0x0, 0x0, 0x0, 0x6, 0x0,
                    0x0, 0x0, 0x2, 0x0, 0x0, 0x0, 0x5, 0x5, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x2, 0x0, 0x0, 0x0, 0x6, 0x5, 0x0, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x2, 0x0,
                    0x0, 0x0, 0x7, 0x5, 0x0, 0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x2, 0x0, 0x0, 0x0,
                    0x8, 0x5, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x1, 0x4,
                    0x0, 0x0, 0x0, 0x0, 0x8, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x2, 0x4, 0x5, 0x0,
                    0x0, 0x0, 0x6, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x3, 0x4, 0x5, 0x0, 0x0, 0x0,
                    0x7, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x4, 0x4, 0x5, 0x0, 0x0, 0x0, 0x5, 0x0,
                    0x0, 0x0, 0x3, 0x0, 0x0, 0x0, 0x5, 0x4, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0,
                    0x3, 0x0, 0x0, 0x0, 0x6, 0x4, 0x0, 0x0, 0x0, 0x0, 0x10, 0x0, 0x0, 0x0, 0x3, 0x0,
                    0x0, 0x0, 0x7, 0x4, 0x0, 0x0, 0x0, 0x0, 0x13, 0x0, 0x0, 0x0, 0x3, 0x0, 0x0, 0x0,
                    0x8, 0x4, 0x0, 0x0, 0x0, 0x0, 0x9, 0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x1, 0x4,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x2, 0x4, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x3, 0x4, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x4, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x4, 0x0, 0x0, 0x0, 0x5, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x4, 0x0, 0x0, 0x0, 0x6, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x4, 0x0,
                    0x0, 0x0, 0x7, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x4, 0x0, 0x0, 0x0,
                    0x8, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x0, 0x1, 0x4,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x0, 0x2, 0x4, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x0, 0x3, 0x4, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x0, 0x4, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x5, 0x0, 0x0, 0x0, 0x5, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x5, 0x0, 0x0, 0x0, 0x6, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5, 0x0,
                    0x0, 0x0, 0x7, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x0,
                    0x8, 0x4, 0x0, 0x0, 0x0, 0x0, 0x0, 0x5, 0x0, 0x0, 0x0, 0x78, 0x5, 0x0, 0x0, 0x0,
                    0x78, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x0, 0x0, 0x1,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1,
                    0x0, 0x1, 0x0, 0x1, 0x1, 0x0, 0x0, 0x0, 0x0, 0x19, 0x0, 0x0, 0x30, 0x40, 0x0, 0xDA,
                    0x5D, 0x4E, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xDA, 0xB2, 0xF3, 0x0, 0x0,
                    0x0, 0x0, 0x5D, 0x23, 0x8D, 0xAF, 0x0, 0xDA, 0x66, 0x8D, 0x0, 0x0, 0x0, 0x0, 0x5C, 0xE5,
                    0x6D, 0x7B, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x3,
                    0x0, 0x2, 0xA9, 0x0, 0x1, 0x0, 0x3, 0xA2, 0x4D, 0xDB, 0x39, 0xC3, 0xF7, 0x2C, 0x7E, 0x8C,
                    0x68, 0x52, 0xCB, 0x1, 0x89, 0x99, 0x0, 0x7D, 0xD3, 0xFA, 0x40, 0x53, 0x0, 0x8, 0xB6, 0xAB,
                    0xDF, 0xED, 0x40, 0x88, 0x1D, 0x26, 0x30, 0xD, 0xEA, 0xE1, 0xB0, 0x3, 0x37, 0xCF, 0xE0, 0x1F,
                    0xBD, 0xFF, 0x2, 0xFF, 0xFF, 0x97, 0x7B, 0x6F, 0xDE, 0x5E, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x1, 0x96, 0x0, 0x0, 0x1, 0x8B, 0x0, 0x0, 0x1, 0x8C, 0x0, 0x0,
                    0x1, 0x17, 0x0, 0x0, 0x1, 0xA9, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x1, 0x60, 0x0, 0x3F,
                    0xFF, 0xFE, 0x0, 0x0, 0x0, 0x7F, 0x17, 0x0, 0x0, 0x30, 0x40, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x64, 0x4F, 0x76, 0x80, 0x0, 0x0, 0x2, 0x3C, 0xC0, 0x32, 0x0, 0x0, 0x9, 0x0, 0x1, 0x0,
                    0x2, 0x1, 0x3, 0x0, 0x4, 0x0, 0x5, 0x0, 0x6, 0x0, 0x7, 0x0, 0x8, 0x0, 0x0, 0x0,
                    0x1, 0x0, 0x3, 0x3C, 0x80, 0xC3, 0x85, 0xDD, 0xB9, 0x1, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0xFC, 0xFC, 0xFB, 0x3, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x68, 0x77, 0x39, 0x1, 0x68, 0x9B, 0x35, 0x2, 0x68, 0xCB, 0xCE, 0x3,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x44, 0x0, 0x0, 0x0, 0x84, 0x0, 0x0, 0x0, 0x3C, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x90, 0xDB, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0xB8, 0xDB,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0xE0, 0xDB, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x8, 0xDC,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x30, 0xDC, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x58, 0xDC,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x80, 0xDC, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0xA8, 0xDC,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0xD0, 0xDC, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0xF8, 0xDC,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x20, 0xDD, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x48, 0xDD,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x70, 0xDD, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x98, 0xDD,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0xC0, 0xDD, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0xE8, 0xDD,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x10, 0xDE, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x38, 0xDE,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x60, 0xDE, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x88, 0xDE,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0xB0, 0xDE, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0xD8, 0xDE,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x0, 0xDF, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x28, 0xDF,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x50, 0xDF, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x78, 0xDF,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0xA0, 0xDF, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0xC8, 0xDF,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0xF0, 0xDF, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x18, 0xE0,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x40, 0xE0, 0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x68, 0xE0,
                    0x28, 0x23, 0x58, 0xB7, 0x46, 0x88, 0x90, 0xD6, 0x28, 0x23, 0x58, 0x57, 0x43, 0x88, 0x40, 0xD6,
                    0x28, 0x23, 0x58, 0x17, 0x43, 0x88, 0x68, 0xD6, 0x28, 0x23, 0x58, 0x7, 0x43, 0x88, 0xB8, 0xD6,
                    0x28, 0x23, 0x58, 0xF7, 0x42, 0x88, 0xE0, 0xD6, 0x28, 0x23, 0x58, 0xB7, 0x42, 0x88, 0x98, 0xC3,
                    0x29, 0x23, 0xF9, 0xA6, 0x41, 0x88, 0x70, 0xC3, 0x29, 0x23, 0xF9, 0x96, 0x41, 0x88, 0x8, 0xD7,
                    0x28, 0x23, 0x58, 0x27, 0x41, 0x88, 0x30, 0xD7, 0x28, 0x23, 0x58, 0xE7, 0x3F, 0x88, 0x78, 0xD0,
                    0x28, 0x23, 0x58, 0xA7, 0x3F, 0x88, 0xA0, 0xD0, 0x28, 0x23, 0x58, 0xA7, 0x3F, 0x88, 0xC8, 0xD0,
                    0x28, 0x23, 0x58, 0xA7, 0x3F, 0x88, 0xF0, 0xD0, 0x28, 0x23, 0x58, 0xA7, 0x3F, 0x88, 0x18, 0xD1,
                    0x28, 0x23, 0x58, 0xA7, 0x3F, 0x88, 0x20, 0xC3, 0x29, 0x23, 0xF9, 0x86, 0x3F, 0x88, 0x48, 0xC3,
                    0x29, 0x23, 0xF9, 0x86, 0x3F, 0x88, 0x60, 0xCF, 0x28, 0x23, 0x58, 0x37, 0x3F, 0x88, 0x88, 0xCF,
                    0x28, 0x23, 0x58, 0x37, 0x3F, 0x88, 0xB0, 0xCF, 0x28, 0x23, 0x58, 0x37, 0x3F, 0x88, 0xD8, 0xCF,
                    0x28, 0x23, 0x58, 0x37, 0x3F, 0x88, 0x0, 0xD0, 0x28, 0x23, 0x58, 0x37, 0x3F, 0x88, 0x28, 0xD0,
                    0x28, 0x23, 0x58, 0x37, 0x3F, 0x88, 0x50, 0xD0, 0x28, 0x23, 0x58, 0x37, 0x3F, 0x88, 0xD0, 0xD2,
                    0x28, 0x23, 0x58, 0x17, 0x3F, 0x88, 0xD8, 0xC4, 0x29, 0x23, 0xF9, 0xF6, 0x3E, 0x88, 0xB0, 0xC4,
                    0x29, 0x23, 0xF9, 0xE6, 0x3E, 0x88, 0x80, 0xD2, 0x28, 0x23, 0x58, 0xC7, 0x3E, 0x88, 0xA8, 0xD2,
                    0x28, 0x23, 0x58, 0xB7, 0x3E, 0x88, 0xF8, 0xD2, 0x28, 0x23, 0x58, 0xA7, 0x3E, 0x88, 0x20, 0xD3,
                    0x28, 0x23, 0x58, 0x67, 0x3E, 0x88, 0x1
                });
            }

            public override S2CCharacterDecideCharacterIdRes Read(IBuffer buffer)
            {
                S2CCharacterDecideCharacterIdRes obj = new S2CCharacterDecideCharacterIdRes();
                ReadServerResponse(buffer, obj);
                obj.CharacterId = ReadUInt32(buffer);
                obj.CharacterId = ReadUInt32(buffer);
                ReadUInt32(buffer);
                ReadUInt32(buffer);
                obj.FirstName = ReadMtString(buffer);
                obj.LastName = ReadMtString(buffer);
                return obj;
            }
        }
    }
}
