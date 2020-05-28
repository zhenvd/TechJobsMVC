using System;
using System.Collections.Generic;

namespace TechJobsMVC.Data
{
    public class JobData
    {
        static private string DATA_FILE = "job_data.csv";

        static private bool isDataLoaded = false;

        static private List<Job> allJobs;
        static private List<Employer> allEmployers = new List<>();
        static private List<Location> allLocations = new List<>();
        static private List<PositionType> allPositionTypes = new List<>();
        static private List<CoreCompetency> allCoreCompetency = new List<>();
    }
}
