public class Bike : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double CurrentSpeed { get; private set; }

    public Bike(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        CurrentSpeed = 0;
    }

    public void Start()
    {
        Console.WriteLine("Bike ride started.");
    }

    public void Stop()
    {
        CurrentSpeed = 0;
        Console.WriteLine("Bike has stopped.");
    }

    public void Accelerate(double speed)
    {
        CurrentSpeed += speed;
        Console.WriteLine($"Bike speed increased to {CurrentSpeed} km/h.");
    }

    public void Decelerate(double speed)
    {
    CurrentSpeed = Math.Max(0, CurrentSpeed - speed);
        Console.WriteLine($"Bike speed decreased to {CurrentSpeed} km/h.");
    }
}
