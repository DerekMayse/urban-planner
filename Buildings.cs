using System;

namespace Planner
{
    public class Building
    {
        private string _designer { get; set; }

        private DateTime _dateContructed { get; set; }

        private string _address { get; set; }

        private string _owner { get; set; }

        public int Stories { get; set; }

        public double Width { get; set; }

        public double Depth { get; set; }

        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }


        public void Designer(string _designerParam)
        {
            _designer = _designerParam;
        }
        public Building(string _addressParam)
        {
            _address = _addressParam;
        }

        public void Purchase(string _ownerParam)
        {
            _owner = _ownerParam;
        }

        public void Construct(DateTime _dateContructedParam)
        {
            _dateContructed = DateTime.Now;
        }

        //need a method here that will return the information in a specific format

        public void makeBuilingReport(string Address, string Designer, DateTime date, string Owner, double VolumeParam)
        {
            Address = _address;
            Designer = _designer;
            date = DateTime.Now;
            Owner = _owner;
            VolumeParam = Volume;

             Console.WriteLine($"{Address}Designed by:{Designer} Constructed on {date} Owned by {Owner}{VolumeParam} Cubic Meters of Space");
        }
    }
}
