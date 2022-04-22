using System;
using XYZCompanyAssetsManagement.Models;

namespace XYZCompanyAssetsManagement.Repositories
{
    public class AssetsMappingRepository
    {
        Repository repo;
        public AssetsMappingRepository(Repository repository)
        {
            repo = repository;
        }
        public object Get(int empId)
        {
            var temp = repo.AssetsMapping.Find(empId);
            return (from empDetails in repo.EmpDetails
                    join assetsMapping in repo.AssetsMapping on empDetails.Id equals assetsMapping.EmpId
                    join assetsDetails in repo.AssetsDetails on assetsMapping.AssetsId equals assetsDetails.Id
                    where empId == empDetails.Id
                    select new
                    {
                      empName = empDetails.EmpName,
                      emailId = empDetails.EmailId,
                      phoneNo = empDetails.PhoneNo,
                      Address = empDetails.Address,
                      type = assetsDetails.Type,
                      name = assetsDetails.Name,
                      dateOfIssue = assetsMapping.DateOfIssue,
                      dateOfReturn = assetsMapping.DateOfIssue
                              });
        }

        public bool AddAssetsMapping(AssetsMapping AM)
        {

            bool status = false;
            AssetsMapping add = new AssetsMapping();
            add.DateOfIssue = AM.DateOfIssue;
            add.DateOfReturn = AM.DateOfReturn;
            add.EmpId = AM.EmpId;
            add.AssetsId = AM.AssetsId;
            repo.AssetsMapping.Add(add);
            repo.SaveChanges();
            status = true;
            return status;
        }

        public bool UpdateAssetsMapping(AssetsMapping update)
        {
            bool status = false;
            var assetsMapping = repo.AssetsMapping.Find(update.Id);
            if (assetsMapping != null)
            {
                assetsMapping.DateOfIssue = update.DateOfIssue;
                assetsMapping.DateOfReturn = update.DateOfReturn;
                assetsMapping.Id = update.EmpId;
                assetsMapping.AssetsId = update.AssetsId;
                repo.SaveChanges();
                status = true;
            }
            else
            {
                status = false;
            }
            return status;
        }
       
    }
}

