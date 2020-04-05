using System;
using System.Drawing;

namespace RE3REmakeSRT
{
    public enum ItemEnumeration : int
    {
        None = 0x0000,
        First_Aid_Spray = 0x0001,
        Green_Herb = 0x0002,
        Red_Herb = 0x0003,
        Mixed_Herb_GG = 0x0005,
        Mixed_Herb_GR = 0x0006,
        Mixed_Herb_GGG = 0x0009,
        Green_Herb2 = 0x0016,
        Red_Herb2 = 0x0017,
        Handgun_Ammo = 0x001F,
        Shotgun_Shells = 0x0020,
        Assault_Rifle_Ammo = 0x0021,
        MAG_Ammo = 0x0022,
        Mine_Rounds = 0x0024,
        Explosive_Rounds = 0x0025,
        Acid_Rounds = 0x0026,
        Flame_Rounds = 0x0027,
        Gunpowder = 0x003D,
        HighGrade_Gunpowder = 0x003E,
        Explosive_A = 0x003F,
        Explosive_B = 0x0040,
        Moderator_Handgun = 0x004C,
        Dot_Sight_Handgun = 0x004D,
        Extended_Magazine_Handgun = 0x004E,
        SemiAuto_Barrel_Shotgun = 0x005B,
        Tactical_Stock_Shotgun = 0x005C,
        Shell_Holder_Shotgun = 0x005D,
        Scope_Assault_Rifle = 0x0060,
        Dual_Magazine_Assault_Rifle = 0x0061,
        Tactical_Grip_Assault_Rifle = 0x0062,
        Extended_Barrel_MAG = 0x0065,
        Audiocassette_Tape = 0x0083,
        Lock_Pick = 0x0097,
        Bolt_Cutters = 0x0098,
        Battery = 0x00A1,
        Safety_Deposit_Key = 0x00A2,
        Brads_ID_Card = 0x00A4,
        Detonator_No_Battery = 0x00A5,
        Detonator = 0x00A6,
        Fire_Hose = 0x00B5,
        Kendos_Gate_Key = 0x00B6,
        Case_Lock_Pick = 0x00B9,
        Battery_Pack = 0x00BA,
        Green_Jewel = 0x00BB,
        Blue_Jewel = 0x00BC,
        Red_Jewel = 0x00BD,
        Fancy_Box_Green_Jewel = 0x00C0,
        Fancy_Box_Blue_Jewel = 0x00C1,
        Fancy_Box_Red_Jewel = 0x00C2,
        Hospital_ID_Card = 0x00D3,
        Tape_Player_Tape_Inserted = 0x00D4,
        Audiocassette_Tape2 = 0x00D5,
        Tape_Player = 0x00D6,
        Vaccine_Sample = 0x00D7,
        Detonator2 = 0x00D9,
        Locker_Room_Key = 0x00DA,
        Fuse3 = 0x00DE,
        Fuse2 = 0x00DF,
        Fuse1 = 0x00E0,
        Wristband = 0x00E7,
        Override_Key = 0x00E8,
        Vaccine = 0x00E9,
        Culture_Sample = 0x00EA,
        Liquidfilled_Test_Tube = 0x00EB,
        Vaccine_Base = 0x00EC,
        Hip_Pouch = 0x0105,
        Fire_Hose2 = 0x0108,
        Iron_Defense_Coin = 0x012D,
        Assault_Coin = 0x012E,
        Recovery_Coin = 0x012F,
        Crafting_Companion = 0x0130,
        STARS_Field_Combat_Manual = 0x0131,
        Supply_Crate_Extended_Magazine_Handgun = 0x0137,
        Supply_Crate_Moderator_Handgun = 0x0138,
        Supply_Crate_Shotgun_Shells = 0x0139,
        Supply_Crate_Acid_Rounds = 0x013A,
        Supply_Crate_Flame_Rounds = 0x013B,
        Supply_Crate_Extended_Barrel_MAG = 0x013C,
    }

    public enum WeaponEnumeration : int
    {
        None = -1,
        G19_Handgun = 0x01,
        G18_Burst_Handgun = 0x02,
        G18_Handgun = 0x03,
        Samurai_Edge = 0x04,
        Infinite_MUP_Handgun = 0x07,
        Shotgun = 0x0B,
        CQBR_Assault_Rifle = 0x15,
        Infinite_CQBR_Assault_Rifle = 0x16,
        Lightning_Hawk = 0x1F,
        RAIDEN = 0x20,
        Grenade_Launcher = 0x2A,
        Combat_Knife_Carlos = 0x2E,
        Survival_Knife_Jill = 0x2F,
        HOT_DOGGER = 0x30,
        Infinite_Rocket_Launcher = 0x31,
        Hand_Grenade = 0x41,
        Flash_Grenade = 0x42,
    }

    [Flags]
    public enum AttachmentsFlag : int
    {
        None = 0x00,
        First = 0x01, // Weapons that never occupy two-slots will not have this flag for attachments.
        Second = 0x02,
        Third = 0x04
    }

    public struct Weapon : IEquatable<Weapon>
    {
        public WeaponEnumeration WeaponID;
        public AttachmentsFlag Attachments;

        public bool Equals(Weapon other) => (int)this.WeaponID == (int)other.WeaponID && (int)this.Attachments == (int)other.Attachments;
    }
}
