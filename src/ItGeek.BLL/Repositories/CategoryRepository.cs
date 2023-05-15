﻿using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using ItGeek.DAL.Interfaces;

namespace ItGeek.BLL.Repositories;

public class CategoryRepository : GenericRepositoryAsync<Category>, ICategoryRepository
{
	public CategoryRepository(AppDbContext db) : base(db)
	{
	}
}
