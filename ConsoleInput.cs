namespace TuneMyGuitar
{
    internal abstract class ConsoleInput
    {
        protected int inDevice = 0;
        protected bool isValidDevice = false;
        public void SelectedInput()
        {
            Console.Clear();
            while (isValidDevice == !true)
            {
                Console.WriteLine("Select your device/input");
                if (isValidDevice == true)
                {
                    Console.WriteLine("Device selected: " + WaveInEvent.GetCapabilities(inDevice).ProductName + ".\n");
                }

                else
                {
                    return;
                }
            }
        }
        public abstract void ToSelectedInput();

        private class MusicToInput
        {
            public void MusicToInput(int inDevice)
            {
                WaveInEvent waveIn = new WaveInEvent
                {
                    DeviceNumber = inDevice,
                    WaveFormat = new WaveFormat(44100, 1)
                };
                waveIn.DataAvailable += WaveIn_DataAvailable;
                bufferedWaveProvider = new BufferedWaveProvider(waveIn.WaveFormat);





            }





        }
    }
