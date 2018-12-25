class FlipBit {
        // flip the bit of a given integer, if input is 11 in integer => 1011 in binary, then output is 1101 in binary, 13 in integer
        public static int Flip(int n) {
        var flipped = 0;
        while(n > 0) { // start from the most significant bit
            flipped <<= 1; // move the bit up one position to the right, start the least significant bit with 0
            if ((n & 1) == 1) {
                flipped ^= 1; // if the least significant bit of n is 1, then make the flipped one's bit 1.
            }
            n >>= 1; // move one bit down to the left
        }
        return flipped;
    }
}