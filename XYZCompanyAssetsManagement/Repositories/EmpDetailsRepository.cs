using System;
using XYZCompanyAssetsManagement.Models;

namespace XYZCompanyAssetsManagement.Repositories
{
	public class EmpDetailsRepositoy
	{
		Repository repo;

		public EmpDetailsRepositoy(Repository repository)
		{
			repo = repository;
			
		}

		public List<EmpDetails>GetAll()
        {
			var listofEmp = repo.EmpDetails.ToList();
			return listofEmp;
        }

		public bool AddEmpDetails(EmpDetails emp)
        {
			bool status = false;
			EmpDetails add = new EmpDetails();
			add.EmpName = emp.EmpName;
			add.EmailId = emp.EmailId;
			add.PhoneNo = emp.PhoneNo;
			add.Address = emp.Address;
			repo.EmpDetails.Add(add);
			repo.SaveChanges();
			status = true;
			return status;
        }

		public bool UpdateEmpDetails(EmpDetails update)
        {
			bool status = false;
			var empDetails = repo.EmpDetails.Find(update.Id);
			if (empDetails != null)
            {
				empDetails.EmpName = update.EmpName;
				empDetails.EmailId = update.EmailId;
				empDetails.PhoneNo = update.PhoneNo;
				empDetails.Address = update.Address;
				repo.SaveChanges();
				status = true;
            }
			else
            {
				status = false;
            }
			return status;
        }


		public EmpDetails Get(EmpDetails get)
		{
			EmpDetails? emp = new EmpDetails();
			try
			{
                emp = (from p in repo.EmpDetails
						 where p.Id.Equals(get.Id)
						 select p).FirstOrDefault();
			}
			catch (Exception e)
			{
				throw;
			}
			return emp;
		}
	}
}

