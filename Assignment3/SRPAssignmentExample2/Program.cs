using SRPAssignment.Model;
using SRPAssignmentExample2.Model;

public class Program
{
    public static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5.0, 3.0);
        double area = rectangle.CalculateArea();

        AreaFileWriter areaFileWriter = new AreaFileWriter();
        areaFileWriter.WriteAreaToFile(area);

        rectangle.DisplayArea(area);
        
    }
}
