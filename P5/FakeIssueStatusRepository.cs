using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private List<IssueStatus> IssueStatuses = new List<IssueStatus>();

        public void Add(int Id, string value)
        {

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
