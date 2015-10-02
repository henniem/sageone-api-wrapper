﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SageOneApi.Models;

namespace SageOneApi.Tests
{
	[TestClass]
	public class ItemNoteTests : TestBase
	{
		[TestMethod]
		public void GetAll()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var itemNotes = api.ItemNoteRequest.Get();
		}

		[TestMethod]
		public void Get()
		{
			int itemNoteId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var itemNote = api.ItemNoteRequest.Get(itemNoteId);
		}

		[TestMethod]
		public void Save()
		{
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
		    var itemNote = new ItemNote
		    {
		        ItemId = 0,
                Status = true,
                ActionDate = DateTime.Now,
                EntryDate = DateTime.Now,
                HasAttachments = false,
                Subject = "A note about this item",
                Note = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Morbi at scelerisque tortor."
            };

		    var newItemNote = api.ItemNoteRequest.Save(itemNote);
		}

		[TestMethod]
		public void Delete()
		{
			int itemNoteId = 0;
			var api = new ApiRequest(Username, Password, Apikey, CompanyId);
			var result = api.ItemNoteRequest.Delete(itemNoteId);
		}
	}
}