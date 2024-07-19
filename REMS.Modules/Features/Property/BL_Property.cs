﻿namespace REMS.Modules.Features.Property;

public class BL_Property
{
    private readonly DA_Property _daProperty;

    public BL_Property(DA_Property daProperty)
    {
        _daProperty = daProperty;
    }

    public async Task<List<PropertyResponseModel>> GetProperties()
    {
        var response = await _daProperty.GetProperties();
        return response;
    }

    public async Task<PropertyListResponseModel> GetProperties(int pageNo, int pageSize)
    {
        if (pageNo < 1 || pageSize < 1)
        {
            throw new Exception("PageNo or PageSize Cannot be less than 1");
        }

        var response = await _daProperty.GetProperties(pageNo, pageSize);
        return response;
    }

    public async Task<PropertyResponseModel> GetPropertyById(int propertyId)
    {
        if (propertyId < 1)
        {
            throw new Exception("Invalid Property Id");
        }

        var response = await _daProperty.GetPropertyById(propertyId);
        return response;
    }

    public async Task<PropertyResponseModel> CreateProperty(PropertyRequestModel requestModel)
    {
        if (requestModel == null)
        {
            throw new ArgumentNullException(nameof(requestModel), "Request model cannot be null");
        }

        var response = await _daProperty.CreateProperty(requestModel);
        return response;
    }

    public async Task<PropertyResponseModel> UpdateProperty(int propertyId, PropertyRequestModel requestModel)
    {
        if (propertyId < 1)
        {
            throw new Exception("Invalid Property Id");
        }

        if (requestModel == null)
        {
            throw new ArgumentNullException(nameof(requestModel), "Request model cannot be null");
        }

        var response = await _daProperty.UpdateProperty(propertyId, requestModel);
        return response;
    }

    public async Task<bool> DeleteProperty(int propertyId)
    {
        if (propertyId < 1)
        {
            throw new Exception("Invalid Property Id");
        }

        var result = await _daProperty.DeleteProperty(propertyId);
        return result;
    }

}