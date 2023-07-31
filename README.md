# RestoFlow Project

RestoFlow is a .NET Web API application with JWT authorization, SQL database, AWS S3 object storage, and Azure App Service for hosting. The App is designed to manage orders and tables in a restaurant.

## Introduction

RestoFlow is a .NET Web API project that provides various endpoints for interacting with resources. The application uses JWT (JSON Web Tokens) for authorization, SQL Server for data storage, AWS S3 for object storage, and is hosted on Azure App Service.

## Prerequisites

Before running the application, ensure you have the following prerequisites installed on your local machine:

- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [AWS Account](https://aws.amazon.com/)

## Getting Started

Follow the steps below to get the application up and running on your local machine:

### 1. Cloning the Repository

Clone this repository to your local machine using the following command:

```bash
git https://github.com/selyami-angelov/RestoFlow.git
```

### 2. Configurations

#### Environment Variables

To configure the application using environment variables, set the following environment variables on your system:

- `AWS_ACCESS_KEY_ID`: YOUR_AWS_ACCESS_KEY_ID
- `AWS_SECRET_ACCESS_KEY`: YOUR_AWS_SECRET_ACCESS_KEY
- `CONNECTION_STRING`: YOUR_SQL_CONNECTION_STRING

Make sure to replace the placeholders (`YOUR_AWS_ACCESS_KEY_ID`, `YOUR_AWS_SECRET_ACCESS_KEY`, `YOUR_SQL_CONNECTION_STRING`, etc.) with your actual values.

### 3. AWS S3 Setup

#### Create AWS S3 Bucket

Before running the application, you need to create an AWS S3 bucket named `resto-flow` in the AWS Management Console. Set the following configurations while creating the bucket:

- Bucket Name: `resto-flow`
- Region: `eu-central-1`

#### Add Public Read Policy

After creating the `resto-flow` bucket, navigate to the bucket's permissions in the AWS Management Console. Click on the "Bucket Policy" and add the following policy to allow public read access:

```json
{
  "Version": "2012-10-17",
  "Statement": [
    {
      "Sid": "PublicReadGetObject",
      "Effect": "Allow",
      "Principal": "*",
      "Action": "s3:GetObject",
      "Resource": "arn:aws:s3:::resto-flow/*"
    }
  ]
}
```

### 4. Db setup

1. Comment out the `DbSeeder` calls in the `OnModelCreating` method in `DbContext`:

```csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);

    FluenAPI.ConfigureOccupiedTables(modelBuilder);
    FluenAPI.ConfigureProducts(modelBuilder);
    FluenAPI.ConfigureReservations(modelBuilder);
    FluenAPI.ConfigureBills(modelBuilder);

    // Comment out the DbSeeder calls
    //DbSeeder.SeedCategories(modelBuilder);
    //DbSeeder.SeedTables(modelBuilder);
    //DbSeeder.SeedProducts(modelBuilder);
    //DbSeeder.SeedOrders(modelBuilder);
    //DbSeeder.SeedOccupiedTables(modelBuilder);
    //DbSeeder.SeedReservations(modelBuilder);
    //DbSeeder.SeedReservationTables(modelBuilder);
}
```

2. Open the Package Manager Console or the terminal and navigate to the project folder.

3. Delete all files in the "Migrations" folder to start fresh with a new initial migration.

4. Apply a new initial migration.

5. After the new migration is added, update the database.

With these steps, you have commented out the seeding configurations, created a new initial migration, and updated the database without applying the seed data.

### Endpoints

Here are the main endpoints available in the API:

- `/api/Account/register` - Register a new user.
- `/api/Account/login` - Authenticate and receive a JWT token.

For more detailed API documentation and to interact with the endpoints, you can refer to the [Swagger documentation](https://resto-flow-api.azurewebsites.net/swagger/index.html).
