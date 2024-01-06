namespace Appliances.Cooling
{
    //Fan class
    public class Fan
    {
        private FanSpeed speed;
        private double size;
        private FanColor color;

        //Default constructor for a fan with size 7
        public Fan() : this(7)
        {
            // invokes Fan(double)
        }

        //Constructor for a fan with specified size
        public Fan(double size)
        {
            this.speed = FanSpeed.Off;
            this.size = size;
            this.color = FanColor.White;
        }

        //Constructor for a fan with specified size and color
        public Fan(double size, FanColor color)
        {
            this.speed = FanSpeed.Off;
            this.size = size;
            this.color = color;
        }

        //FanSpeed getter
        public FanSpeed GetSpeed()
        {
            return this.speed;
        }

        //Fan Size getter
        public double GetSize()
        {
            return this.size;
        }

        //FanColor getter
        public FanColor GetColor()
        {
            return this.color;
        }

        //FanSpeed setter
        public void SetSpeed(FanSpeed speed)
        {
            this.speed = speed;
        }

        //FanColor setter
        public void SetColor(FanColor color)
        {
            this.color = color;
        }

        //Method to increase the fan speed
        public void IncreaseSpeed()
        {
            if(this.speed != FanSpeed.Fast)
            {
                this.speed++;
            }
            
        }

        //Method to decrease the fan speed
        public void DecreaseSpeed()
        {
            if(this.speed != FanSpeed.Off)
            {
                this.speed--;
            }
        }

        //Method to determine if the fan is on/off
        public bool IsFanOn()
        {
            if (this.speed != FanSpeed.Off)
            {
                return true;
            }

            return false;
        }

        //ToString method 
        public override string ToString()
        {
            return $"Fan: {size} - {color} - {speed}";
        }
    }
}