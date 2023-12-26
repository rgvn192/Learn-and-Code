public class Utils
{
    int firstOperand;
    double secondOperand;
    String text;
 
    public void displaySum(int firstOperand, int secondOperand)
    {
        int sum = firstOperand + secondOperand;
        System.out.println("Result: " + sum);
    }
 
    public void displayInUpperCase(String inputText)
    {
        text = inputText.toUpperCase();
        System.out.println("Updated String: " + text);
    }
}
 
public class Program
{
    public static void main(String[] args)
    {
        Utils util = new Utils();
        util.firstOperand = 10;
        util.secondOperand = 20.5;
        util.text = "hello";
 
        util.displaySum(util.firstOperand, 5);
        util.displayInUpperCase("world");
    }
}
