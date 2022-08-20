targetScope = 'subscription'

var location = 'uksouth'

resource rgxwingpackinglist 'Microsoft.Resources/resourceGroups@2021-01-01' = {
  name: 'rg-xwingpackinglist'
  location: location
}

module appservice 'AppService.bicep' = {
  name: 'appservice'
  scope: rgxwingpackinglist
  params: {
    location: rgxwingpackinglist.location
  }
}

module storageaccount 'StorageAccount.bicep' = {
  name: 'storage'
  scope: rgxwingpackinglist
  params: {
    location: rgxwingpackinglist.location
  }
}
