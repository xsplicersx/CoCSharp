﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoCSharp.Networking.Packets
{
    public class AvatarProfileRequestPacket : IPacket
    {
        public ushort ID { get { return 0x37F5; } }

        public long UserID;
        private long UserID2;
        private byte Unknown1;

        public void ReadPacket(PacketReader reader)
        {
            UserID = reader.ReadInt64();
            UserID2 = reader.ReadInt64();
            Unknown1 = (byte)reader.ReadByte();
        }

        public void WritePacket(PacketWriter writer)
        {
            writer.WriteInt64(UserID);
            writer.WriteInt64(UserID2);
            writer.WriteByte(Unknown1);
        }
    }
}
