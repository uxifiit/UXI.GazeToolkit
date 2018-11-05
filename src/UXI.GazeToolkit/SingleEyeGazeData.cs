using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UXI.GazeToolkit;

namespace UXI.GazeToolkit
{
    public class SingleEyeGazeData : EyeData, ITimestampedData
    {
        public SingleEyeGazeData
        (
            EyeValidity validity,
            Point2 gazePoint2D,
            Point3 gazePoint3D,
            Point3 eyePosition3D,
            double pupilDiameter,
            long trackerTicks
        )
            : base(validity, gazePoint2D, gazePoint3D, eyePosition3D, pupilDiameter)
        {
            TrackerTicks = trackerTicks;
        }


        public SingleEyeGazeData(EyeData other, long trackerTicks)
            : base(other)
        {
            TrackerTicks = trackerTicks;
        }


        public long TrackerTicks { get; }
    }
}
