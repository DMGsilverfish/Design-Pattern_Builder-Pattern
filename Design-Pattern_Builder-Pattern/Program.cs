using System;
using System.Text;

// Product
public class Burger
{
    private string _bun;
    private string _patty;
    private string _sauce;
    private string _extras;

    public void SetBun(string bun) => _bun = bun;
    public void SetPatty(string patty) => _patty = patty;
    public void SetSauce(string sauce) => _sauce = sauce;
    public void SetExtras(string extras) => _extras = extras;

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.AppendLine("🍔 Burger Details:");
        builder.AppendLine($"- Bun: {_bun}");
        builder.AppendLine($"- Patty: {_patty}");
        builder.AppendLine($"- Sauce: {_sauce}");
        builder.AppendLine($"- Extras: {_extras}");
        return builder.ToString();
    }
}

// Builder Interface
public interface IBurgerBuilder
{
    void AddBun();
    void AddPatty();
    void AddSauce();
    void AddExtras();
    Burger GetBurger();
}

// Concrete Builder: Classic Burger
public class ClassicBurgerBuilder : IBurgerBuilder
{
    private Burger _burger = new Burger();

    public void AddBun() => _burger.SetBun("Sesame Bun");
    public void AddPatty() => _burger.SetPatty("Beef Patty");
    public void AddSauce() => _burger.SetSauce("BBQ Sauce");
    public void AddExtras() => _burger.SetExtras("Cheese, Lettuce, Tomato");

    public Burger GetBurger() => _burger;
}

// Concrete Builder: Vegan Burger
public class VeganBurgerBuilder : IBurgerBuilder
{
    private Burger _burger = new Burger();

    public void AddBun() => _burger.SetBun("Whole Wheat Bun");
    public void AddPatty() => _burger.SetPatty("Soy Patty");
    public void AddSauce() => _burger.SetSauce("Vegan Mayo");
    public void AddExtras() => _burger.SetExtras("Avocado, Pickles, Lettuce");

    public Burger GetBurger() => _burger;
}

// Director
public class Chef
{
    public void MakeBurger(IBurgerBuilder builder)
    {
        builder.AddBun();
        builder.AddPatty();
        builder.AddSauce();
        builder.AddExtras();
    }
}

// Client
public class Program
{
    static void Main(string[] args)
    {
        var chef = new Chef();

        // Build a classic burger
        var classicBuilder = new ClassicBurgerBuilder();
        chef.MakeBurger(classicBuilder);
        var classicBurger = classicBuilder.GetBurger();
        Console.WriteLine(classicBurger);

        // Build a vegan burger
        var veganBuilder = new VeganBurgerBuilder();
        chef.MakeBurger(veganBuilder);
        var veganBurger = veganBuilder.GetBurger();
        Console.WriteLine(veganBurger);

        Console.ReadKey();
    }
}
