using System;
using MachineLearningWithNetML.Model;
namespace MachineLearningWithNet
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new ModelInput();
            input.SentimentText = "This is Ok";

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);
            Console.WriteLine($"Text: {input.SentimentText}\nIs Toxic: {result.Prediction}");
            Console.ReadKey();
        }
    }
}
