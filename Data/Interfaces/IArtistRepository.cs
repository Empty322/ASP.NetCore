﻿using System;
using System.Collections.Generic;
using System.Text;
using Data.Entities;

namespace Data.Interfaces
{
	public interface IArtistRepository : IRepository<Artist>
	{
		IEnumerable<Artist> GetByCountry(Country country);

		IEnumerable<Record> GetRecordsByArtist(Artist artist);
	}
}
