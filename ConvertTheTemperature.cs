public class Solution {
    public double[] ConvertTemperature(double celsius) {
        Math.Round(celsius, 2);

        double kelvin = Math.Round(celsius + 273.15, 5);
        double fahrenheit = Math.Round(celsius * 1.80 + 32.00, 5);

        return [kelvin, fahrenheit];
    }
}
