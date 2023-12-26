namespace SRPAssignmentExample2.Model
{
    public class AreaFileWriter
    {
        public void WriteAreaToFile(double area)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("area.txt"))
                {
                    writer.Write("Area: " + area);
                }
            }
            catch (IOException e)
            {
                Console.Error.WriteLine("Error writing to file: " + e.Message);
            }
        }

    }
}
