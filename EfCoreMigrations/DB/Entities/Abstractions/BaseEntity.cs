﻿namespace EfCoreMigrations.DB.Entities.Abstractions;
public abstract class BaseEntity<T>
{
    public T Id { get; set; }
}
