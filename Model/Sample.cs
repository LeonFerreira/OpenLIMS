using OpenLims.Model;

namespace OpenLIMS.Model
{
    public class Sample
    {
        public int Id { get; set; }
        public string InternalId { get; set; }
        public string ExternalId { get; set; }
        public Usuario Usuario { get; set; }
    }
}