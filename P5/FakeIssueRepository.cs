using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future";
        public const string EMPTY_DISCOVERER_ERROR = "A Discoverer is required";
        private List<Issue> Issues = new List<Issue>();

        public const string DUPLICATE_TITLE_ERROR = "Project name already exists.";

        public FakeIssueRepository()
        {
            if (Issues.Count == 0)
            {
                Add(new Issue { Id = 1, ProjectId = 1, Title = "SQL Injection Vulnerability", DiscoveryDate = DateTime.Now, Discoverer = "Sam Resop", InitialDescription = "This is a sample issue, pretend I said something smart", Component = "FormLogin", IssueStatusId = 1 });
                Add(new Issue { Id = 2, ProjectId = 1, Title = "Minor Problem", DiscoveryDate = DateTime.Now, Discoverer = "Sam Resop", InitialDescription = "This is a sample issue but it is minor", Component = "FormMain", IssueStatusId = 2 });
                Add(new Issue { Id = 3, ProjectId = 1, Title = "Major Problem", DiscoveryDate = DateTime.Now, Discoverer = "Sam Resop", InitialDescription = "Hey, this is a big problem", Component = "FormModifyProject", IssueStatusId = 1 });
                Add(new Issue { Id = 1, ProjectId = 1, Title = "End of the World Problem", DiscoveryDate = DateTime.Now, Discoverer = "Sam Resop", InitialDescription = "Uh Oh", Component = "FakeIssueRepository", IssueStatusId = 1 });
            }
        }

        private string ValidateIssue(Issue issue)
        {

        }
        private bool IsDuplicate(string title)
        {
            bool isDuplicate = false;
            foreach (Issue i in Issues)
            {
                if (title == i.Title)
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }
        public string Add(Issue issue)
        {
            int Id = 0;
            string newName = issue.Title.Trim();
            if (IsDuplicate(issue.Title))
                return DUPLICATE_TITLE_ERROR;
            if (newName == "")
                return EMPTY_TITLE_ERROR;
            Issues.Add(issue);
            return NO_ERROR;
        }
        public List<Issue> GetAll()
        {
            return Issues;
        }
        public bool Remove(Issue issue)
        {
            int index = 0;
            foreach (Issue i in Issues)
            {
                if (i.Id == issue.Id)
                {
                    Issues.RemoveAt(index);
                    return true;
                }
                index++;
            }
            return false;
        }
        public string Modify(Issue issue)
        {

        }
        public int GetTotalNumberOfIssues(int ProjectId)
        {
            int count = 0;
            foreach (Issue i in Issues)
                if (i.ProjectId == ProjectId)
                    count++;
            return count;
        }
        public List<string> GetIssuesByMonth(int ProjectId)
        {
            List<string> MonthlyIssues = new List<string>();
            foreach (Issue i in Issues)
                if (i.ProjectId == ProjectId)
                    MonthlyIssues.Add(i.DiscoveryDate.ToString());
            return MonthlyIssues;

        }
        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            List<string> Discoverer = new List<string>();
            foreach (Issue i in Issues)
                if (i.ProjectId == ProjectId)
                    Discoverer.Add(i.Discoverer);
            return Discoverer;
        }
        public Issue GetIssueById(int Id)
        {
            foreach (Issue i in Issues)
                if (i.Id == Id)
                    return i;
            return null;
        }

    }
}
