using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MPR.Baum.Data
{
    public class Building
    {
        public int BuildingId
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.IList<Section> Sections
        {
            get => default;
            set
            {
            }
        }

        public IList<StorageRoom> StorageRooms
        {
            get => default;
            set
            {
            }
        }

        public IList<Apartment> Apartments
        {
            get => default;
            set
            {
            }
        }

        public IList<Parking> Parkings
        {
            get => default;
            set
            {
            }
        }
    }
}