# Azure.Communication.PhoneNumbers

Run `dotnet msbuild /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
public-clients: true
tag: package-phonenumber-2024-03-01-preview
model-namespace: false
require:
    -  https://raw.githubusercontent.com/Azure/azure-rest-api-specs/b56afb26c5450157006a3a1d9be57bae429051a2/specification/communication/data-plane/PhoneNumbers/readme.md
title: Phone numbers
payload-flattening-threshold: 3
generation1-convenience-client: true
```

### Change naming of countryCode to twoLetterIsoCountryName
``` yaml
directive:
  from: swagger-document
  where: $.paths.*.get.parameters[?(@.name == "countryCode")]
  transform: >
    $["x-ms-client-name"] = "twoLetterIsoCountryName";
```

``` yaml
directive:
  from: swagger-document
  where: $.paths.*.post.parameters[?(@.name == "countryCode")]
  transform: >
    $["x-ms-client-name"] = "twoLetterIsoCountryName";
```
### Change naming of Error to ErrorMessage
``` yaml
directive:
  from: swagger-document
  where: "$.definitions.PhoneNumberSearchResult.properties.error"
  transform: >
    $["x-ms-enum"].name = "ErrorMessage";
```

``` yaml
directive:
  from: swagger-document
  where: $.parameters.Endpoint
  transform: >
    $["format"] = "";
```

# Removed Models
``` yaml
directive:
  - remove-operation-match: /.*Reservation.*/i
  - remove-operation: PhoneNumbers_BrowseAvailableNumbers
  - remove-model: PhoneNumbersReservation
  - remove-model: PhoneNumbersReservations
  - remove-model: PhoneNumbersBrowseRequest
  - remove-model: PhoneNumbersBrowseResult
  - remove-model: PhoneNumberBrowseCapabilitiesRequest
  - remove-model: PhoneNumbersReservationPurchaseRequest
  - remove-model: Error
  - remove-model: AvailablePhoneNumber
  - remove-model: AvailablePhoneNumberCost
