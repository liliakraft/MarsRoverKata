namespace MarsRoverKata
{
    public class Location
    {
        private int xCoordinate;
        private int yCoordinate;
        private Direction direction;

        public Location(int xCoordinate, int yCoordinate, Direction direction)
        {
            this.xCoordinate = xCoordinate;
            this.yCoordinate = yCoordinate;
            this.direction = direction;
        }

        public void IncreaseYCoordinate(int maxDimension)
        {
            if (yCoordinate == maxDimension)
            {
                yCoordinate = 0;
            }
            else
            {
                yCoordinate += 1;
            }
        }

        public Direction Direction
        {
            get { return direction; }
        }

        public void DecreaseYCoordinate(int maxDimension)
        {
            if (yCoordinate == 0)
            {
                yCoordinate = maxDimension;
            }
            else
            {
                yCoordinate -= 1;
            }
        }

        public void IncreaseXCoordinate(int maxDimension)
        {
            if (xCoordinate == maxDimension)
            {
                xCoordinate = 0;
            }
            else
            {
                xCoordinate += 1;
            }
        }

        public void DecreaseXCoordinate(int maxDimension)
        {
            if (xCoordinate == 0)
            {
                xCoordinate = maxDimension;
            }
            else
            {
                xCoordinate -= 1;
            }
        }

        public void UpdateDirection(Direction newDirection)
        {
            direction = newDirection;
        }

        protected bool Equals(Location other)
        {
            return xCoordinate == other.xCoordinate && yCoordinate == other.yCoordinate && string.Equals(direction, other.direction);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = xCoordinate;
                hashCode = (hashCode * 397) ^ yCoordinate;
                hashCode = (hashCode * 397) ^ (direction != null ? direction.GetHashCode() : 0);
                return hashCode;
            }
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Location)obj);
        }
    }
}