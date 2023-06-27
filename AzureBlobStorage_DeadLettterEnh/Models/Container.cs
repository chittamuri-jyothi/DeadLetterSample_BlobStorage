using System.ComponentModel.DataAnnotations;

namespace AzureBlobStorage_DeadLettterEnh.Models
{
    public class Container
    {
        [Required]
        public string Name { get; set; }
    }
}
