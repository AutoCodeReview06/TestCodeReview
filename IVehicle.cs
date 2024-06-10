public interface IVehicle
{
    // Properties
    string Make { get; set; }
    string Model { get; set; }
    int Year { get; set; }
    double CurrentSpeed { get; }

    // Methods
    void Start();
    void Stop();
    void Accelerate(double speed);
    void Decelerate(double speed);
}
