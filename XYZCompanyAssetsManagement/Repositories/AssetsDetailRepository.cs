using System;
using XYZCompanyAssetsManagement.Models;

namespace XYZCompanyAssetsManagement.Repositories
{
    public class AssetsDetailRepository
    {
        Repository repo;
        public AssetsDetailRepository(Repository repository)
        {
            repo = repository;
        }
        public List<AssetsDetails> GetAll()
        {
            var listofAssets = repo.AssetsDetails.ToList();
            return listofAssets;
        }

        public bool AddAssetsDetails(AssetsDetails Add)
        {
            try
            {
                bool status = false;
                AssetsDetails add = new AssetsDetails();
                add.Type = Add.Type;
                add.Name = Add.Name;
                repo.AssetsDetails.Add(add);
                repo.SaveChanges();
                status = true;
                return status;
            }
            catch(Exception)
            {
                throw;
            }
        }

        public bool UpdateAssetsDetails(AssetsDetails update)
        {
            bool status = false;
            try
            {
                var assetsDetails = repo.AssetsDetails.Find(update.Id);
                if (assetsDetails != null)
                {
                    assetsDetails.Id = update.Id;
                    assetsDetails.Type = update.Type;
                    assetsDetails.Name = update.Name;
                    repo.SaveChanges();
                    status = true;
                }
                else
                {
                    status = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return status;
        }

        public AssetsDetails Get(int id)
        {
              var  assets = (from p in repo.AssetsDetails
                          where p.Id.Equals(id)
                          select p).FirstOrDefault();
            return assets;
        }
    }
}

