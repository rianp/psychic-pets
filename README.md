## Psychic Pets .NET Controller-based API
**Welcome to the Psychic Pets API! This API provides a platform for interacting with our psychic pets, where you can discover their mystical talents and unique abilities.**

Before you begin, make sure you have the following prerequisites installed:

[.NET Core SDK](https://dotnet.microsoft.com/en-us/download) (version 6 or higher)

[Docker](https://www.docker.com/get-started/) (if you plan to use Docker)


### Running the Application
Clone this repository to your local machine:

```bash
git clone https://github.com/rianp/psychic-pets.git
```

Navigate to the PsychicPets directory:

```bash
cd psychic-pets/PsychicPets
```

Run the application using the following command:
```bash 
dotnet run
```

The API will be accessible at http://localhost:5229/swagger/index.html.

### Running Tests

Navigate to the PsychicPets.Tests directory:

```bash
cd psychic-pets/PsychicPets.Tests
```
Run the tests using the following command:

```bash
dotnet test
```
This will execute all the unit tests and provide you with test results.

### API Endpoints
For the moment, Here are some of the API endpoints you can access:

GET /WeatherForecast - Get the weather forecast.

### Docker Support
You can also run the Psychic Pets API using Docker:

Make sure Docker is installed and running on your machine.

Navigate to the psychic-pets directory where the docker-compose.yml file is located.

Run the following command to build and start the Docker containers:

```bash 
docker-compose up
```