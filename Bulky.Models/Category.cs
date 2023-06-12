using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
	public class Category
	{
		public int Id { get; set; }
		[Required]
		public String Name { get; set; }
		[DisplayName("Order")]
		public int DisplayOrder { get; set; }

	}
}

