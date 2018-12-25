class FlipBit {
        // flip the bit of a given integer, if input is 11 in integer => 1011 in binary, then output is 1101 in binary, 13 in integer
        public static int Flip(int n) {
        var flipped = 0;
        while(n > 0) { // start from whole integer, to process on the right most bit (LSB) of n
            flipped <<= 1; // move up the previously processed bit one position to the left, add one more LSB, start the least significant bit with 0
            if ((n & 1) == 1) {
                flipped ^= 1; // if the least significant bit of n is 1, then make the flipped one's bit 1.
            }
            n >>= 1; // move one bit down to the right, making ready for the next digit after the right most one
        }
        return flipped;
    }
}