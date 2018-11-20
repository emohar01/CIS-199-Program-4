using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    public class GroundPackage
    {
        // Constants to hold the minimum zip code and maximum zip code.
        const int MIN_ZIP = 0;
        const int MAX_ZIP = 99999;

        const double VOL_COST = .2; // Constant to hold the cost applied to the volume
        const double DIST_COST = .5; // Constant to hold the cost applied to zone distance and weight.

        private int _originZip; // Field to hold origin zip
        private int _destinationZip; // Field to hold destination zip
        private double _length; // Field to hold length
        private double _width; // Field to hold width
        private double _height; // Field to hold height
        private double _weight; // Field to hold weight.

        // Constructor
        // Precondition: 1 <= Origin Zip <= 99999, 1 <= Destination Zip <= 99999,
        //               Length > 0, Width > 0, Height > 0, Weight > 0
        // Postcondition: The Ground Package has been initialized with the specified values for
        //                Origin Zip, Destination Zip, Length, Width, Height, and Weight.
        public GroundPackage(int orZip, int destZip, double l, double w, double h, double we)
        {
            OriginZip = orZip;
            DestinationZip = destZip;
            Length = l;
            Width = w;
            Height = h;
            Weight = we;
        }

        public int OriginZip
        {
            // Precondition: None
            // Postcondition: The Origin Zip is returned.
            get
            {
                return _originZip;
            }

            // Precondition: 1<=value<=99999
            // Postcondition: The Origin Zip has been set to a specified value
            set
            {
                if ((value >= MIN_ZIP) && (value <= MAX_ZIP))
                    _originZip = value;
            }
        }

        public int DestinationZip
        {
            // Precondition: None
            // Postcondition: The Destination Zip is returned.
            get
            {
                return _destinationZip;
            }

            // Precondition: 1<=value<=99999
            // Postcondition: The Destination Zip has been set to a specified value
            set
            {
                if ((value >= MIN_ZIP) && (value <= MAX_ZIP))
                    _destinationZip = value;
            }
        }

        public double Length
        {
            // Precondition: None
            // Postcondition: The Length is returned.
            get
            {
                return _length;
            }

            // Precondition: Length > 0
            // Postcondition: The Length is set to the specified value
            set
            {
                if (value > 0)
                    _length = value;
            }
        }

        public double Width
        {
            // Precondition: None
            // Postcondition: The Width is returned.
            get
            {
                return _width;
            }

            // Precondition: Width > 0
            // Postcondition: The Width is set to the specified value
            set
            {
                if (value > 0)
                    _width = value;
            }
        }

        public double Height
        {
            // Precondition: None
            // Postcondition: The Height is returned.
            get
            {
                return _height;
            }

            // Precondition: Height > 0
            // Postcondition: The Height is set to the specified value
            set
            {
                if (value > 0)
                    _height = value;
            }
        }

        public double Weight
        {
            // Precondition: None
            // Postcondition: The Weight is returned.
            get
            {
                return _weight;
            }

            // Precondition: Weight > 0
            // Postcondition: The Weight is set to the specified value
            set
            {
                if (value > 0)
                    _weight = value;
            }
        }

        public int ZoneDistance
        {
            // Precondition: None
            // Postcondition: The Zone Distance is calculated and returned
            get
            {
                return Math.Abs((_originZip/10000) - (_destinationZip/10000));
            }
        }

        // Precondition: None
        // Postcondition: The cost of the package is calculated and returned.
        public double CalcCost()
        {
            return (VOL_COST * (Length + Width + Height)) + (DIST_COST * ((ZoneDistance + 1)) * (Weight));
        }

        // Precondition: None
        // Postcondition: Returns all of the data about the package, each on a seperated line
        public override string ToString()
        {
            return "Origin Zip: " + OriginZip.ToString("D5") + System.Environment.NewLine + "Destination Zip: " + DestinationZip.ToString("D5") + System.Environment.NewLine + "Length: " + Length.ToString() + System.Environment.NewLine + "Width: " + Width.ToString() + System.Environment.NewLine + "Height: " + Height.ToString() + System.Environment.NewLine + "Weight: " + Weight.ToString();
        }
    }
}
