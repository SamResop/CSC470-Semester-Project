using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeRequirementRepository : IRequirementRepository
    {
        public string NO_ERROR = "";
        public string DUPLICATE_STATEMENT_ERROR = "Statements must be unique";
        public string EMPTY_STATEMENT_ERROR = "Statments must have a value";
        public string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist";
        public string MISSING_FEATUREID_ERROR = "Must select a feature for this requirement";
        public string MISSING_PROJECTID_ERROR = "Must select a project for this requirement";


        private static List<Requirement> requirements = new List<Requirement>();


        public FakeRequirementRepository()
        {
            if (requirements.Count == 0)
            {
                string add = "";
                add = Add(new Requirement { });
            }
        }

        public string Add(Requirement requirement)
        {
            return null;
        }
        public List<Requirement> GetAll(int ProjectId)
        {
            return null;
        }
        public string Remove(Requirement requirement)
        {
            return null;
        }
        public string Modify(Requirement requirement)
        {
            return null;
        }
        public Requirement GetRequirementById(int requirementId)
        {
            return null;
        }
        public int CountByFeatureId(int featureId)
        {
            return 0;
        }
        public void RemoveByFeatureId(int featureId)
        {

        }
    }
}
