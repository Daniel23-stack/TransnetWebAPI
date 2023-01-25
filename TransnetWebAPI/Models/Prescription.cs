namespace TransnetWebAPI.Models;

public class Prescription
{
    public Guid id { get; set; }
    public int doctor_id { get; set; }
    public int medicine_id { get; set; }
    public int patiant_id { get; set; }
    public DateTime date { get; set; }
    public DateTime time { get; set; }
}