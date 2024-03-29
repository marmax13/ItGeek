﻿using Microsoft.EntityFrameworkCore;

namespace ItGeek.DAL.Entities;

[Keyless]

public class PostCategory
{
	public int PostId { get; set; }
	public int CategoryId { get; set; }
	public Post Post { get; set; } = null!;
	public Category Category { get; set; } = null!;
}
