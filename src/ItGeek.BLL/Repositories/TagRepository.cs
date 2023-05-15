﻿using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using ItGeek.DAL.Interfaces;

namespace ItGeek.BLL.Repositories;

public class TagRepository : GenericRepositoryAsync<Tag>, ITagRepository
{
	public TagRepository(AppDbContext db) : base(db)
	{
	}
}
