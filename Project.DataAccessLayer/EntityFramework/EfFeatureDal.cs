using Project.DataAccessLayer.Abstracts;
using Project.DataAccessLayer.Concretes;
using Project.DataAccessLayer.Repositories;
using Project.EntityLayer.Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.EntityFramework
{
    public class EfFeatureDal : GenericRepository<Feature>, IFeatureDal
    {
        public EfFeatureDal(SignalRContext context) : base(context)
        {
        }
    }
}
