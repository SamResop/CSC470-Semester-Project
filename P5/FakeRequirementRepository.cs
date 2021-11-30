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
                add = Add(new Requirement { ProjectId = 1, FeatureId = 1, Id = 1, Statement = "Sup"});
                add = Add(new Requirement { ProjectId = 1, FeatureId = 1, Id = 2, Statement = "Hi" });
                add = Add(new Requirement { ProjectId = 1, FeatureId = 2, Id = 3, Statement = "I like pizza" });
                add = Add(new Requirement { ProjectId = 2, FeatureId = 1, Id = 4, Statement = "Sup" });
                add = Add(new Requirement { ProjectId = 3, FeatureId = 1, Id = 5, Statement = "Sup" });
            }
        }

        public string Add(Requirement requirement)
        {
            if (requirement.Statement == "")
                return EMPTY_STATEMENT_ERROR;

            bool duplicate = false;
            foreach (Requirement r in requirements)
            {
                if (r.Statement == requirement.Statement && r.ProjectId == requirement.ProjectId)
                    duplicate = true;
            }
            if (duplicate)
                return DUPLICATE_STATEMENT_ERROR;

            FakeFeatureRepository featureRepository = new FakeFeatureRepository();
            List<Feature> features = featureRepository.GetAll(requirement.ProjectId);

            bool featureExists = false;
            foreach (Feature f in features)
                if (f.Id == requirement.FeatureId)
                    featureExists = true;
            if (!featureExists)
                return MISSING_FEATUREID_ERROR;

            FakeProjectRepository projectRepository = new FakeProjectRepository();
            List<Project> projects = projectRepository.GetAll();

            bool projectExists = false;
            foreach (Project p in projects)
                if (p.Id == requirement.ProjectId)
                    projectExists = true;
            if (!projectExists)
                return MISSING_PROJECTID_ERROR;

            int id = GetNextId(requirement.ProjectId);
            requirement.Id = id;

            requirements.Add(requirement);
            return NO_ERROR;
        }
        public List<Requirement> GetAll(int ProjectId)
        {
            List<Requirement> reqs = new List<Requirement>();
            foreach (Requirement r in requirements)
                if (ProjectId == r.ProjectId)
                    reqs.Add(r);
            return reqs;
        }
        public string Remove(Requirement requirement)
        {
            return null;
        }
        public string Modify(Requirement requirement)
        {
            if (requirement.Statement == "")
                return EMPTY_STATEMENT_ERROR;

            bool duplicate = false;
            foreach (Requirement r in requirements)
            {
                if (r.Statement == requirement.Statement && r.ProjectId == requirement.ProjectId && r.FeatureId == requirement.FeatureId)
                    duplicate = true;
            }
            if (duplicate)
                return DUPLICATE_STATEMENT_ERROR;

            FakeFeatureRepository featureRepository = new FakeFeatureRepository();
            List<Feature> features = featureRepository.GetAll(requirement.ProjectId);

            bool featureExists = false;
            foreach (Feature f in features)
                if (f.Id == requirement.FeatureId)
                    featureExists = true;
            if (!featureExists)
                return MISSING_FEATUREID_ERROR;

            FakeProjectRepository projectRepository = new FakeProjectRepository();
            List<Project> projects = projectRepository.GetAll();

            bool projectExists = false;
            foreach (Project p in projects)
                if (p.Id == requirement.ProjectId)
                    projectExists = true;
            if (!projectExists)
                return MISSING_PROJECTID_ERROR;

            foreach (Requirement r in requirements)
                if (requirement.Id == r.Id && requirement.ProjectId == r.ProjectId)
                {
                    r.Statement = requirement.Statement;
                    r.FeatureId = requirement.FeatureId;
                }
            return NO_ERROR;
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

        private int GetNextId(int projectId)
        {
            int currentMaxId = 0;
            foreach (Requirement r in requirements)
            {
                if (projectId == r.ProjectId)
                    currentMaxId = r.Id;
            }
            return ++currentMaxId;
        }
    }
}
