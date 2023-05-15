﻿namespace ItGeek.DAL.Entities;

public class PostAuthor
{
	public int PostId { get; set; }
	public int AuthorId { get; set; }
	public Post Post { get; set; } = null!;
	public Author Author { get; set; } = null!;
}
