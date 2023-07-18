namespace YUpDown.Common
{
    public class Configuration
    {
        public string RabbitHost { get; set; } = null!;

        public string[] QueueNames { get; set; } = null!;
    }
}
