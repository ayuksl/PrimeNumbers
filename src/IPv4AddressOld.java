import java.util.Arrays;

public class IPv4AddressOld {
    private static final int NUM_OCTETS = 4;
    private static final int NUM_BITS = 32;
    private static final int BITS_PER_OCTET = NUM_BITS / NUM_OCTETS;
    private static final String ADDRESS_PATTERN = "^\\d{1,3}(\\.\\d{1,3}){3}$";

    private final int[] octets;

    public IPv4AddressOld(String address) {
        octets = parseOctets(address);
        if (!areValidOctets(octets)) {
            throw new IllegalArgumentException("Invalid octets");
        }
    }

    public IPv4AddressOld(int octet1, int octet2, int octet3, int octet4) {
        octets = new int[]{octet1, octet2, octet3, octet4};
        if (!areValidOctets(octets)) {
            throw new IllegalArgumentException("Invalid octets");
        }
    }

    public static IPv4AddressOld ofSubnetMask(int length) {
        int[] octets = computeOctetsByMask(length);
        return new IPv4AddressOld(octets[0], octets[1], octets[2], octets[3]);
    }

    private static int[] computeOctetsByMask(int maskLength) {
        if (maskLength < 1) throw new IllegalArgumentException("maskLength < 0");

        long mask = (1L << maskLength) - 1; // f.e. length = 3 -> 0111b
        mask <<= NUM_BITS - maskLength; // f.e. length = 3 -> 111000...000b (32 Bits)
        long octetMask = 0xffL << (NUM_BITS - BITS_PER_OCTET); // 11111111000...000b

        int[] octets = new int[NUM_OCTETS];
        int nextShift = NUM_BITS - BITS_PER_OCTET;
        for (int i = 0; i < octets.length; ++i) {
            octets[i] = (int) ((mask & octetMask) >> nextShift);
            octetMask >>= BITS_PER_OCTET;
            nextShift -= BITS_PER_OCTET;
        }

        return octets;
    }

    public int[] getOctets() {
        return Arrays.copyOf(octets, octets.length);
    }

    @Override
    public String toString() {
        String[] parts = new String[NUM_OCTETS];
        Arrays.setAll(parts, i -> String.valueOf(octets[i]));
        return String.join(".", parts);
    }

    private static int[] parseOctets(final String address) {
        if (!address.matches(ADDRESS_PATTERN)) {
            throw new IllegalArgumentException(
                    "Invalid Address '%s'".formatted(address));
        }
        String[] parts = address.split("\\.");
        int[] octets = new int[NUM_OCTETS];
        Arrays.setAll(octets, i -> Integer.parseInt(parts[i]));
        return octets;
    }

    private static boolean areValidOctets(int[] octets) {
        for (int octet : octets) {
            if (octet < 0 || octet > 255) {
                return false;
            }
        }
        return true;
    }

}
