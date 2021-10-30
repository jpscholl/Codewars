public class Kata
{
  public static string Bmi(double weight, double height)
  {
    double BMI = weight / (height * height);

    System.Console.WriteLine(BMI);
    
    return (BMI > 30) ? "Obese" :
    (BMI <= 30 && BMI > 25) ? "Overweight" :
    (BMI <= 25.0 && BMI > 18.5) ? "Normal" : "Underweight";
  }
}
