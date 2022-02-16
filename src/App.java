public class App {
    public static void main(String[] args) {
//        System.out.println(IPv4Address.BIT_LENGTH);

//        new IPv4Address("192.168.178.1");
////        new IPv4Address("192.168.178.");
////        new IPv4Address("300.300.300.300");
//        new IPv4Address("255.255.255.255");
//        System.out.println(new IPv4Address("0.0.0.1").toLong());
//        System.out.println(new IPv4Address("0.0.1.0").toLong());
//        System.out.println(new IPv4Address("255.255.255.255").toLong());
//        System.out.println(new IPv4Address("255.255.255.255"));
//        System.out.println(new IPv4Address("1.1.1.1").toBinaryString());
//        System.out.println(new IPv4Address(4).toBinaryString());
//        System.out.println(new IPv4Address(0).toBinaryString());
//        System.out.println(new IPv4Address(8).toBinaryString());
//        System.out.println(new IPv4Address(30));

        IPv4Address address = new IPv4Address("240.168.178.1");
        IPv4Address networkAddress = address.getSubnetAddress(30);
        IPv4Address subnetMask = IPv4Address.fromSubnetMask(30);
        System.out.println(address);
        System.out.println(subnetMask);
        System.out.println(networkAddress);
        System.out.println(address.toBinaryString());
        System.out.println(subnetMask.toBinaryString());
        System.out.println(networkAddress.toBinaryString());

    }
}
