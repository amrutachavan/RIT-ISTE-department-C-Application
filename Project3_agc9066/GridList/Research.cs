using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 This class is used to store the Research details
    */
namespace GridList
{
    //Store research by interest area
    public class ByInterestArea
    {
        public string areaName { get; set; }
        public List<string> citations { get; set; }
    }
    //store research by faculty
    public class ByFaculty
    {
        public string facultyName { get; set; }
        public string username { get; set; }
        public List<string> citations { get; set; }
    }

    public class Research
    {
        public List<ByInterestArea> byInterestArea { get; set; }
        public List<ByFaculty> byFaculty { get; set; }
    }
}
