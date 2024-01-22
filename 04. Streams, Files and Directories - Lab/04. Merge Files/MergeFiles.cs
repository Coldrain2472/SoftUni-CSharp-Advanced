namespace MergeFiles
{
    using System;
    using System.IO;
    using System.Reflection.PortableExecutable;

    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader firstReader = new StreamReader(firstInputFilePath))
            {
                using (StreamReader secondReader = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string firstLine = "";
                        string secondLine = " ";
                        while ((firstLine = firstReader.ReadLine()) != null && (secondLine = secondReader.ReadLine()) != null)
                        {
                            if (secondLine != null)
                            {
                                writer.WriteLine(firstLine);
                            }

                            if (firstLine != null)
                            {
                                writer.WriteLine(secondLine);
                            }
                        }
                    }
                }
            }
        }
    }
}

