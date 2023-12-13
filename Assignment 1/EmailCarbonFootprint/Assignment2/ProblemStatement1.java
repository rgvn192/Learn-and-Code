public class Utils
{
    int firstOperand;
    double secondOperand;
    String convertedUppercaseText;
 
    public void displaySum(int firstOperand, int secondOperand)
    {
        int additionResult = firstOperand + secondOperand;
        System.out.println("Result: " + additionResult);
    }
 
    public void displayInUpperCase(String inputText)
    {
        convertedUppercaseText = inputText.toUpperCase();
        System.out.println("Updated String: " + convertedUppercaseText);
    }
}
 
public class Program
{
    public static void main(String[] args)
    {
        Utils util = new Utils();
        util.firstOperand = 10;
        util.secondOperand = 20.5;
        util.convertedUppercaseText = "hello";
 
        util.displaySum(util.firstOperand, 5);
        util.displayInUpperCase("world");
    }
}
