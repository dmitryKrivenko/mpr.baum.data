namespace MPR.Baum.Data
{
    public class Apartment
    {
        public int ApartmentId { get; set; }
        public int Area { get; set; }

        public Section Section { get; set; }

        public int Floor
        {
            get => default;
            set
            {
            }
        }

        public System.Collections.Generic.IList<Owner> Owners
        {
            get => default;
            set
            {
            }
        }

        public int OwnerId
        {
            get => default;
            set
            {
            }
        }

        public int SectionId
        {
            get => default;
            set
            {
            }
        }
    }
}