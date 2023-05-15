﻿using ItGeek.DAL.Data;
using ItGeek.DAL.Entities;
using ItGeek.DAL.Interfaces;

namespace ItGeek.BLL.Repositories;

public class UserRepository : GenericRepositoryAsync<User>, IUserRepository
{
	public UserRepository(AppDbContext db) : base(db)
	{
	}
}
