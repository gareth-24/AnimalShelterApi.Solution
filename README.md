# _Animal Shelter API_

#### By _**Gareth Grindeland**_

#### _API for animal shelter cats and dogs built with C#, ASP.NET Core, and MySQL_

## Table of Contents

* [Supported Versions](#supported-versions)
* [Technologies Used](#technologies-used)
* [Description](#description)
* [Setup & installation](#setupinstallation-requirements)
* [Endpoints](#endpoints)
* [Optional Query Parameters](#optional-query-string-parameters)
* [Example Get Requests](#example-get-requests)
* [Known-bugs](#known-bugs)
* [License](#license)

## Supported Versions

| Version       | CRUD          |  Pagination     | CORS Enabled           | Randomized Search  |
| ------------- | ------------- | -------------   | -------------          | -------------      | 
| v1            | yes           |   no            | no                     | no                 |
| v2            | yes           |   yes           | enabled for GET        | yes                |


## Technologies Used

* Git
* C#/.NET version 6.0.402
* MySQL Workbench
* Enity Framework Core version 6.0.0
* Swashbuckle version 6.2.3
* Postman / Swagger UI

## Description

_AnimalShelterAPI is an API used to track cats and dogs for a local animal shelter. The starting database is seeded with data for 20 pet residents but the API supports full CRUD functionality to add additional animals and to edit and remove existing ones. Animals are queryable by name, type, weight, user, and availability status. AnimalShelterApi v2 also supports pagination and querying results by page number and page size. This project was built using C#, Entity Framework Core, and MySQL._

## Setup/Installation Requirements

* _Clone this repository to your desktop._
* _Open your shell (e.g., Terminal or GitBash) and navigate to this project's production directory at ```./AnimalShelterApi.Solution/AnimalShelterApi/```._

#### To Configure and Access the Database:
* _Within the production directory "AnimalShelterApi", create a new file called ``appsettings.json``._
* _Within ```appsettings.json```, put the following code, replacing the "uid" and "pwd" values (in the brackets below) with your own username and password for MySQL. Also replace the "database" value with your desired database name._
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=[DATABASE_NAME];uid=[USERNAME];pwd=[PASSWORD];"
  }
}
```
* _Run the terminal command ```dotnet ef database update``` to create the initial MySQL database._

#### To Run the API:
* _Navigate to this project's production directory named ``/AnimalShelterApi``._
* _Run ```dotnet watch run``` in the command line to run the API from your local port. This will also open up Swagger UI in your browser. At this point, you can begin making API calls._

#### Use Swagger UI to test an API call (optional):
* _Open your browser and navigate to the Swagger UI tab._
* _Choose the api version with the dropdown at the top right (v2 is recommended)._
* _To make a GET request, click on the "GET /api/v2/Animals" route, then click the "try it out" button._
* _Optionally, fill out the fields for the query parameters or leave them as the default values._
* _Click the "Execute" button to send the request, then scroll down to see your results. A successful response will return a status code 200 as well as a response body._
* _Reference the different endpoint urls, optional parameters, and example requests listed below. The AnimalShelter API supports Get, Post, Update, and Delete functionality._

## Endpoints
```
GET http://localhost:5000/api/{v1/v2}/animals/
GET http://localhost:5000/api/{v1/v2}/animals/{id}
POST http://localhost:5000/api/{v1/v2}/animals/
PUT http://localhost:5000/api/{v1/v2}/animals/{id}
DELETE http://localhost:5000/api/{v1/v2}/animals/{id}
```
Note: `{id}` is a variable and it should be replaced with the id number of the animal you want to GET, PUT, or DELETE.
Note: `{v1/v2}` indicates the version of the API you want to use. Version 2 contains all functionality of version 1 but also includes pagination for Get results as well as a randomized search feature.

## Optional Query String Parameters


## Example Get Requests

## Additional Requirements for Post Request

## Additional Requirements for Put Request

## Known Bugs

* _No known issues as of 6/9/23_

## License

_MIT License_

_Copyright (c) 2023 Gareth Grindeland_