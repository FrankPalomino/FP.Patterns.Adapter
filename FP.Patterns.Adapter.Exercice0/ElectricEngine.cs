namespace FP.Patterns.Adapter
{
    internal class ElectricEngine
    {
        bool _isTurnedOn;
        bool _isActivated;
        bool _isRunning;

        public void TurnOn()
        {
            if (_isTurnedOn)
            {
                Console.WriteLine("Already Turned On");
            }
            else
            {
                _isTurnedOn = true;
                Console.WriteLine("ElectricEngine.TurnOn");
            }
        }

        public void Activate()
        {
            if (_isActivated)
            {
                Console.WriteLine("Already activated");
            }
            else
            {
                _isActivated = true;
                Console.WriteLine("ElectricEngine.Activate");
            }
        }

        public void Move()
        {
            if (_isTurnedOn && _isActivated)
            {
                _isRunning = true;
                Console.WriteLine("ElectricEngine.Move");
            }
            else
            {
                Console.WriteLine("Not pluged in or activated");
            }
        }

        public void Stop()
        {
            if (_isRunning)
            {
                _isRunning = false;
                Console.WriteLine("ElectricEngine.Stop");
            }
            else
            {
                Console.WriteLine("Not running");
            }
        }

        public void TurnOff()
        {
            if (_isTurnedOn)
            {
                _isTurnedOn = false;
                Console.WriteLine("ElectricEngine.TurnOff");
            }
            else
            {
                Console.WriteLine("Already turned off");
            }
        }

        public void Deactivate()
        {
            _isActivated = false;
            Console.WriteLine("ElectricEngine.Deactivate");
        }

        public void PlugIn()
        {
            if (_isTurnedOn)
            {
                Console.WriteLine("Cannot plug in while turned on");
            }
            else
            {
                Console.WriteLine("ElectricEngine.PlugIn");
            }
        }
    }
}
