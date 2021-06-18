// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Maps.Featurestate
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FeatureState.
    /// </summary>
    public static partial class FeatureStateExtensions
    {
            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// This POST API allows the user to create a new Stateset and define stateset
            /// style using request body.
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK. The Feature State API is part
            /// of Creator.
            ///
            /// The Feature State service allows the user to update the states of a feature
            /// and query them to be used in other services. The dynamic properties of a
            /// feature that don't belong to the dataset are referred to as *states* here.
            ///
            /// This Feature State service pivot on the Stateset. Like Tileset, Stateset
            /// encapsulates the storage mechanism for feature states for a dataset.
            ///
            /// Once the stateset is created, users can use that statesetId to post feature
            /// state updates and retrieve the current feature states. A feature can have
            /// only one state at a given point in time.
            ///
            /// Feature state is defined by the key name, value and the timestamp. When a
            /// feature state update is posted to Azure Maps, the state value gets updated
            /// only if the provided state’s timestamp is later than the stored timestamp.
            ///
            /// Azure Maps MapControl provides a way to use these feature states to style
            /// the features. Please refer to the State Tile documentation for more
            /// information.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='datasetId'>
            /// The datasetId must have been obtained from a successful [Dataset Create
            /// API](https://docs.microsoft.com/en-us/rest/api/maps/v2/dataset/create)
            /// call.
            /// </param>
            /// <param name='statesetCreateRequestBody'>
            /// The stateset style JSON data.
            /// </param>
            /// <param name='description'>
            /// Description for the stateset. Max length allowed is 1000.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StatesetCreatedResponse> CreateStatesetAsync(this IFeatureState operations, string datasetId, StylesObject statesetCreateRequestBody, string description = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateStatesetWithHttpMessagesAsync(datasetId, statesetCreateRequestBody, description, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// This API allows the caller to fetch a list of all previously successfully
            /// created statesets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StatesetListResponse> ListStatesetAsync(this IFeatureState operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListStatesetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// This PUT API allows the user to update the stateset style rules.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='statesetId'>
            /// The stateset id that was created.
            /// </param>
            /// <param name='statesetStyleUpdateRequestBody'>
            /// The stateset style JSON data. Only style rules are allowed to be updated,
            /// update on keyname and type is not allowed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutStatesetAsync(this IFeatureState operations, string statesetId, StylesObject statesetStyleUpdateRequestBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.PutStatesetWithHttpMessagesAsync(statesetId, statesetStyleUpdateRequestBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// This DELETE API allows the user to delete the stateset and the associated
            /// data.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='statesetId'>
            /// The stateset id that was created.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteStatesetAsync(this IFeatureState operations, string statesetId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteStatesetWithHttpMessagesAsync(statesetId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// This GET API allows the user to get the stateset Information.
            ///
            /// The stateset Information includes the datasetId associated to the stateset,
            /// and the styles of that stateset.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='statesetId'>
            /// The stateset id that was created.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<StatesetGetResponse> GetStatesetAsync(this IFeatureState operations, string statesetId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStatesetWithHttpMessagesAsync(statesetId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// This PUT API allows the user to update the state of the given feature in
            /// the given stateset.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='statesetId'>
            /// The stateset id that was created.
            /// </param>
            /// <param name='featureId'>
            /// The id of a feature in the given dataset. If the featureId is not present
            /// in the dataset, Bad Request response will be returned.
            /// </param>
            /// <param name='featureStateUpdateRequestBody'>
            /// The feature state JSON data. A feature can have only one state at a given
            /// point in time. The specified state keyname must have been defined during
            /// the stateset creation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateStatesAsync(this IFeatureState operations, string statesetId, string featureId, FeatureStatesStructure featureStateUpdateRequestBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateStatesWithHttpMessagesAsync(statesetId, featureId, featureStateUpdateRequestBody, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// This API deletes the state information identified by the StateKeyName
            /// parameter for the feature identified by the FeatureId parameter in the the
            /// stateset.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='statesetId'>
            /// The stateset id that was created.
            /// </param>
            /// <param name='featureId'>
            /// The id of a feature in the given stateset. If no state was set for the
            /// featureId in the stateset earlier, Bad Request response will be returned.
            /// </param>
            /// <param name='stateKeyName'>
            /// The Name of the state to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteStateAsync(this IFeatureState operations, string statesetId, string featureId, string stateKeyName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteStateWithHttpMessagesAsync(statesetId, featureId, stateKeyName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// **Applies to:** see pricing [tiers](https://aka.ms/AzureMapsPricingTier).
            ///
            /// Creator makes it possible to develop applications based on your private
            /// indoor map data using Azure Maps API and SDK.
            /// [This](https://docs.microsoft.com/azure/azure-maps/creator-indoor-maps)
            /// article introduces concepts and tools that apply to Azure Maps Creator.
            ///
            /// This API returns the current state information associated with the given
            /// feature in the given stateset.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='statesetId'>
            /// The stateset id that was created.
            /// </param>
            /// <param name='featureId'>
            /// The id of a feature in the given stateset. If no state was set for the
            /// featureId in the stateset earlier, Bad Request response will be returned.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FeatureStatesStructure> GetStatesAsync(this IFeatureState operations, string statesetId, string featureId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStatesWithHttpMessagesAsync(statesetId, featureId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
