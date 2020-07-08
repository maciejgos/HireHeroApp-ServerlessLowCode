
Hire hero company is a project which showcase simple implementation of Workflow process using low code approach. Whole concept of a project is to use as much of cloud native components as possible without writing code.

## The Plan
1. Implementation of basic workflow using Logic Apps
2. Usage of some compute power and serverless approach to fetch some data from Cosmos DB
3. Usage of highly scalable Cosmos DB database
4. Blazor Webassembly frontend hosted in Blob Storage or Static Web Apps

## Architecture
Below diagram shows high level overview of Azure architecture and used components.
![](./src/img/hire-hero-architecture.png)

## Getting started
[Deploy Infrastructure As A Code "ARM Template"]
[Required libraries]

## Components
Low code approach forced to use some specific Azure components. Below is whole infrastructure components used in this demo.
- [API Management](https://azure.microsoft.com/en-us/services/api-management/) - In this demo exists as gateway for our application
- [Logic Apps](https://azure.microsoft.com/en-us/services/logic-apps/) - Process our requests and implements some workflow functionalities
- [Azure Functions](https://azure.microsoft.com/en-us/services/functions/) - Used to return offer requests data
- [Azure Cosmos DB](https://azure.microsoft.com/en-us/services/cosmos-db/) - Store our data in Fast NoSQL database

## Known issues
[List of issues discovered during implementation or not implemented features]