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

        public FakeFeatureRepository()
        {
            if (features.Count == 0)
            {
                string add;

                add = Add(new Feature { ProjectId = 1, Id = 1, Title = "Hello" });
                add = Add(new Feature { ProjectId = 1, Id = 2, Title = "I Like Frogs" });
                add = Add(new Feature { ProjectId = 1, Id = 3, Title = "Have A Good Day!" });
                add = Add(new Feature { ProjectId = 2, Id = 1, Title = ":)" });
                add = Add(new Feature { ProjectId = 3, Id = 1, Title = "Hello" });
            }
        }

        public string Add(Feature feature)
        {
            if (feature.Title == "")
                return EMPTY_TITLE_ERROR;
            bool duplicate = false;
            foreach (Feature f in features)
            {
                if (f.Title == feature.Title && f.ProjectId == feature.ProjectId)
                    duplicate = true;
            }
            if (duplicate)
                return DUPLICATE_TITLE_ERROR;

            features.Add(feature);
            return NO_ERROR;
        }

        public List<Feature> GetAll(int ProjectId)
        {
            List<Feature> returnVal = new List<Feature>();
            foreach (Feature f in features)
            {
                if (f.ProjectId == ProjectId)
                    returnVal.Add(f);
            }
            return returnVal;
        }

        public string Remove(Feature feature)
        {
            return null;
        }
        public string Modify(Feature feature)
        {
            string title = FormModifyFeature.newTitle;
            if (title == "")
                return EMPTY_TITLE_ERROR;
            bool duplicate = false;
            foreach (Feature f in features)
            {
                if (f.Title == title && f.ProjectId == feature.ProjectId)
                    duplicate = true;
            }
            if (duplicate)
                return DUPLICATE_TITLE_ERROR;

            foreach (Feature f in features)
            {
                if (f.Id == feature.Id && f.ProjectId == feature.ProjectId)
                {
                    f.Title = title;
                    return NO_ERROR;
                }
            }
            return NOT_FOUND_ERROR;
        }
        public Feature GetFeatureById(int projectId, int featureId)
        {
            foreach (Feature f in features)
            {
                if (f.ProjectId == projectId && f.Id == featureId)
                    return f;
            }
            return null;
        }
        public Feature GetFeatureByTitle(int projectId, string title)
        {
            return null;
        }

        public int GetNextId(int projectId)
        {
            int currentMaxId = 0;
            foreach (Feature f in features)
            {
                if (projectId == f.ProjectId)
                    currentMaxId = f.Id;
            }
            return ++currentMaxId;
        }

    }
}
