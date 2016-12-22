using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 This class is used to store parsed degree object
    */
namespace GridList
{
    //Undergraduate class is used to store undergrad degree details
    public class Undergraduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }
    }

    //Graduate class is used to store grad degree details
    public class Graduate
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }
        public List<string> availableCertificates { get; set; }
    }

    //Class Degree is used to store degree details.
    public class Degree
    {
        public List<Undergraduate> undergraduate { get; set; }
        public List<Graduate> graduate { get; set; }
    }
}
