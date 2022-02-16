import java.util.Arrays;

public class StringSplicer {
    private final int chunkSize;

    public StringSplicer(int chunkSize) {
        if (chunkSize < 1) {
            throw new IllegalArgumentException("chunkSize < 1");
        }
        this.chunkSize = chunkSize;
    }

    public String[] splice(String s) {
        String[] slices = new String[s.length()];
        int numSlices = 0;

        while (s.length() > 0) {
            int substringLength = Math.min(s.length(), chunkSize);
            String chunk = s.substring(0, substringLength);
            slices[numSlices++] = chunk;
            s = s.substring(substringLength);
        }

        return Arrays.copyOf(slices, numSlices);
    }
}
