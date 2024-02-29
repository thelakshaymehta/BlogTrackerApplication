using System.Collections.Generic;

namespace DataAccessLayer
{
    public interface IEmpInfo
    {
        IEnumerable<EmpInfo> GetAllEmpInfo();
        void Save();
        void Insert(EmpInfo empInfo);
        void Delete(string id);
        void Update(EmpInfo emp);
        EmpInfo GetEmpInfo(string EmailId);
        bool ValidateEmployeeLogin(string user, int pass);
    }

}
