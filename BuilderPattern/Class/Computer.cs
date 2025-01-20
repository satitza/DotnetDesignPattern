namespace BuilderPattern.Class
{
    public class Computer
    {
        public string? Cpu { get; private set; }

        public int? Ram { get; private set; }

        public int? PowerSupply { get; private set; }

        public int? HardDisk { get; private set; }

        public int? SSD { get; private set; }

        private Computer()
        {
            // ทำให้ constructor เป็น private เพื่อบังคับใช้ Builder
        }

        public class Builder
        {
            private readonly Computer _computer = new Computer();

            public Builder SetCpu(string cpu)
            {
                this._computer.Cpu = cpu;
                return this;
            }

            public Builder SetRam(int ram)
            {
                this._computer.Ram = ram;
                return this;
            }

            public Builder SetPowerSupply(int watt)
            {
                this._computer.PowerSupply = watt;
                return this;
            }

            public Builder SetHardDisk(int gb)
            {
                this._computer.HardDisk = gb;
                return this;
            }

            public Builder SetSSD(int gb)
            {
                this._computer.SSD = gb;
                return this;
            }

            public Computer Build()
            {
                return this._computer;
            }
        }
    }
}