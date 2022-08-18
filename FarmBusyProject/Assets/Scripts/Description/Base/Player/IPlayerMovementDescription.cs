namespace Description.Base.Player
{
    
    public interface IPlayerMovementDescription
    {
        public float MaxSpeed { get; }
        public float Acceleration { get; }
        public float RotationSpeed { get; }
    }
}