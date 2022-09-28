
using System;
using System.Collections.Generic;
using System.Linq;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public class DevicesRepository : GenericRepository<Device>, IDevicesRepository
    {

        public DevicesRepository(ConnectedOfficeContext context) : base(context)
        {
        }
        public void Delete(Guid? DeviceId)
        {
            Device device_ = _context.Device.Find(DeviceId);
            _context.Device.Remove(device_);
        }
        public Device GetById(Guid? DeviceId)
        {
            return _context.Device.Find(DeviceId);
        }
        public IEnumerable<Device> GetAll()
        {
            return _context.Device.ToList();
        }
        public void Insert(Device device_)
        {
            _context.Device.Add(device_);
        }
        public void Update(Device device_)
        {
            _context.Device.Attach(device_);
            _context.Entry(device_).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

    }
}

