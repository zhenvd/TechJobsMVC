using System;
namespace TechJobsMVC.Models
{
    public class Job
    {

        private int id;
        static private int nextId = 1;

        private string Name { get; set; }
        private Employer Employer { get; set; }
        private Location Location { get; set; }
        private PositionType PositionType { get; set; }
        private CoreCompetency CoreCompetency { get; set; }

        public Job()
        {
            id = nextId;
            nextId++;
        }
    }
}
