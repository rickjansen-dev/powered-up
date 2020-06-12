using System;
using System.Collections.Generic;
using System.Linq;
using SharpBrick.PoweredUp.Protocol;
using SharpBrick.PoweredUp.Utils;

namespace SharpBrick.PoweredUp.Devices
{
    public class TechnicMediumHubGyroSensor : Device, IPowerdUpDevice
    {
        public TechnicMediumHubGyroSensor()
        { }

        public TechnicMediumHubGyroSensor(IPoweredUpProtocol protocol, byte hubId, byte portId)
            : base(protocol, hubId, portId)
        { }

        public IEnumerable<byte[]> GetStaticPortInfoMessages(Version sw, Version hw)
            => @"
0B-00-43-62-01-02-01-01-00-00-00
05-00-43-62-02
11-00-44-62-00-00-52-4F-54-00-00-00-00-00-00-00-00
0E-00-44-62-00-01-D7-36-DF-C6-D7-36-DF-46
0E-00-44-62-00-02-00-00-C8-C2-00-00-C8-42
0E-00-44-62-00-03-00-00-FA-C4-00-00-FA-44
0A-00-44-62-00-04-44-50-53-00
08-00-44-62-00-05-50-00
0A-00-44-62-00-80-03-01-03-00
".Trim().Split("\n").Select(s => BytesStringUtil.StringToData(s));
    }
}