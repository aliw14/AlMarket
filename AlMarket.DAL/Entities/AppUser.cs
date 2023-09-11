﻿using System;
using Microsoft.AspNetCore.Identity;

namespace AlMarket.DAL.Entities
{
	public class AppUser : IdentityUser
	{
		public string? FirstName { get; set; }

		public string? LastName { get; set; }
	}
}
