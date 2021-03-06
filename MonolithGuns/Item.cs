﻿namespace MonolithItems
{
    class Item
    {
        public static int count = 0;
        public string Name;
        public string WeaponPart;
        public int Crafting;
        public int CopperBar;
        public int IronBar;
        public int SteelBar;
        public int SilverBar;
        public int GoldBar;
        public int TitaniumBar;

        public int PartCopper;
        public int PartIron;
        public int PartSteel;
        public int PartSilver;
        public int PartGold;

        public double CoalChunk => (CopperBar * 1d / 2d) + (IronBar * 3d / 4d) + ((SteelBar * (3d / 4d) * 3) + 3) + (SilverBar * 1d) + (GoldBar * 1d) + (TitaniumBar * 1d);
        public double CopperChunk => CopperBar * 1.5;
        public double IronChunk => (IronBar * 1.5) + 3 * (SteelBar * 1.5);
        public double SilverChunk => SilverBar * 1.5;
        public double GoldChunk => GoldBar * 1.5;
        public double TitaniumChunk => TitaniumBar * 1.5;

        public double PartCoalChunk => (PartCopper * 1d / 2d) + (PartIron * 3d / 4d) + ((PartSteel * (3d / 4d) * 3) + 3) + (PartSilver * 1d) + (PartGold * 1d);
        public double PartCopperChunk => PartCopper * 1.5;
        public double PartIronChunk => (PartIron * 1.5) + 3 * (PartSteel * 1.5);
        public double PartSilverChunk => PartSilver * 1.5;
        public double PartGoldChunk => PartGold * 1.5;
    }
}
