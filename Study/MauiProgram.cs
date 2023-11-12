﻿namespace Study;
using Microsoft.Maui.Storage;
using Study.Models;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		string dbPath = Path.Combine(FileSystem.AppDataDirectory, "study.db3");
		builder.Services.AddSingleton<StudyAppDb>(s => ActivatorUtilities.CreateInstance<StudyAppDb>(s, dbPath));

		return builder.Build();
	}
}
