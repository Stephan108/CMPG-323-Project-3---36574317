using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDevicesRepository : IGenericRepository<Device>
    {
        IEnumerable<Device> GetAll();
        Device GetById(Guid? DeviceId);
        void Insert(Device device_);
        void Update(Device device_);
        void Delete(Guid? DeviceId);

    }
}