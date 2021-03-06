﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace NLog.Mvc
{
	/// <summary>
	/// Configures the database object for the LogEntry entity
	/// </summary>
	public class LogEntryConfiguration: EntityTypeConfiguration<LogEntry>
	{
		public LogEntryConfiguration()
		{
			this.ToTable("Log");

			this.Property(e => e.Id)
				.HasColumnName("Id")
				.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

			this.HasKey(e => e.Id);

			this.Property(e => e.TimeStamp)
				.HasColumnName("TimeStamp")
				.IsRequired();

			this.Property(e => e.Level)
				.IsRequired()
				.HasColumnName("Level")
				.IsUnicode()
				.HasMaxLength(5);

			this.Property(e => e.Logger)
				.IsRequired()
				.HasColumnName("Logger")
				.IsUnicode()
				.IsVariableLength()
				.HasMaxLength(200);

			this.Property(e => e.Message)
				.IsRequired()
				.HasColumnName("Message")
				.IsUnicode()
				.IsVariableLength();

			this.Property(e => e.ExceptionType)
				.IsOptional()
				.HasColumnName("ExceptionType")
				.IsUnicode()
				.IsVariableLength();

			this.Property(e => e.Operation)
				.IsOptional()
				.HasColumnName("Operation")
				.IsUnicode()
				.IsVariableLength();

			this.Property(e => e.ExceptionMessage)
				.IsOptional()
				.HasColumnName("ExceptionMessage")
				.IsUnicode()
				.IsVariableLength();

			this.Property(e => e.StackTrace)
				.IsOptional()
				.HasColumnName("StackTrace")
				.IsUnicode()
				.IsVariableLength();
		}
	}
}
