class CurrencyConverter {
    double[] exchangeRates = new double[] {63.0, 3.0, 3.0, 595.0, 18.0, 107.0, 2.0};

    /*
    int rupee = 63;
    int dirham = 3;
    int real = 3;
    int chilean_peso = 595;
    int mexican_peso = 18;
    int _yen = 107;
    int $australian = 2;
    int dollar;
    int Rupee = 63;
    */

    void printCurrencies() {
        System.out.println("exchangeRates: " + exchangeRates.length);
        System.out.println("rupee: " + exchangeRates[0]);
        System.out.println("dirham: " + exchangeRates[1]);
        System.out.println("real " + exchangeRates[2]);
        System.out.println("chilean peso: " + exchangeRates[3]);
        System.out.println("mexican peso: " + exchangeRates[4]);
        System.out.println("yen: " + exchangeRates[5]);
        System.out.println("austratilian: " + exchangeRates[6]);
    }

    public static void main (String[] args) {
        CurrencyConverter cc = new CurrencyConverter();
        cc.printCurrencies();
    }
}