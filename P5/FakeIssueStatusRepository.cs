using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> IssueStatuses = new List<IssueStatus>();

        public FakeIssueStatusRepository()
        {
            if (IssueStatuses.Count == 0)
            {
                Add(1, "Open");
                Add(2, "Assigned");
                Add(3, "Fixed");
                Add(4, "Closed - Won't Fix");
                Add(5, "Closed - Fixed");
                Add(6, "Closed - By Design");
            }
        }

        public void Add(int Id, string value)
        {
            IssueStatus issueStatus = new IssueStatus();
            issueStatus.Id = Id;
            issueStatus.Value = value;
            IssueStatuses.Add(issueStatus);
        }
        public List<IssueStatus> GetAll()
        {
            return IssueStatuses;
        }
        public int GetIdByStatus(string value)
        {
            foreach (IssueStatus s in IssueStatuses)
                if (s.Value == value)
                    return s.Id;
            return -1;
        }
        public string GetValueById(int Id)
        {
            foreach (IssueStatus s in IssueStatuses)
                if (s.Id == Id)
                    return s.Value;
            return null;
        }
    }
}
