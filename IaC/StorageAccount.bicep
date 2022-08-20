param location string

resource stxwingpackinglist 'Microsoft.Storage/storageAccounts@2021-09-01' = {
  name: 'stxwingpackinglist'
  location: location
  sku: {
    name: 'Standard_LRS'
  }
  kind: 'BlobStorage'
}
