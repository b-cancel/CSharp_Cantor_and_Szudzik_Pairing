namespace pairingKit
{
    /// <summary>
    /// Description: public functions for 2 tuple pairing
    /// Programmer: Bryan Cancel
    /// Combine Sequence (a,b) -> z
    /// </summary>

    /*
    * C# Integral Types
    * 
    * -------------------------using BYTES
    * sbyte	-128 to 127	Signed 8-bit integer
    * byte	    0 to 255	Unsigned 8-bit integer
    * COMBOS: (25_6)^2 = 65,536 [exactly what ushort can store]
    * 
    * SZUDZIK PAIR MAX: (25_6)^2 = 65,536 [exactly what ushort can store]
    * 
    * -------------------------using SHORTS
    * short	-32,768 to 32,767	Signed 16-bit integer
    * ushort	0 to 65,535	Unsigned 16-bit integer
    * COMBOS: (65,53_6)^2 = 4,294,967,296 [exactly what uint can store]
    * 
    * SZUDZIK PAIR MAX: (65,53_6)^2 = 4,294,967,296 [exactly what uint can store]
    * 
    * -------------------------using INTS
    * int	    -2,147,483,648 to 2,147,483,647	Signed 32-bit integer
    * uint	    0 to 4,294,967,295	Unsigned 32-bit integer
    * COMBOS: (4,294,967,29_6)^2 = 18,446,744,073,709,551,616 [exactly what ulong can store]
    * 
    * SZUDZIK PAIR MAX: (4,294,967,29_6)^2 = 18,446,744,073,709,551,616 [exactly what ulong can store]
    * 
    * -------------------------using LONGS-------------------------STOP(I dont want to use BigInteger)-------------------------
    * long	    -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807	Signed 64-bit integer
    * ulong	0 to 18,446,744,073,709,551,615	Unsigned 64-bit integer
    * COMBOS: (18,446,744,073,709,551,61_6)^2 = 340,282,366,920,938,463,463,374,607,431,768,211,456 [perhaps using Big Integer]
    * 
    * SZUDZIK PAIR MAX: (18,446,744,073,709,551,61_6)^2 = 340,282,366,920,938,463,463,374,607,431,768,211,456 [perhaps using Big Integer]
    */

    public static class _2tuple //3 type ranges [(byte/sbyte)|(ushort/short)|(uint,int)]
    {
        #region (X,Y) -> Z

        //(sbyte/byte),(short/ushort),(int/uint) [6]
        //[6]^2 = 36 possible combos [sets of 6]

        #region starting with sbyte

        public static ushort combine(sbyte x, sbyte y) {
            return tupleBase.byteSzudzik2tupleCombine(tupleBase.sbyteToByte(x), tupleBase.sbyteToByte(y));
        } //return (ushort)

        public static ushort combine(sbyte x, byte y) {
            return tupleBase.byteSzudzik2tupleCombine(tupleBase.sbyteToByte(x), y);
        } //return (ushort)

        public static uint combine(sbyte x, short y) {
            return tupleBase.ushortSzudzik2tupleCombine((ushort)tupleBase.sbyteToByte(x), tupleBase.shortToUshort(y));
        } //return (uint)

        public static uint combine(sbyte x, ushort y) {
            return tupleBase.ushortSzudzik2tupleCombine((ushort)tupleBase.sbyteToByte(x), y);
        } //return (uint)

        public static ulong combine(sbyte x, int y) {
            return tupleBase.uintSzudzik2tupleCombine((uint)tupleBase.sbyteToByte(x), tupleBase.intToUint(y));
        } //return (ulong)

        public static ulong combine(sbyte x, uint y) {
            return tupleBase.uintSzudzik2tupleCombine((uint)tupleBase.sbyteToByte(x), y);
        } //return (ulong)

        #endregion

        #region starting with byte

        public static ushort combine(byte x, sbyte y) {
            return tupleBase.byteSzudzik2tupleCombine(x, tupleBase.sbyteToByte(y));
        } //return (ushort)

        public static ushort combine(byte x, byte y) {
            return tupleBase.byteSzudzik2tupleCombine(x, y);
        } //return (ushort)

        public static uint combine(byte x, short y) {
            return tupleBase.ushortSzudzik2tupleCombine((ushort)x, tupleBase.shortToUshort(y));
        } //return (uint)

        public static uint combine(byte x, ushort y) {
            return tupleBase.ushortSzudzik2tupleCombine((ushort)x, y);
        } //return (uint)

        public static ulong combine(byte x, int y) {
            return tupleBase.uintSzudzik2tupleCombine((uint)x, tupleBase.intToUint(y));
        } //return (ulong)

        public static ulong combine(byte x, uint y) {
            return tupleBase.uintSzudzik2tupleCombine((uint)x, y);
        } //return (ulong)

        #endregion

        #region starting with short

        public static uint combine(short x, sbyte y) {
            return tupleBase.ushortSzudzik2tupleCombine(tupleBase.shortToUshort(x), (ushort)tupleBase.sbyteToByte(y));
        } //return (uint)

        public static uint combine(short x, byte y) {
            return tupleBase.ushortSzudzik2tupleCombine(tupleBase.shortToUshort(x), (ushort)y);
        } //return (uint)

        public static uint combine(short x, short y) {
            return tupleBase.ushortSzudzik2tupleCombine(tupleBase.shortToUshort(x), tupleBase.shortToUshort(y));
        } //return (uint)

        public static uint combine(short x, ushort y) {
            return tupleBase.ushortSzudzik2tupleCombine(tupleBase.shortToUshort(x), y);
        } //return (uint)

        public static ulong combine(short x, int y) {
            return tupleBase.uintSzudzik2tupleCombine((uint)x, tupleBase.intToUint(y));
        } //return (ulong)

        public static ulong combine(short x, uint y) {
            return tupleBase.uintSzudzik2tupleCombine((uint)tupleBase.shortToUshort(x), y);
        } //return (ulong)

        #endregion

        #region starting with ushort

        public static uint combine(ushort x, sbyte y) {
            return tupleBase.ushortSzudzik2tupleCombine(x, (ushort)tupleBase.sbyteToByte(y));
        } //return (uint)

        public static uint combine(ushort x, byte y) {
            return tupleBase.ushortSzudzik2tupleCombine(x, (ushort)y);
        } //return (uint)

        public static uint combine(ushort x, short y) {
            return tupleBase.ushortSzudzik2tupleCombine(x, tupleBase.shortToUshort(y));
        } //return (uint)

        public static uint combine(ushort x, ushort y) {
            return tupleBase.ushortSzudzik2tupleCombine(x, y);
        } //return (uint)

        public static ulong combine(ushort x, int y) {
            return tupleBase.uintSzudzik2tupleCombine((uint)x, tupleBase.intToUint(y));
        } //return (ulong)

        public static ulong combine(ushort x, uint y) {
            return tupleBase.uintSzudzik2tupleCombine((uint)x, y);
        } //return (ulong)

        #endregion

        #region starting with int

        public static ulong combine(int x, sbyte y) {
            return tupleBase.uintSzudzik2tupleCombine(tupleBase.intToUint(x), (uint)tupleBase.sbyteToByte(y));
        } //return (ulong)

        public static ulong combine(int x, byte y) {
            return tupleBase.uintSzudzik2tupleCombine(tupleBase.intToUint(x), (uint)y);
        } //return (ulong)

        public static ulong combine(int x, short y) {
            return tupleBase.uintSzudzik2tupleCombine(tupleBase.intToUint(x), (uint)tupleBase.shortToUshort(y));
        } //return (ulong)

        public static ulong combine(int x, ushort y) {
            return tupleBase.uintSzudzik2tupleCombine(tupleBase.intToUint(x), (uint)y);
        } //return (ulong)

        public static ulong combine(int x, int y) {
            return tupleBase.uintSzudzik2tupleCombine(tupleBase.intToUint(x), tupleBase.intToUint(y));
        } //return (ulong)

        public static ulong combine(int x, uint y) {
            return tupleBase.uintSzudzik2tupleCombine(tupleBase.intToUint(x), y);
        } //return (ulong)

        #endregion

        #region starting with uint

        public static ulong combine(uint x, sbyte y) {
            return tupleBase.uintSzudzik2tupleCombine(x, (uint)tupleBase.sbyteToByte(y));
        } //return (ulong)

        public static ulong combine(uint x, byte y) {
            return tupleBase.uintSzudzik2tupleCombine(x, (uint)y);
        } //return (ulong)

        public static ulong combine(uint x, short y) {
            return tupleBase.uintSzudzik2tupleCombine(x, (uint)tupleBase.shortToUshort(y));
        } //return (ulong)

        public static ulong combine(uint x, ushort y) {
            return tupleBase.uintSzudzik2tupleCombine(x, (uint)y);
        } //return (ulong)

        public static ulong combine(uint x, int y) {
            return tupleBase.uintSzudzik2tupleCombine(x, tupleBase.intToUint(y));
        } //return (ulong)

        public static ulong combine(uint x, uint y) {
            return tupleBase.uintSzudzik2tupleCombine(x, y);
        } //return (ulong)

        #endregion

        #endregion

        #region Z -> (X,Y)

        public static byte[] reverse(ushort z)
        {
            return tupleBase.byteSzudzik2tupleReverse(z);
        }

        public static ushort[] reverse(uint z)
        {
            return tupleBase.ushortSzudzik2tupleReverse(z);
        }

        public static uint[] reverse(ulong z)
        {
            return tupleBase.uintSzudzik2tupleReverse(z);
        }

        #endregion
    }
}