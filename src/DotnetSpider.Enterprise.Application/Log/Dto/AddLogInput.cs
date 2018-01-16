﻿using System.ComponentModel.DataAnnotations;

namespace DotnetSpider.Enterprise.Application.Log.Dto
{
	public class AddLogInput
	{
		[Required]
		public string Token { get; set; }

		[Required]
		public dynamic LogInfo { get; set; }

		[Required]
		public string Identity { get; set; }
	}
}