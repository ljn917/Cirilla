﻿using System.Runtime.InteropServices;

namespace Cirilla.Core.Structs.Native
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public struct CharacterAppearance
    {
        // All colors are ABGR

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U1)]
        public byte[] Makeup2Color;

        public float Makeup2PosX;
        public float Makeup2PosY;
        public float Makeup2SizeX;
        public float Makeup2SizeY;
        public float Makeup2Glossy;
        public float Makeup2Metallic;
        public int Makeup2Type;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U1)]
        public byte[] Makeup1Color;

        public float Makeup1PosX;
        public float Makeup1PosY;
        public float Makeup1SizeX;
        public float Makeup1SizeY;
        public float Makeup1Glossy;
        public float Makeup1Metallic;
        public int Makeup1Type;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U1)]
        public byte[] LeftEyeColor;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U1)]
        public byte[] RightEyeColor;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U1)]
        public byte[] EyebrowColor;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U1)]
        public byte[] FacialHairColor;

        public byte EyeWidth;
        public byte EyeHeight;
        public byte SkinColorX;
        public byte SkinColorY;
        public byte Age;
        public byte Wrinkles;
        public byte NoseHeight;
        public byte MouthHeight;
        public int Gender; // 0 = male, 1 = female
        public byte BrowType;
        public byte FaceType;
        public byte EyeType;
        public byte NoseType;
        public byte MouthType;
        public byte EyebrowType;
        public byte EyelashLength; // 0 = short, 1 = average, 2 = long
        public byte FacialHairType;
        public int Unk1; // Unused?

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U1)]
        public byte[] HairColor;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4, ArraySubType = UnmanagedType.U1)]
        public byte[] ClothingColor;

        public short HairType;
        public byte ClothingType;
        public byte Voice;
        public int Expression;
    }
}
