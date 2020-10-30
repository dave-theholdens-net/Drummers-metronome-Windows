using NAudio.Wave;
using System;
using System.Collections.Generic;

public class OutputDeviceList : List<OutputDevice>
{
    public OutputDeviceList()
    {
        GetOutputDevices();
    }

    public void Refresh()
    {
        this.Clear();
        GetOutputDevices();
    }

    private void GetOutputDevices()
    {        
        for (int n = 0; n < WaveOut.DeviceCount; n++)
        {
            var caps = WaveOut.GetCapabilities(n);
            this.Add(new OutputDevice { DeviceName = caps.ProductName, DeviceNumber = n });
        }
    }

}

public class OutputDevice : IEquatable<OutputDevice>
{
    private string _deviceName = "";
    private int _deviceNumber = -1;

    public OutputDevice()
    {

    }

    public OutputDevice(int deviceNumber, string deviceName)
    {
        DeviceName = deviceName;
        DeviceNumber = deviceNumber;
    }

    public string DeviceName
    {
        get { return _deviceName; }
        set { _deviceName = value; }
    }
    public int DeviceNumber
    {
        get { return _deviceNumber; }
        set { _deviceNumber = value; }
    }

    public bool Equals(OutputDevice other)
    {
        if (other != null)
           return (this.DeviceName.Equals(other.DeviceName));
        else
            return true;
    }
}