using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemTwo_CompilationError
{
    class DirectReport:Employee
    {
        public Employee ReportsTo { get; set; }
        public string ProjectCode { get; set; }
       

        public DirectReport(int eId ,string eName,int eLevel, DateTime eDoJ,Employee managerEmpObj,string pCode)
        {
            this.EmpID = eId;
            this.EmpName = eName;
            this.EmpLevel = eLevel;
            this.DateOfJoining = eDoJ;
            ReportsTo = managerEmpObj;
            ProjectCode = pCode;
        }

       
    }
}
