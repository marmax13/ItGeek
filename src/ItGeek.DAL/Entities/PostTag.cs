﻿using Microsoft.EntityFrameworkCore;

namespace ItGeek.DAL.Entities;

[Keyless]

public class PostTag
{
	public int PostId { get; set; }
	public int TagId { get; set; }
	public Post Post { get; set; } = null!;
	public Tag Tag { get; set; } = null!;

	public List<Post> Posts { get; set; }
}
