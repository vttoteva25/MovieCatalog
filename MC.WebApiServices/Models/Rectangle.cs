using System.Text.Json.Serialization;

namespace MC.WebApiServices.Models
{
    public class Rectangle
    {
        private double a {  get; set; }
        private double b { get; set; }

        [JsonPropertyName("Perimeter")]
        public string Perimeter { get; set; }

        [JsonPropertyName("Area")]
        public string Area { get; set; }

        public Rectangle(string a, string b)
        {
            this.a = double.Parse(a);
            this.b = double.Parse(b);
            this.Perimeter = CalculatePerimeter();
            this.Area = CalculateArea();
        }

        private string CalculatePerimeter()
        {
            return (2 * a + 2 * b).ToString();
        }

        private string CalculateArea()
        {
            return (a * b).ToString();
        }
    }
}
