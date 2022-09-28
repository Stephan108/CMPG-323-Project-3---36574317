using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZonesRepository : IGenericRepository<Zone>
    {
        
        IEnumerable<Zone> GetAll();
        Zone GetById(Guid? ZoneId);
        void Insert(Zone zone_);
        void Update(Zone zone_);
        void Delete(Guid? ZoneId);

    }
}