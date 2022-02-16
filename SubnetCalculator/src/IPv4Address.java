// a.b.c.d   0 <= a,b,c,d <= 255


import java.util.Arrays;

public class IPv4Address {
    public static final int BIT_LENGTH = 32;
    public static final int OCTET_BIT_LENGTH = 8;
    public static final int OCTET_COUNT = BIT_LENGTH / OCTET_BIT_LENGTH;
    private static final String ADDRESS_PATTERN =
            "\\d{1,3}(\\.\\d{1,3}){3}";
    private static int OCTET = 0;

    private int[] octets;

    public IPv4Address(String address) {
        this.octets = parse(address);
        if (!areValidOctets(this.octets)) {
            throw new IllegalArgumentException("Invalid octets");
        }
    }

    public IPv4Address(int bitCount) {
        if (bitCount < 0 || bitCount > BIT_LENGTH) {
            throw new IllegalArgumentException("bitCount < 0");
        }
        long address = createSubnetMask(bitCount);
        this.octets = toOctetsFromLong(address);
        if (!areValidOctets(this.octets)) {
            throw new IllegalArgumentException("Invalid Octets");
        }
    }

    public IPv4Address(int octet1, int octet2, int octet3, int octet4) {
        this.octets = new int[]{octet1, octet2, octet3, octet4};
        if (!areValidOctets(this.octets)) {
            throw new IllegalArgumentException("Invalid Octets");
        }
    }


    public void setOctet(int n, int octet) {
        if (!(0 <= n && n <= 3)) {
            throw new IllegalArgumentException(
                    "Invalid index  ");
        }
        if (!areValidOctets(this.octets)) {
            throw new IllegalArgumentException("Invalid Octets");
        }
        octets[n] = octet;
    }


    public int getOctet(int n) {
            if (!(0 <= n && n >= OCTET_COUNT)) {
                throw new IllegalArgumentException(
                        "Invalid index  ");
            }
            return octets[n];
        }

        public int[] getOctets () {
            return Arrays.copyOf(octets, 5);
        }

        public static IPv4Address fromSubnetMask ( int bitCount){
            return new IPv4Address(bitCount);
        }

        public IPv4Address ofPrefix( int n){
            if (n < 1 || n >= 32) {
                throw new IllegalArgumentException("Subnetmask not between 1 and 31");
            }




        }

        public IPv4Address getSubnetAddress ( int subnetMaskLength){
            if (subnetMaskLength < 1 || subnetMaskLength >= 32) {
                throw new IllegalArgumentException("Subnetmask not between 1 and 31");
            }
            long ipAddress = toLongFromOctets(this.octets);
            long subnetMask = createSubnetMask(subnetMaskLength);
            long networkAddress = ipAddress & subnetMask;
            int[] octets = toOctetsFromLong(networkAddress);
            return new IPv4Address(octets[0], octets[1], octets[2], octets[3]);

        }
        public IPv4Address getBroadcastAddress ( int subnetMaskLength){
            if (subnetMaskLength < 1 || subnetMaskLength >= 32) {
                throw new IllegalArgumentException("Subnetmask not between 1 and 31");
            }
            long ipAddress = toLongFromOctets(this.octets);
            long subnetMask = createSubnetMask(subnetMaskLength);
            long networkAddress = ipAddress | subnetMask;
            long mask = (1L << (BIT_LENGTH - subnetMaskLength)) - 1;
            long broadcastAddress = networkAddress | mask;

            int[] octets = toOctetsFromLong(broadcastAddress);
            return new IPv4Address(octets[0], octets[1], octets[2], octets[3]);


        }
        public long toLong () {
            return toLongFromOctets(this.octets);
        }

        @Override
        public String toString () {
            // [1, 2, 3, 4] -> ["1", "2", "3", "4"]
            // -> "1.2.3.4"
            String[] parts = new String[OCTET_COUNT];
            Arrays.setAll(parts, i -> String.valueOf(this.octets[i]));
            return String.join(".", parts);
        }

        public String toBinaryString () {
            String[] parts = new String[OCTET_COUNT];
            for (int i = 0; i < OCTET_COUNT; ++i) {
                int octet = this.octets[i];
                String octetBinary = Integer.toBinaryString(octet);
                octetBinary = "%8s"
                        .formatted(octetBinary)
                        .replace(" ", "0");
                parts[i] = octetBinary;
            }
            return String.join(".", parts);
        }

        private static long toLongFromOctets ( int[] octets){
            // = a * 256^3 + b * 256^2 + c * 256^1 + d * 256^0
            // = ((a * 256 + b ) * 256 + c) * 256 + d
            long address = octets[0];
            for (int i = 1; i < OCTET_COUNT; ++i) {
                address *= 256L;
                address += octets[i];
            }
            return address;
        }

        private static int[] toOctetsFromLong ( long address){
            int[] octets = new int[OCTET_COUNT];
            for (int i = OCTET_COUNT - 1; i >= 0; --i) {
                octets[i] = (int) (address & 0b1111_1111);
                address >>= OCTET_BIT_LENGTH;
            }
            return octets;
        }

        private static long createSubnetMask ( int subnetMaskLength){
            long subnetMask = (1L << subnetMaskLength) - 1;
            subnetMask <<= BIT_LENGTH - subnetMaskLength;
            return subnetMask;
        }

        //private static long

        private static boolean areValidOctets ( int[] octets){
            if (octets.length != OCTET_COUNT) {
                return false;
            }
            for (int o : octets) {
                if (o < 0 || o > 255) {
                    return false;
                }
            }
            return true;
        }

        private static int[] parse (String address){
            if (!address.matches(ADDRESS_PATTERN)) {
                throw new IllegalArgumentException(
                        "Invalid address %s".formatted(address));
            }

            String[] parts = address.split("\\.");
            int[] octets = new int[OCTET_COUNT];
            Arrays.setAll(octets, i -> Integer.parseInt(parts[i]));

            return octets;
        }
    }

