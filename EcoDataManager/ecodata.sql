-- Creating the 'Species' table
CREATE TABLE Species (
    SpeciesId INT PRIMARY KEY IDENTITY,
    Name NVARCHAR(100),
    Category NVARCHAR(50),  -- Categories like Flora, Fauna
    ConservationStatus NVARCHAR(50)
);

-- Creating the 'Observations' table
CREATE TABLE Observations (
    ObservationId INT PRIMARY KEY IDENTITY,
    SpeciesId INT,
    Location NVARCHAR(100),
    Date DATE,
    Quantity INT,
    FOREIGN KEY (SpeciesId) REFERENCES Species(SpeciesId)
);

-- Creating the 'Environment' table
CREATE TABLE Environment (
    Location NVARCHAR(100),
    Date DATE,
    Temperature DECIMAL(5, 2),
    Humidity DECIMAL(5, 2),
    AirQualityIndex INT,
    PRIMARY KEY (Location, Date)
);
