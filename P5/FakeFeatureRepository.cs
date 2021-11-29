using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeFeatureRepository : IFeatureRepository
    {
        public string NO_ERROR = "";
        public string DUPLICATE_TITLE_ERROR = "Title must be unique";
        public string EMPTY_TITLE_ERROR = "Title must have a value";
        public string NOT_FOUND_ERROR = "Feature not found";
        public string INVALID_PROJECT_ID_ERROR = "Invalid Project Id for Feature";

        private static List<Feature> features = new List<Feature>();

        public string Add(Feature feature)
        {
            return null;
        }

        public List<Feature> GetAll(int ProjectId)
        {
            return null;
        }

        public string Remove(Feature feature)
        {
            return null;
        }
        public string Modify(Feature feature)
        {
            return null;
        }
        public Feature GetFeatureById(int projectId, int featureId)
        {
            return null;
        }
        public Feature GetFeatureByTitle(int projectId, string title)
        {
            return null;
        }
    }
}
