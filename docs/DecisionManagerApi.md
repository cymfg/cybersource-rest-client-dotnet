# CyberSource.Api.DecisionManagerApi

All URIs are relative to *https://apitest.cybersource.com*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddNegative**](DecisionManagerApi.md#addnegative) | **POST** /risk/v1/lists/{type}/entries | List Management
[**CreateDecisionManagerCase**](DecisionManagerApi.md#createdecisionmanagercase) | **POST** /risk/v1/decisions | Create Decision Manager Case
[**FraudUdate**](DecisionManagerApi.md#fraududate) | **POST** /risk/v1/decisions/{id}/marking | Fraud Marking


<a name="addnegative"></a>
# **AddNegative**
> RiskV1UpdatePost201Response AddNegative (string type, AddNegativeListRequest addNegativeListRequest)

List Management

This call adds/deletes/converts the request information in the negative list.  Provide the list to be updated as the path parameter. This value can be 'postiive', 'negative' or 'review'. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class AddNegativeExample
    {
        public void main()
        {
            var apiInstance = new DecisionManagerApi();
            var type = type_example;  // string | The list to be updated. It can be 'positive', 'negative' or 'review'.
            var addNegativeListRequest = new AddNegativeListRequest(); // AddNegativeListRequest | 

            try
            {
                // List Management
                RiskV1UpdatePost201Response result = apiInstance.AddNegative(type, addNegativeListRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DecisionManagerApi.AddNegative: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The list to be updated. It can be &#39;positive&#39;, &#39;negative&#39; or &#39;review&#39;. | 
 **addNegativeListRequest** | [**AddNegativeListRequest**](AddNegativeListRequest.md)|  | 

### Return type

[**RiskV1UpdatePost201Response**](RiskV1UpdatePost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createdecisionmanagercase"></a>
# **CreateDecisionManagerCase**
> RiskV1DecisionsPost201Response CreateDecisionManagerCase (CreateDecisionManagerCaseRequest createDecisionManagerCaseRequest)

Create Decision Manager Case

This is the combined request to the Decision Manager Service for a transaction sent to Cybersource. Decision Manager will return a decision based on the request values. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class CreateDecisionManagerCaseExample
    {
        public void main()
        {
            var apiInstance = new DecisionManagerApi();
            var createDecisionManagerCaseRequest = new CreateDecisionManagerCaseRequest(); // CreateDecisionManagerCaseRequest | 

            try
            {
                // Create Decision Manager Case
                RiskV1DecisionsPost201Response result = apiInstance.CreateDecisionManagerCase(createDecisionManagerCaseRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DecisionManagerApi.CreateDecisionManagerCase: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createDecisionManagerCaseRequest** | [**CreateDecisionManagerCaseRequest**](CreateDecisionManagerCaseRequest.md)|  | 

### Return type

[**RiskV1DecisionsPost201Response**](RiskV1DecisionsPost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="fraududate"></a>
# **FraudUdate**
> RiskV1UpdatePost201Response FraudUdate (string id, FraudMarkingActionRequest fraudMarkingActionRequest)

Fraud Marking

This can be used to - 1. Add known fraudulent data to the fraud history 2. Remove data added to history with Transaction Marking Tool or by uploading chargeback files 3. Remove chargeback data from history that was automatically added. For detailed information, contact your Cybersource representative  Place the request ID of the transaction you want to mark as suspect (or remove from history) as the path parameter in this request. 

### Example
```csharp
using System;
using System.Diagnostics;
using CyberSource.Api;
using CyberSource.Client;
using CyberSource.Model;

namespace Example
{
    public class FraudUdateExample
    {
        public void main()
        {
            var apiInstance = new DecisionManagerApi();
            var id = id_example;  // string | Request ID of the transaction that you want to mark as suspect or remove from history.
            var fraudMarkingActionRequest = new FraudMarkingActionRequest(); // FraudMarkingActionRequest | 

            try
            {
                // Fraud Marking
                RiskV1UpdatePost201Response result = apiInstance.FraudUdate(id, fraudMarkingActionRequest);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DecisionManagerApi.FraudUdate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| Request ID of the transaction that you want to mark as suspect or remove from history. | 
 **fraudMarkingActionRequest** | [**FraudMarkingActionRequest**](FraudMarkingActionRequest.md)|  | 

### Return type

[**RiskV1UpdatePost201Response**](RiskV1UpdatePost201Response.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json;charset=utf-8
 - **Accept**: application/hal+json;charset=utf-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

