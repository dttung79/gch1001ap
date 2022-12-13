using System;
using System.Collections.Generic;

namespace DemoTemplateMethod
{
    public abstract class HRDepartment
    {
        public List<Employee> Recruit(List<Candidate> candidates)
        {
            List<Employee> employees = new List<Employee>();
            List<Candidate> passCV = CVRound(candidates);
            List<Candidate> passTest = TestRound(passCV);
            List<Candidate> passInterview = InterviewRound(passTest);

            foreach (Candidate c in passInterview)
            {
                Employee employee = Offer(c);
                employees.Add(employee);
            }
            return employees;         
        }

        protected abstract List<Candidate> CVRound(List<Candidate> candidates);
        protected abstract List<Candidate> TestRound(List<Candidate> candidates);
        protected abstract List<Candidate> InterviewRound(List<Candidate> candidates);
        protected abstract Employee Offer(Candidate candidate);
    }
}