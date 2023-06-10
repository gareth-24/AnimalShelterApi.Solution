# _Animal Shelter API_

#### By _**Gareth Grindeland**_

#### _API for animal shelter cats and dogs built with C#, ASP.NET Core, and MySQL_

## Table of Contents

* [Supported Versions](#supported-versions)
* [Technologies Used](#technologies-used)
* [Description](#description)
* [Setup & installation](#setupinstallation-requirements)
* [Endpoints](#endpoints)
* [Optional Query Parameters for GET](#optional-query-string-parameters-for-get-requests)
* [Example Get Requests](#example-get-requests)
* [Requirements for POST](#additional-requirements-for-post-requests)
* [Requirements for PUT and DELETE](#additional-requirements-for-put-and-delete-requests)
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
GET https://localhost:5001/api/{v1/v2}/animals/
GET https://localhost:5001/api/{v1/v2}/animals/{id}
GET https://localhost:5001/api/v2/Animals/random
POST https://localhost:5001/api/{v1/v2}/animals/
PUT https://localhost:5001/api/{v1/v2}/animals/{id}
DELETE https://localhost:5001/api/{v1/v2}/animals/{id}
```
* Note: `{id}` is a variable and it should be replaced with the id number of the animal you want to GET, PUT, or DELETE.
* Note: `{v1/v2}` indicates the version of the API you want to use. Version 2 contains all functionality of version 1 but also includes pagination for Get results as well as a randomized search feature.

## Optional Query String Parameters for GET Requests

| Parameter   | Type        |  Required    | Description |
| ----------- | ----------- | -----------  | ----------- | 
| name        | String      | Not Required |  Returns animals with a matching Name value                        |
| type        | String      | Not Required |  Returns animals with a matching Type value                        |
| minWeight   | Int         | Not Required |  Returns animals above the specified Weight                        |
| maxWeight   | Int         | Not Required |  Returns animals below the specified Weight                        |
| available   | String      | Not Required |  Returns animals with a matching AvailibilityStatus Value (true or false)   |
| pageNumber  | Int         | Not Required (default = 1)    |  Returns animals from the specified page number       |
| pageSize    | Int         | Not Required (default = 1000) |  Controls the amount of animals returned on each page |

## Example GET Requests

* _To make an Api version 2.0 call searching for an animal named "Tucker":_
* _URL: 'https://localhost:5001/api/v2/Animals?name=Tucker'_
* _Result:_
```
[
  {
    "animalId": 2,
    "name": "Tucker",
    "type": "Dog",
    "weight": 8,
    "description": "Curious and cuddly Scottish Fold. Gets along well with other cats and dogs.",
    "intakeDate": "2023-05-14T00:00:00",
    "availabilityStatus": true
  }
]
```

* _Api version 1.0 call searching for kittens of weight less than or equal to 6 lbs:_
* _URL: 'https://localhost:5001/api/v1/Animals?type=Cat&maxWeight=6'_
* _Result:_
```
[
  {
    "animalId": 3,
    "name": "Mittens",
    "type": "Cat",
    "weight": 6,
    "description": "Fluffy and independent Maine Coon. Prefers a calm environment without other pets.",
    "intakeDate": "2023-05-15T00:00:00",
    "availabilityStatus": true
  },
  {
    "animalId": 9,
    "name": "Oscar",
    "type": "Cat",
    "weight": 5,
    "description": "Laid-back and affectionate Ragdoll. Loves being held and cuddled.",
    "intakeDate": "2023-05-21T00:00:00",
    "availabilityStatus": true
  },
  {
    "animalId": 13,
    "name": "Lily",
    "type": "Cat",
    "weight": 6,
    "description": "Independent and graceful Persian. Prefers a calm and quiet environment.",
    "intakeDate": "2023-05-25T00:00:00",
    "availabilityStatus": true
  },
  {
    "animalId": 19,
    "name": "Sophie",
    "type": "Cat",
    "weight": 6,
    "description": "Affectionate and gentle Himalayan. Enjoys a calm and peaceful environment.",
    "intakeDate": "2023-05-31T00:00:00",
    "availabilityStatus": true
  }
]
```
* _Api version 2.0 call searching for page 1 of dogs available for adoption, with 4 dogs listed per page:_
* _URL: 'https://localhost:5001/api/v2/Animals?type=Dog&available=true&pageNumber=1&pageSize=4'_
* _Result:_
```
[
  {
    "animalId": 2,
    "name": "Tucker",
    "type": "Dog",
    "weight": 8,
    "description": "Curious and cuddly Scottish Fold. Gets along well with other cats and dogs.",
    "intakeDate": "2023-05-14T00:00:00",
    "availabilityStatus": true
  },
  {
    "animalId": 4,
    "name": "Buddy",
    "type": "Dog",
    "weight": 12,
    "description": "Energetic and loyal Labrador Retriever. Great with kids and loves to play fetch.",
    "intakeDate": "2023-05-16T00:00:00",
    "availabilityStatus": true
  },
  {
    "animalId": 8,
    "name": "Bailey",
    "type": "Dog",
    "weight": 6,
    "description": "Cheerful and obedient Beagle. Enjoys long walks and exploring new scents.",
    "intakeDate": "2023-05-20T00:00:00",
    "availabilityStatus": true
  },
  {
    "animalId": 10,
    "name": "Rocky",
    "type": "Dog",
    "weight": 14,
    "description": "Strong and protective Rottweiler. Needs an experienced owner and plenty of exercise.",
    "intakeDate": "2023-05-22T00:00:00",
    "availabilityStatus": true
  }
]
```
* _To make an Api version 2.0 call for a randomized animal:_
* _URL: 'https://localhost:5001/api/v2/Animals/random'_

## Additional Requirements for POST Requests
* _For Post requests, the body is required to add a new animal (see below)._
* _URL: 'https://localhost:5001/api/v2/Animals'_
* _Body:_
```
  {
    "name": "Rocky",
    "type": "Dog",
    "weight": 14,
    "description": "Strong and protective Rottweiler. Needs an experienced owner and plenty of exercise.",
    "intakeDate": "2023-05-22T00:00:00",
    "availabilityStatus": true
  }
```

## Additional Requirements for PUT and DELETE Requests
* _Put requests require an "id" value for the animal that you want to update or delete, as well as an updated body (see below)._
* _URL: 'https://localhost:5001/api/v2/Animals/1'_
* _Body:_
```
{
    "animalId": 1,
    "name": "Winnie",
    "type": "Cat",
    "weight": 8,
    "description": "Curious and cuddly Scottish Fold. Gets along well with other cats and dogs.",
    "intakeDate": "2023-05-14T00:00:00",
    "availabilityStatus": false
}
```
* _Delete requests require an "id" value for the animal that you want to delete, but no body is needed._
* _URL: 'https://localhost:5001/api/v2/Animals/5'_

## Known Bugs

* _No known issues as of 6/9/23_

## License

_MIT License_

_Copyright (c) 2023 Gareth Grindeland_