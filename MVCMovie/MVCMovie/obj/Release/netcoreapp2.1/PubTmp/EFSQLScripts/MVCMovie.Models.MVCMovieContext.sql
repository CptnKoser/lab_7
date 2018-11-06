IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181019005100_AddProperty')
BEGIN
    CREATE TABLE [Movie] (
        [ID] int NOT NULL IDENTITY,
        [Title] nvarchar(60) NOT NULL,
        [ReleaseDate] datetime2 NOT NULL,
        [Genre] nvarchar(30) NOT NULL,
        [Price] decimal(18, 2) NOT NULL,
        [Rating] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Movie] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181019005100_AddProperty')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181019005100_AddProperty', N'2.1.3-rtm-32065');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181026013612_InitialCreate')
BEGIN
    ALTER TABLE [Movie] ADD [PosterURL] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181026013612_InitialCreate')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181026013612_InitialCreate', N'2.1.3-rtm-32065');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181104192644_Reviews')
BEGIN
    CREATE TABLE [Review] (
        [ID] int NOT NULL IDENTITY,
        [Reviewer] nvarchar(60) NOT NULL,
        [userReview] nvarchar(120) NOT NULL,
        [movieID] int NOT NULL,
        CONSTRAINT [PK_Review] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181104192644_Reviews')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181104192644_Reviews', N'2.1.3-rtm-32065');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181104210254_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181104210254_Initial', N'2.1.3-rtm-32065');
END;

GO

