DROP DATABASE ComputerGames;

CREATE DATABASE ComputerGames;

USE ComputerGames;

DROP TABLE Games;
DROP TABLE Genres;
DROP TABLE Publishers;

CREATE TABLE Genres (
    Id int NOT NULL  IDENTITY(1,1) PRIMARY KEY,
    Description nvarchar(600) NOT NULL
);

CREATE TABLE Publishers (
    Id int NOT NULL  IDENTITY(1,1) PRIMARY KEY,
    Name nvarchar(max) NOT NULL,
	LicenceNumber int NOT NULL
);

CREATE TABLE Games (
    Name nvarchar(60) NOT NULL,
    ReleaseDate Date NOT NULL,
    GenreId int NOT NULL FOREIGN KEY REFERENCES Genres(Id),
    PublisherId int NOT NULL FOREIGN KEY REFERENCES Publishers(Id),
	PRIMARY KEY (Name, ReleaseDate)
);