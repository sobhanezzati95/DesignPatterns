namespace Design_Patterns.Creational_Patterns.Builder
{
    public class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Name { get; set; }


        public void DisplayInfo()
        {
            Console.WriteLine($"Product Name:{this.Name}");
            Console.WriteLine($"Product Part1:{this.Part1}");
            Console.WriteLine($"Product Part2:{this.Part2}");
        }
    }


    public abstract class Builder
    {
        protected Product product;
        protected Builder()
        {
            product = new Product();
        }

        public abstract void BuildPart1();
        public abstract void BuildPart2();
        public virtual Product GetResult()
        {
            return product;
        }
    }

    public class ConcreateBuilder : Builder
    {
        public override void BuildPart1()
        {
            product.Part1 = "Part-1";
        }

        public override void BuildPart2()
        {
            product.Part2 = "Part-2";
        }
        public override Product GetResult()
        {
            product.Name = "Product 1";
            Console.WriteLine($"{product.Name} Created");
            return base.GetResult();
        }
    }
    public class Director
    {
        private Builder builder;
        public void SetBuilder(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPart1();
            builder.BuildPart2();
        }
    }

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Director director = new Director();
    //        var builder = new ConcreateBuilder();
    //        director.SetBuilder(builder);
    //        director.Construct();

    //        var product = builder.GetResult();
    //        product.DisplayInfo();

    //        Console.ReadKey();
    //    }
    //}
}
