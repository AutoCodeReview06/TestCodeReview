public class Car : IVehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public double CurrentSpeed { get; private set; }

    public Car(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
        CurrentSpeed = 0;
    }

    public void Start()
    {
        Console.WriteLine("Car engine started.");
    }

    public void Stop()
    {
        CurrentSpeed = 0;
        Console.WriteLine("Car has stopped.");
    }

    public void Accelerate(double speed)
    {
        CurrentSpeed += speed;
        Console.WriteLine($"Car speed increased to {CurrentSpeed} km/h.");
    }

    public void Decelerate(double speed)
    {
        CurrentSpeed = Math.Max(0, CurrentSpeed - speed);
        Console.WriteLine($"Car speed decreased to {CurrentSpeed} km/h.");
    }
}
