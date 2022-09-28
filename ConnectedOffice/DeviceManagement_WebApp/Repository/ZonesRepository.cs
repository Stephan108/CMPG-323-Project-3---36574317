
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repository
{
    public class ZonesRepository : GenericRepository<Zone>, IZonesRepository
    {

        public ZonesRepository(ConnectedOfficeContext context) : base(context)
        {
        }
        public void Delete(Guid? ZoneId)
        {
            Zone zone_ = _context.Zone.Find(ZoneId);
            _context.Zone.Remove(zone_);
        }
        public Zone GetById(Guid? ZoneId)
        {
            return _context.Zone.Find(ZoneId);
        }
        public IEnumerable<Zone> GetAll()
        {
            return _context.Zone.ToList();
        }
        public void Insert(Zone zone_)
        {
            _context.Zone.Add(zone_);
        }
        public void Update(Zone zone_)
        {
            _context.Zone.Attach(zone_);
            _context.Entry(zone_).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

    }


}
