using System;
using System.Drawing;

namespace RE3REmakeSRT
{
    public enum ItemEnumeration : int
    {
        None = 0
    }

    public enum WeaponEnumeration : int
    {
        None = -1
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
