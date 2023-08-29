using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class JobManager : IJobService
    {
        IJobDAL _jobDAL;

        public JobManager(IJobDAL jobDAL)
        {
            _jobDAL = jobDAL;
        }

        public void TDelete(Job t)
        {
            _jobDAL.Delete(t);
            
        }

        public Job TGetById(int id)
        {
            return _jobDAL.GetById(id);
        }

        public List<Job> TGetList()
        {
            return _jobDAL.GetList();
        }

        public void TInsert(Job t)
        {
            _jobDAL.Insert(t);
        }

        public void TUpdate(Job t)
        {
            _jobDAL.Update(t);
        }
    }
}
