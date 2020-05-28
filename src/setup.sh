RESOURCE_GROUP=hire-hero-app-rg
PUBLISHER_EMAIL=maciej.gos@altkomsoftware.pl
PUBLISHER_NAME="Maciej Gos"
LOCATION=westeurope

echo 'Create API Management'
az apim create --name "heroapp-apim" --resource-group hire-hero-app-rg --publisher-email maciej.gos@altkomsoftware.pl --location westeurope --sku-name Consumption --publisher-name "Maciej Gos"

echo 'Create Cosmos DB'
az cosmosdb create --name heroapp-cosmosdb --resource-group hire-hero-app-rg

echo 'Create Storage Account for backend app'
az storage account create --name herobackappstorage001 --resource-group hire-hero-app-rg

echo 'Create backoffice Function App'
az functionapp create --name heroback-funcapp --resource-group hire-hero-app-rg --storage-account herobackappstorage001 --consumption-plan-location westeurope --runtime dotnet --os-type Windows

echo 'Create Azure Cognitive Search'
az search service create --name heroapp-search --resource-group hire-hero-app-rg --sku free --location westeurope